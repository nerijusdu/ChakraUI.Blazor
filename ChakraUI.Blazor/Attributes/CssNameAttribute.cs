using System;

namespace ChakraUI.Blazor.Attributes
{
    /// <summary>
    /// Custom attribute used to map property to a css property.
    /// If this attribute is not set, the lower kebab-case property name would be used
    /// </summary>
    public class CssNameAttribute : Attribute
    {
        public string[] CssProperties { get; }

        public CssNameAttribute(params string[] cssProperties)
        {
            CssProperties = cssProperties;
        }
    }
}
