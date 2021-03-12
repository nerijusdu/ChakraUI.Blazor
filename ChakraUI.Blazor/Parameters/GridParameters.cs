using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridGap { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridColumnGap { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridRowGap { get; set; }

        [Parameter]
        public string GridRowStart { get; set; }

        [Parameter]
        public string GridRowEnd { get; set; }

        [Parameter]
        public string GridTemplate { get; set; }

        [Parameter]
        public string GridColumn { get; set; }

        [Parameter]
        public string GridRow { get; set; }

        [Parameter]
        public string GridAutoFlow { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridAutoColumns { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridAutoRows { get; set; }

        [Parameter]
        public string GridTemplateColumns { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string GridTemplateRows { get; set; }

        [Parameter]
        public string GridTemplateAreas { get; set; }

        [Parameter]
        public string GridArea { get; set; }
    }
}
