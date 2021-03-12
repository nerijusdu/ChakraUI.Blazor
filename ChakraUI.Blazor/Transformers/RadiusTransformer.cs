using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers
{
    public class RadiusTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => radiusMap;

        private readonly Dictionary<string, string> radiusMap = new()
        {
            {"none", "0"},
            {"sm", "0.125rem"},
            {"base", "0.25rem"},
            {"md", "0.375rem"},
            {"lg", "0.5rem"},
            {"xl", "0.75rem"},
            {"2xl", "1rem"},
            {"3xl", "1.5rem"},
            {"full", "9999px"}
        };
    }
}
