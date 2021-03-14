// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BlazorStyled;
using ChakraUI.Blazor.Attributes;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase
    {
        [Parameter]
        [CssName(Ignore = true)]
        [PseudoClass(PseudoClasses.Hover)]
        public PseudoClassParametersBase _hover { get; set; }

        [Parameter]
        [CssName(Ignore = true)]
        [PseudoClass(PseudoClasses.Disabled)]
        public PseudoClassParametersBase _disabled { get; set; }

        [Parameter]
        [CssName(Ignore = true)]
        [PseudoClass(PseudoClasses.Focus)]
        public PseudoClassParametersBase _focus { get; set; }

        [Parameter]
        [CssName(Ignore = true)]
        [PseudoClass(PseudoClasses.Active)]
        public PseudoClassParametersBase _active { get; set; }

        protected Dictionary<PseudoClasses, Dictionary<string, object>> GetPseudoClassesWithProperties()
        {
            return Properties
                .Where(x => x.GetCustomAttribute<PseudoClassAttribute>() != null)
                .ToDictionary(x => x.GetCustomAttribute<PseudoClassAttribute>()!.Class, x =>
                {
                    var pseudoClassParams = (PseudoClassParametersBase) x.GetValue(this);
                    return pseudoClassParams?.GetPropertiesDict();
                });
        }
    }
}
