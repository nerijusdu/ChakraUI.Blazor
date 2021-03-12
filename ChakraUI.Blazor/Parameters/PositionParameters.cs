using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(ZIndexTransformer))]
        public string ZIndex { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Top { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Right { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Bottom { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Left { get; set; }

        [Parameter]
        [CssName("top", "bottom", "left", "right")]
        [Transformer(typeof(SizesTransformer))]
        public string Inset { get; set; }

        [Parameter]
        [CssName("left", "right")]
        [Transformer(typeof(SizesTransformer))]
        public string InsetX { get; set; }

        [Parameter]
        [CssName("top", "bottom")]
        [Transformer(typeof(SizesTransformer))]
        public string InsetY { get; set; }

        [Parameter]
        [CssName("position")]
        public string Pos { get; set; }

        [Parameter]
        public string Position { get; set; }

        [Parameter]
        public string InsetInline { get; set; }

        [Parameter]
        public string InsetBlock { get; set; }
    }
}
