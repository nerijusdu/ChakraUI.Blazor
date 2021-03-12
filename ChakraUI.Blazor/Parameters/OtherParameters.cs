using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string Animation { get; set; }

        [Parameter]
        public string Appearance { get; set; }

        [Parameter]
        public string Visibility { get; set; }

        [Parameter]
        public string UserSelect { get; set; }

        [Parameter]
        public string PointerEvents { get; set; }

        [Parameter]
        public string Cursor { get; set; }

        [Parameter]
        public string Resize { get; set; }

        [Parameter]
        public string ObjectFit { get; set; }

        [Parameter]
        public string ObjectPosition { get; set; }

        [Parameter]
        public string Outline { get; set; }

        [Parameter]
        public string OutlineOffset { get; set; }

        [Parameter]
        public string OutlineColor { get; set; }
    }
}
