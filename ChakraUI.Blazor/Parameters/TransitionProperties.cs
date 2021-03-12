using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string Transition { get; set; }

        [Parameter]
        public string TransitionProperty { get; set; }

        [Parameter]
        public string TransitionTimingFunction { get; set; }

        [Parameter]
        public string TransitionDuration { get; set; }

        [Parameter]
        public string Transform { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string TransformOrigin { get; set; }
    }
}
