using ChakraUI.Blazor.Attributes;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string Border { get; set; }

        [Parameter]
        public string BorderWidth { get; set; }

        [Parameter]
        public string BorderStyle { get; set; }

        [Parameter]
        public string BorderColor { get; set; }

        [Parameter]
        public string BorderRadius { get; set; }

        [Parameter]
        [CssName("border-radius")]
        public string Rounded { get; set; }

        [Parameter]
        public string BorderTop { get; set; }

        [Parameter]
        public string BorderTopWidth { get; set; }

        [Parameter]
        public string BorderBottomWidth { get; set; }

        [Parameter]
        public string BorderLeftWidth { get; set; }

        [Parameter]
        public string BorderRightWidth { get; set; }

        [Parameter]
        public string BorderTopStyle { get; set; }

        [Parameter]
        public string BorderBottomStyle { get; set; }

        [Parameter]
        public string BorderLeftStyle { get; set; }

        [Parameter]
        public string BorderRightStyle { get; set; }

        [Parameter]
        public string BorderTopColor { get; set; }

        [Parameter]
        public string BorderBottomColor { get; set; }

        [Parameter]
        public string BorderLeftColor { get; set; }

        [Parameter]
        public string BorderRightColor { get; set; }

        [Parameter]
        public string BorderRight { get; set; }

        [Parameter]
        public string BorderBottom { get; set; }

        [Parameter]
        public string BorderLeft { get; set; }

        [Parameter]
        public string BorderTopRadius { get; set; }

        [Parameter]
        [CssName("broder-top-radius")]
        public string RoundedTop { get; set; }

        [Parameter]
        public string BorderRightRadius { get; set; }

        [Parameter]
        [CssName("broder-right-radius")]
        public string RoundedRight { get; set; }

        [Parameter]
        public string BorderBottomRadius { get; set; }

        [Parameter]
        [CssName("broder-bottom-radius")]
        public string RoundedBottom { get; set; }

        [Parameter]
        public string BorderLeftRadius { get; set; }

        [Parameter]
        [CssName("broder-left-radius")]
        public string RoundedLeft { get; set; }

        [Parameter]
        public string BorderTopLeftRadius { get; set; }

        [Parameter]
        public string BorderTopRightRadius { get; set; }

        [Parameter]
        [CssName("broder-top-right-radius")]
        public string RoundedTopRight { get; set; }

        [Parameter]
        public string BorderBottomLeftRadius { get; set; }

        [Parameter]
        [CssName("broder-bottom-left-radius")]
        public string RoundedBottomLeft { get; set; }

        [Parameter]
        public string BorderBottomRightRadius { get; set; }

        [Parameter]
        [CssName("broder-bottom-right-radius")]
        public string RoundedBottomRight { get; set; }

        [Parameter] // TODO: how do I map multiple css properties?
        public string BorderX { get; set; }

        [Parameter]
        public string BorderInline { get; set; }

        [Parameter]
        public string BorderY { get; set; }

        [Parameter]
        public string BorderBlock { get; set; }
    }
}
