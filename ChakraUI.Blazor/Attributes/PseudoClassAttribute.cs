using System;
using BlazorStyled;

namespace ChakraUI.Blazor.Attributes
{
    public class PseudoClassAttribute : Attribute
    {
        public PseudoClasses Class { get; set; }

        public PseudoClassAttribute(PseudoClasses _class)
        {
            this.Class = _class;
        }
    }
}
