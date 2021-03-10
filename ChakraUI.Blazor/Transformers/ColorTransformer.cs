using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers
{
    public class ColorTransformer : IPropertyValueTransformer
    {
        private readonly Dictionary<string, string> colorMap = new()
        {
            {"red.100", "#FED7D7"},
            {"red.900", "#63171B"}
        };

        public string Transform(object value)
        {
            var key = value.ToString();
            return colorMap.ContainsKey(key) ? colorMap[key] : key;
        }
    }
}
