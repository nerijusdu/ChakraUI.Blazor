using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers
{
    public class SizesTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformPartialValue(value);

        protected override Dictionary<string, string> GetMap() => map;

        private readonly Dictionary<string, string> map = new()
        {
            {"max", "max-content"},
            {"min", "min-content"},
            {"full", "100%"},
            {"3xs", "14rem"},
            {"2xs", "16rem"},
            {"xs", "20rem"},
            {"sm", "24rem"},
            {"md", "28rem"},
            {"lg", "32rem"},
            {"xl", "36rem"},
            {"2xl", "42rem"},
            {"3xl", "48rem"},
            {"4xl", "56rem"},
            {"5xl", "64rem"},
            {"6xl", "72rem"},
            {"7xl", "80rem"},
            {"8xl", "90rem"},
        };
    }
}
