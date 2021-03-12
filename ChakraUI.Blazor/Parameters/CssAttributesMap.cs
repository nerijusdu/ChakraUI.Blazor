using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Extensions;

namespace ChakraUI.Blazor.Parameters
{
    public interface ICssAttributesMap
    {
        bool ContainsKey(string key);
        string Get(string key);
    }

    public class CssAttributesMap : ICssAttributesMap
    {
        private readonly Dictionary<string, string> map;

        public CssAttributesMap()
        {
            map = GetMap();
        }

        private static Dictionary<string, string> GetMap()
        {
            return typeof(StyledComponentBase)
                .GetProperties()
                .Select(x =>
                {
                    var attr = x.GetCustomAttribute<CssNameAttribute>();
                    var cssName = attr?.CssPropertyName ?? x.Name.ToKebabCase();
                    return new
                    {
                        CssName = cssName,
                        Name = x.Name
                    };
                })
                .ToDictionary(x => x.Name, x => x.CssName);
        }

        public bool ContainsKey(string key)
        {
            return map.ContainsKey(key);
        }

        public string Get(string key)
        {
            return map[key];
        }
    }
}
