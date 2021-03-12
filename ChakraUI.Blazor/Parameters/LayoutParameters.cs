using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        public string Display { get; set; }

        [Parameter]
        [CssName("display")]
        public string D { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object Width { get; set; }

        [Parameter]
        [CssName("width")]
        [Transformer(typeof(SizesTransformer))]
        public object W { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object InlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object BoxSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MaxWidth { get; set; }

        [Parameter]
        [CssName("max-width")]
        [Transformer(typeof(SizesTransformer))]
        public object MaxW { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MaxInlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MinWidth { get; set; }

        [Parameter]
        [CssName("min-width")]
        [Transformer(typeof(SizesTransformer))]
        public object MinW { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MinInlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object Height { get; set; }

        [Parameter]
        [CssName("height")]
        [Transformer(typeof(SizesTransformer))]
        public object H { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object BlockSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MaxHeight { get; set; }

        [Parameter]
        [CssName("max-height")]
        [Transformer(typeof(SizesTransformer))]
        public object MaxH { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MaxBlockSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MinHeight { get; set; }

        [Parameter]
        [CssName("min-height")]
        [Transformer(typeof(SizesTransformer))]
        public object MinH { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public object MinBlockSize { get; set; }

        [Parameter]
        public string VerticalAlign { get; set; }

        [Parameter]
        public string Overflow { get; set; }

        [Parameter]
        public string OverflowX { get; set; }

        [Parameter]
        public string OverflowY { get; set; }

        [Parameter]
        public string BoxSizing { get; set; }

    }
}
