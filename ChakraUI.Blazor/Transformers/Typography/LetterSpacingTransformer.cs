using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers.Typography
{
    public class LeterSpacingTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => map;

        private readonly Dictionary<string, string> map = new()
        {
            {"tighter", "-0.05em"},
            {"tight", "-0.025em"},
            {"normal", "0"},
            {"wide", "0.025em"},
            {"wider", "0.05em"},
            {"widest", "0.1em"}
        };
    }
}
