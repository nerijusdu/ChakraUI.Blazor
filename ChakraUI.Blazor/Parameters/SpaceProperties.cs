using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin")]
        public string M { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string Margin { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-top")]
        public string Mt { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginTop { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-right")]
        public string Mr { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginRight { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-bottom")]
        public string Mb { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-left")]
        public string Ml { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-left", "margin-right")]
        public string Mx { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginInline { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-left", "margin-right")]
        public string MarginX { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public string My { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string MarginBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("margin-top", "margin-bottom")]
        public string MarginY { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding")]
        public string P { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string Padding { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-top")]
        public string Pt { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingTop { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-right")]
        public string Pr { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingRight { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-bottom")]
        public string Pb { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingBottom { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-left")]
        public string Pl { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingLeft { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-left", "padding-right")]
        public string Px { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingInline { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-left", "padding-right")]
        public string PaddingX { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public string Py { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        public string PaddingBlock { get; set; }

        [Parameter]
        [Transformer(typeof(SpacingTransformer))]
        [CssName("padding-top", "padding-bottom")]
        public string PaddingY { get; set; }
    }
}
