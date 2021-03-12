using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers.Typography
{
    public class FontSizesTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => map;

        private readonly Dictionary<string, string> map = new()
        {
            {"xs", "0.75rem"},
            {"sm", "0.875rem"},
            {"md", "1rem"},
            {"lg", "1.125rem"},
            {"xl", "1.25rem"},
            {"2xl", "1.5rem"},
            {"3xl", "1.875rem"},
            {"4xl", "2.25rem"},
            {"5xl", "3rem"},
            {"6xl", "3.75rem"},
            {"7xl", "4.5rem"},
            {"8xl", "6rem"},
            {"9xl", "8rem"}
        };
    }
}
