using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        [CssName("background")]
        public string Bg { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        [CssName("background-color")]
        public string BgColor { get; set; }

        [Parameter]
        [CssName("background-image")]
        public string BgImage { get; set; }

        [Parameter]
        [CssName("background-size")]
        public string BgSize { get; set; }

        [Parameter]
        [CssName("background-position")]
        public string BgPosition { get; set; }

        [Parameter]
        [CssName("background-repeat")]
        public string BgRepeat { get; set; }

        [Parameter]
        [CssName("background-attachment")]
        public string BgAttachment { get; set; }

        [Parameter]
        [CssName("background-blend-mode")]
        public string BgBlendMode { get; set; }

        [Parameter]
        [CssName("background-clip")]
        public string BgClip { get; set; }

        [Parameter]
        [CssName("background-color")]
        public string Background { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string BackgroundColor { get; set; }

        [Parameter]
        public string BackgroundImage { get; set; }

        [Parameter]
        public string BackgroundSize { get; set; }

        [Parameter]
        public string BackgroundPosition { get; set; }

        [Parameter]
        public string BackgroundRepeat { get; set; }

        [Parameter]
        public string BackgroundAttachment { get; set; }

        [Parameter]
        public string BackgroundBlendMode { get; set; }

        [Parameter]
        public string BackgroundClip { get; set; }
    }
}
