using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string ColorScheme { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        [CssName("color")]
        public string TextColor { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string Color { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string Fill { get; set; }

        [Parameter]
        [Transformer(typeof(ColorTransformer))]
        public string Stroke { get; set; }

        [Parameter]
        public string Opacity { get; set; }
    }
}
