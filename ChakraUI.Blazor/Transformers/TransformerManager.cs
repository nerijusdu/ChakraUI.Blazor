using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers
{
    public interface ITransformerManager
    {
        string Transform(string cssProperty, object value);
    }

    public class TransformerManager : ITransformerManager
    {
        private Dictionary<string, IPropertyValueTransformer> transformers = new()
        {
            {ColorTransformer.Identifier, new ColorTransformer()}
        };

        private Dictionary<string, string> propertyToTransformerMap = new()
        {
            {"color", ColorTransformer.Identifier},
            {"background", ColorTransformer.Identifier}
        };

        public string Transform(string cssProperty, object value)
        {
            if (!propertyToTransformerMap.ContainsKey(cssProperty))
            {
                return value.ToString();
            }

            var transformer = transformers[propertyToTransformerMap[cssProperty]];
            return transformer.Transform(value);
        }
    }
}
