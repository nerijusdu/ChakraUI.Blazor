using System.Collections.Generic;

namespace ChakraUI.Blazor.Transformers.Typography
{
    public class FontTransformer : TransformerBase, IPropertyValueTransformer
    {
        public object Transform(object value) => TransformWholeValue(value);

        protected override Dictionary<string, string> GetMap() => map;

        private readonly Dictionary<string, string> map = new()
        {
            {"heading", @"-apple-system, BlinkMacSystemFont, ""Segoe UI"", Helvetica, Arial, sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"""},
            {"body", @"-apple-system, BlinkMacSystemFont, ""Segoe UI"", Helvetica, Arial, sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"""},
            {"mono", @"SFMono-Regular,Menlo,Monaco,Consolas,""Liberation Mono"",""Courier New"",monospace"""},
        };
    }
}
