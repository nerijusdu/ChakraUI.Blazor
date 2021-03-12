using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorStyled;
using ChakraUI.Blazor.Parameters;
using ChakraUI.Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Base
{
    public class StyledComponent : StyledComponentBase
    {
        [Inject] protected IStyled Styled { get; set; }
        [Inject] protected ICssAttributesMapper CssAttributesMapper { get; set; }
        [Inject] protected ITransformerManager TransformerManager { get; set; }
        [Inject] protected IColorService ColorService { get; set; }

        protected string className = "buttonnnn";
        private string styles;

        protected void RefreshStyles()
        {
            SetColorScheme(ColorScheme?.ToLower() ?? "gray");
            var parametersDict = GetPropertiesDict();
            var propertiesList = parametersDict.Keys
                .Where(attributeKey => CssAttributesMapper.ContainsKey(attributeKey))
                .Select(attributeKey =>
                {
                    var value = TransformerManager.Transform(attributeKey, parametersDict[attributeKey]);
                    return CssAttributesMapper.Format(attributeKey, value);
                });

            styles = string.Join("", propertiesList);
        }

        protected override void OnInitialized()
        {
            RefreshStyles();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Console.WriteLine($"after render: {styles}");
            className = await Styled.CssAsync(styles);
            if (firstRender)
            {
               StateHasChanged();
            }
        }

        protected virtual void SetColorScheme(string schemeName)
        {
            var scheme = ColorService.GetColorScheme(schemeName);
            Background = scheme.Primary;
            Color = scheme.Text;
        }
    }
}
