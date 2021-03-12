using ChakraUI.Blazor.Attributes;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string AlignItems { get; set; }

        [Parameter]
        public string AlignContent { get; set; }

        [Parameter]
        public string JustifyItems { get; set; }

        [Parameter]
        public string JustifyContent { get; set; }

        [Parameter]
        public string FlexWrap { get; set; }

        [Parameter]
        public string FlexFlow { get; set; }

        [Parameter]
        public string FlexBasis { get; set; }

        [Parameter]
        public string FlexDirection { get; set; }

        [Parameter]
        [CssName("flex-direction")]
        public string FlexDir { get; set; }

        [Parameter]
        public string Flex { get; set; }

        [Parameter]
        public string JustifySelf { get; set; }

        [Parameter]
        public string AlignSelf { get; set; }

        [Parameter]
        public string Order { get; set; }

        [Parameter]
        public string FlexGrow { get; set; }

        [Parameter]
        public string FlexShrink { get; set; }

        [Parameter]
        public string PlaceItems { get; set; }

        [Parameter]
        public string PlaceContent { get; set; }

        [Parameter]
        public string PlaceSelf { get; set; }
    }
}
