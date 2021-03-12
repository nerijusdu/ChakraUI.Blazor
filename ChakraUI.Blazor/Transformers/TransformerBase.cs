using System.Collections.Generic;
using System.Linq;

namespace ChakraUI.Blazor.Transformers
{
    public abstract class TransformerBase
    {
        protected abstract Dictionary<string, string> GetMap();
        private List<string> mapKeys;
        private List<string> MapKeys => (mapKeys ??= GetMap().Keys.ToList());

        protected object TransformWholeValue(object value)
        {
            var valueStr = value?.ToString() ?? string.Empty;
            return GetMap().ContainsKey(valueStr) ? GetMap()[valueStr] : valueStr;
        }

        protected object TransformPartialValue(object value)
        {
            var valueStr = value?.ToString() ?? string.Empty;
            return MapKeys
                .Where(x => valueStr.Contains(x))
                .Aggregate(
                    valueStr,
                    (current, key) => current.Replace(key, GetMap()[key]));
        }
    }
}
