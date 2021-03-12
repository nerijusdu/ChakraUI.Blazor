using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [Transformer(typeof(ShadowTransformer))]
        public string BoxShadow { get; set; }

        [Parameter]
        [CssName("box-shadow")]
        [Transformer(typeof(ShadowTransformer))]
        public string Shadow { get; set; }

        [Parameter]
        [Transformer(typeof(ShadowTransformer))]
        public string TextShadow { get; set; }
    }
}
