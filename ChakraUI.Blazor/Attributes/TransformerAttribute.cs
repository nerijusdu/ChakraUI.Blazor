using System;

namespace ChakraUI.Blazor.Attributes
{
    public class TransformerAttribute : Attribute
    {
        public Type TransformerType { get; }

        public TransformerAttribute(Type transformerType)
        {
            TransformerType = transformerType;
        }
    }
}
