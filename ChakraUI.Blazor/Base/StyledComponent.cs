using System.Linq;
using System.Threading.Tasks;
using BlazorStyled;
using ChakraUI.Blazor.Parameters;
using ChakraUI.Blazor.Transformers;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Base
{
    public class StyledComponent : StyledComponentBase
    {
        [Inject] public IStyled Styled { get; set; }
        [Inject] public ICssAttributesMap CssAttributesMap { get; set; }
        [Inject] public ITransformerManager TransformerManager { get; set; }

        protected string className;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            var parametersDict = parameters.ToDictionary();
            var propertiesList = parametersDict.Keys
                .Where(attributeKey => CssAttributesMap.ContainsKey(attributeKey))
                .Select(attributeKey =>
                {
                    var cssProperty = CssAttributesMap.Get(attributeKey);
                    var value = TransformerManager.Transform(cssProperty, parametersDict[attributeKey]);
                    return $"{cssProperty}: {value};";
                });

            className = Styled.Css(string.Join("", propertiesList));

            return base.SetParametersAsync(parameters);
        }
    }
}
