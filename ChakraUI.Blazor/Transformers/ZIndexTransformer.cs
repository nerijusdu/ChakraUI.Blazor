using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers
{
    public class ZIndexTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => radiusMap;

        private readonly Dictionary<string, string> radiusMap = new()
        {
            {"hide", "-1"},
            {"auto", "auto"},
            {"base", "0"},
            {"docked", "10"},
            {"dropdown", "1000"},
            {"sticky", "1100"},
            {"banner", "1200"},
            {"overlay", "1300"},
            {"modal", "1400"},
            {"popover", "1500"},
            {"skipLink", "1600"},
            {"toast", "1700"},
            {"tooltip", "1800"}
        };
    }
}
