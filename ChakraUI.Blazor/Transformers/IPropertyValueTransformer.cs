namespace ChakraUI.Blazor.Transformers
{
    public interface IPropertyValueTransformer
    {
        string Transform(object value);
    }
}
