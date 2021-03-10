using System.Collections.Generic;

namespace ChakraUI.Blazor.Parameters
{
    public interface ICssAttributesMap
    {
        bool ContainsKey(string key);
        string Get(string key);
    }

    public class CssAttributesMap : ICssAttributesMap
    {
        public bool ContainsKey(string key)
        {
            return map.ContainsKey(key.ToLower());
        }

        public string Get(string key)
        {
            return map[key.ToLower()];
        }

        private readonly Dictionary<string, string> map = new()
        {
            {"bg", "background"},
            {"color", "color"},
            {"textcolor", "textColor"},
            {"fill", "fill"},
            {"stroke", "stroke"},
            {"opacity", "opacity"},
        };
    }
}
