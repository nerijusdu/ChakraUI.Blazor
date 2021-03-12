using System.Collections.Generic;
using System.Linq;

namespace ChakraUI.Blazor.Transformers
{
    public class ColorTransformer : IPropertyValueTransformer
    {
        private readonly List<string> colorMapKeys;
        private readonly Dictionary<string, string> colorMap = new()
        {
            {"red.100", "#FED7D7"},
            {"red.900", "#63171B"}
        };

        public ColorTransformer()
        {
            colorMapKeys = colorMap.Keys.ToList();
        }

        public object Transform(object value)
        {
            var valueStr = value?.ToString() ?? string.Empty;
            return colorMapKeys
                .Where(x => valueStr.Contains(x))
                .Aggregate(
                    valueStr,
                    (current, colorKey) => current.Replace(colorKey, colorMap[colorKey]));
        }
    }
}
