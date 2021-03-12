using System;

namespace ChakraUI.Blazor.Attributes
{
    /// <summary>
    /// Custom attribute that defines which transformers should be used on a property.
    /// If many are used, ordering is important.
    /// </summary>
    public class TransformerAttribute : Attribute
    {
        public Type[] TransformerTypes { get; }

        public TransformerAttribute(params Type[] transformerTypes)
        {
            TransformerTypes = transformerTypes;
        }
    }
}
