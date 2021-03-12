using ChakraUI.Blazor.Attributes;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public class ListParameters
    {
        [Parameter]
        public string ListStyleType { get; set; }

        [Parameter]
        public string ListStylePosition { get; set; }

        [Parameter]
        [CssName("list-style-position")]
        public string ListStylePos { get; set; }

        [Parameter]
        public string ListStyleImage { get; set; }

        [Parameter]
        [CssName("list-style-image")]
        public string ListStyleImg { get; set; }
    }
}
