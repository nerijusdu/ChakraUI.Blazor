using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers.Typography;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(FontWeightTransformer))]
        public string FontWeight { get; set; }

        [Parameter]
        [Transformer(typeof(LineHeightTransformer))]
        public string LineHeight { get; set; }

        [Parameter]
        [Transformer(typeof(LeterSpacingTransformer))]
        public string LetterSpacing { get; set; }

        [Parameter]
        [Transformer(typeof(FontSizesTransformer))]
        public string FontSize { get; set; }

        [Parameter]
        [Transformer(typeof(FontTransformer))]
        public string FontFamily { get; set; }

        [Parameter]
        public string TextAlign { get; set; }

        [Parameter]
        public string FontStyle { get; set; }

        [Parameter]
        public string WordBreak { get; set; }

        [Parameter]
        public string OverflowWrap { get; set; }

        [Parameter]
        public string TextOverflow { get; set; }

        [Parameter]
        public string TextTransform { get; set; }

        [Parameter]
        public string WhiteSpace { get; set; }

        [Parameter]
        public string TextDecoration { get; set; }
    }
}
