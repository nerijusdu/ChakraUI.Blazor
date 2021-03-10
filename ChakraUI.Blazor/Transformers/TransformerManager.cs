using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Parameters;

namespace ChakraUI.Blazor.Transformers
{
    public interface ITransformerManager
    {
        string Transform(string propertyName, object value);
    }

    public class TransformerManager : ITransformerManager
    {
        private readonly Dictionary<Type, IPropertyValueTransformer> transformersMap;
        private readonly Dictionary<string, Type> propertyToTransformerMap;

        public TransformerManager()
        {
            propertyToTransformerMap = GetPropertyToTransformerMap();
            transformersMap = GetTransformersMap();
        }

        public string Transform(string propertyName, object value)
        {
            if (!propertyToTransformerMap.ContainsKey(propertyName))
            {
                return value.ToString();
            }

            var transformer = transformersMap[propertyToTransformerMap[propertyName]];
            return transformer.Transform(value);
        }

        private Dictionary<string, Type> GetPropertyToTransformerMap()
        {
            return typeof(StyledComponentBase)
                .GetProperties()
                .Select(x => new
                {
                    Attribute = x.GetCustomAttribute<TransformerAttribute>(),
                    Name = x.Name
                })
                .Where(x => x.Attribute != null)
                .ToDictionary(x => x.Name, x => x.Attribute.TransformerType);
        }

        private Dictionary<Type, IPropertyValueTransformer> GetTransformersMap()
        {
            var type = typeof(IPropertyValueTransformer);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && type != p)
                .ToDictionary(t => t, t => (IPropertyValueTransformer)Activator.CreateInstance(t));
        }
    }
}
