using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin")]
        public object M { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object Margin { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top")]
        public object Mt { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginTop { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-right")]
        public object Mr { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginRight { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-bottom")]
        public object Mb { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left")]
        public object Ml { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left", "margin-right")]
        public object Mx { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginInline { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left", "margin-right")]
        public object MarginX { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public object My { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MarginBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public object MarginY { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding")]
        public object P { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object Padding { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top")]
        public object Pt { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingTop { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-right")]
        public object Pr { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingRight { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-bottom")]
        public object Pb { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left")]
        public object Pl { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left", "padding-right")]
        public object Px { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingInline { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left", "padding-right")]
        public object PaddingX { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public object Py { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object PaddingBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public object PaddingY { get; set; }
    }
}
