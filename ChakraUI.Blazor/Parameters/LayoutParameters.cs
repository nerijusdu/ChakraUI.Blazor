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
        public string Width { get; set; }

        [Parameter]
        [CssName("width")]
        [Transformer(typeof(SizesTransformer))]
        public string W { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string InlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string BoxSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MaxWidth { get; set; }

        [Parameter]
        [CssName("max-width")]
        [Transformer(typeof(SizesTransformer))]
        public string MaxW { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MaxInlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MinWidth { get; set; }

        [Parameter]
        [CssName("min-width")]
        [Transformer(typeof(SizesTransformer))]
        public string MinW { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MinInlineSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string Height { get; set; }

        [Parameter]
        [CssName("height")]
        [Transformer(typeof(SizesTransformer))]
        public string H { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string BlockSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MaxHeight { get; set; }

        [Parameter]
        [CssName("max-height")]
        [Transformer(typeof(SizesTransformer))]
        public string MaxH { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MaxBlockSize { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MinHeight { get; set; }

        [Parameter]
        [CssName("min-height")]
        [Transformer(typeof(SizesTransformer))]
        public string MinH { get; set; }

        [Parameter]
        [Transformer(typeof(SizesTransformer))]
        public string MinBlockSize { get; set; }

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
