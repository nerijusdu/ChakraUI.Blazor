using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string Bg { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string BgColor { get; set; }

        [Parameter]
        public string BgImage { get; set; }

        [Parameter]
        public string BgSize { get; set; }

        [Parameter]
        public string BgPosition { get; set; }

        [Parameter]
        public string BgRepeat { get; set; }

        [Parameter]
        public string BgAttachment { get; set; }

        [Parameter]
        public string BgBlendMode { get; set; }

        [Parameter]
        public string BgClip { get; set; }

        [Parameter]
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
