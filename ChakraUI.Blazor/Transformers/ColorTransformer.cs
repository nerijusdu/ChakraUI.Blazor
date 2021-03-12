using System.Collections.Generic;
using ChakraUI.Blazor.Services;

namespace ChakraUI.Blazor.Transformers
{
    public class ColorTransformer : TransformerBase, IPropertyValueTransformer
    {
        private readonly IColorService colorService;

        public ColorTransformer(IColorService colorService)
        {
            this.colorService = colorService;
        }

        public object Transform(object value) => TransformPartialValue(value);

        protected override Dictionary<string, string> GetMap() => colorService.GetColorMap();
    }
}
