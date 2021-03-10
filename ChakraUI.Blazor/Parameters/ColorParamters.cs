using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter] public string TextColor { get; set; }
        [Parameter] public string Color { get; set; }
        [Parameter] public string Fill { get; set; }
        [Parameter] public string Stroke { get; set; }
        [Parameter] public string Opacity { get; set; }
    }
}
