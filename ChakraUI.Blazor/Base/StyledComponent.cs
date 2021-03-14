using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorStyled;
using ChakraUI.Blazor.Models;
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

        protected string className;

        protected async Task RefreshStyles()
        {
            Console.WriteLine("building");
            SetColorScheme(ColorScheme?.ToLower() ?? "gray");

            var parametersDict = GetPropertiesDict();
            className = await Styled.CssAsync(GetCss(parametersDict));

            var pseudoClassDict = GetPseudoClassesWithProperties();
            foreach (var key in pseudoClassDict.Keys.Where(key => pseudoClassDict[key] != null))
            {
                await Styled.CssAsync(
                    ApplyPseudoClass(key, className),
                    GetCss(pseudoClassDict[key]));
            }

        }

        protected override async Task OnInitializedAsync()
        {
            await RefreshStyles();
        }

        protected virtual void SetColorScheme(string schemeName)
        {
            var scheme = ColorService.GetColorScheme(schemeName);
            SetColorScheme(scheme);
        }

        protected virtual void SetColorScheme(ColorScheme scheme)
        {
            Background = scheme.Primary;
            Color = scheme.Text;

            _hover ??= new();
            _hover.Background = scheme.Hover;

            _disabled ??= new();
            _disabled.Opacity = "0.4";
            _disabled.Cursor = "not-allowed";
            _disabled.BoxShadow = "none";

            _active ??= new();
            _active.Background = scheme.Active;

            _focus ??= new();
            _focus.BoxShadow = "outline";

        }

        private string GetCss(Dictionary<string, object> parametersDict)
        {
            var propertiesList = parametersDict.Keys
                .Where(attributeKey => CssAttributesMapper.ContainsKey(attributeKey))
                .Select(attributeKey =>
                {
                    var value = TransformerManager.Transform(attributeKey, parametersDict[attributeKey]);
                    return CssAttributesMapper.Format(attributeKey, value);
                });
            return string.Join("", propertiesList);
        }

        private string ApplyPseudoClass(PseudoClasses pseudoClass, string classname)
        {
            string cls = classname?.IndexOf("-") != -1 ? "." + classname : classname;
            return pseudoClass switch
            {
                PseudoClasses.Active => $"{cls}:active",
                PseudoClasses.After => $"{cls}::after",
                PseudoClasses.Before => $"{cls}::before",
                PseudoClasses.Checked => $"{cls}:checked",
                PseudoClasses.Disabled => $"{cls}:disabled",
                PseudoClasses.Empty => $"{cls}:empty",
                PseudoClasses.Enabled => $"{cls}:enabled",
                PseudoClasses.FirstChild => $"{cls}:first-child",
                PseudoClasses.FirstLetter => $"{cls}::first-letter",
                PseudoClasses.FirstLine => $"{cls}::first-line",
                PseudoClasses.FirstOfType => $"{cls}:first-of-type",
                PseudoClasses.Focus => $"{cls}:focus",
                PseudoClasses.Hover => $"{cls}:hover",
                PseudoClasses.InRange => $"{cls}:in-range",
                PseudoClasses.Invalid => $"{cls}:invalid",
                PseudoClasses.LastChild => $"{cls}:last-child",
                PseudoClasses.LastOfType => $"{cls}:last-of-type",
                PseudoClasses.Link => $"{cls}:link",
                PseudoClasses.Not => $":not{cls}",
                PseudoClasses.OnlyChild => $"{cls}:only-child",
                PseudoClasses.OnlyOfType => $"{cls}:only-of-type",
                PseudoClasses.Optional => $"{cls}:optional",
                PseudoClasses.OutOfRange => $"{cls}:out-of-range",
                PseudoClasses.ReadOnly => $"{cls}:read-only",
                PseudoClasses.ReadWrite => $"{cls}:read-write",
                PseudoClasses.Required => $"{cls}:required",
                PseudoClasses.Selection => $"{cls}::selection",
                PseudoClasses.Target => $"{cls}:target",
                PseudoClasses.Valid => $"{cls}:valid",
                PseudoClasses.Visited => $"{cls}:visited",
                _ => classname
            };
        }
    }
}
