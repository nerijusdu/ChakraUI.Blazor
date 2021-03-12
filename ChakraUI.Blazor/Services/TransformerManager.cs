using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Parameters;
using ChakraUI.Blazor.Transformers;

namespace ChakraUI.Blazor.Services
{
    public interface ITransformerManager
    {
        string Transform(string propertyName, object value);
    }

    public class TransformerManager : ITransformerManager
    {
        private static Dictionary<Type, IPropertyValueTransformer> transformersMap;
        private static Dictionary<string, Type[]> propertyToTransformerMap;
        private readonly IColorService colorService;

        public TransformerManager(IColorService colorService)
        {
            this.colorService = colorService;
            propertyToTransformerMap = GetPropertyToTransformerMap();
            transformersMap = GetTransformersMap();
        }

        public string Transform(string propertyName, object value)
        {
            if (!propertyToTransformerMap.ContainsKey(propertyName))
            {
                return value.ToString();
            }

            return propertyToTransformerMap[propertyName]
                .Aggregate(value, (current, type) => transformersMap[type].Transform(current))
                .ToString();
        }

        private static Dictionary<string, Type[]> GetPropertyToTransformerMap()
        {
            return typeof(StyledComponentBase)
                .GetProperties()
                .Select(x => new
                {
                    Attribute = x.GetCustomAttribute<TransformerAttribute>(),
                    Name = x.Name
                })
                .Where(x => x.Attribute != null)
                .ToDictionary(x => x.Name, x => x.Attribute.TransformerTypes);
        }

        private Dictionary<Type, IPropertyValueTransformer> GetTransformersMap()
        {
            var type = typeof(IPropertyValueTransformer);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && type != p)
                .ToDictionary(t => t, t => t switch
                {
                    var transformerType when transformerType == typeof(ColorTransformer) => new ColorTransformer(colorService),
                    _ => (IPropertyValueTransformer)Activator.CreateInstance(t)
                });
        }
    }
}
