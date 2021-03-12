using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers.Typography
{
    public class FontWeightTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => map;

        private readonly Dictionary<string, string> map = new()
        {
            {"hairline", "100"},
            {"thin", "200"},
            {"light", "300"},
            {"normal", "400"},
            {"medium", "500"},
            {"semibold", "600"},
            {"bold", "700"},
            {"extrabold", "800"},
            {"black", "900"}
        };
    }
}
