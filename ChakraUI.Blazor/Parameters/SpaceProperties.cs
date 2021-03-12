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
        public string M { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Margin { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top")]
        public string Mt { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginTop { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-right")]
        public string Mr { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginRight { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-bottom")]
        public string Mb { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left")]
        public string Ml { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left", "margin-right")]
        public string Mx { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginInline { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-left", "margin-right")]
        public string MarginX { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public string My { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MarginBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public string MarginY { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding")]
        public string P { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Padding { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top")]
        public string Pt { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingTop { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-right")]
        public string Pr { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingRight { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-bottom")]
        public string Pb { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left")]
        public string Pl { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left", "padding-right")]
        public string Px { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingInline { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-left", "padding-right")]
        public string PaddingX { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public string Py { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string PaddingBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public string PaddingY { get; set; }
    }
}
