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

        string[] Get(string key);

        string Format(string key, string value);
    }

    public class CssAttributesMap : ICssAttributesMap
    {
        private readonly Dictionary<string, string[]> map;

        public CssAttributesMap()
        {
            map = GetMap();
        }

        private static Dictionary<string, string[]> GetMap()
        {
            return typeof(StyledComponentBase)
                .GetProperties()
                .Select(x =>
                {
                    var attr = x.GetCustomAttribute<CssNameAttribute>();
                    var cssNames = attr?.CssProperties ?? new[] {x.Name.ToKebabCase()};
                    return new
                    {
                        CssNames = cssNames,
                        Name = x.Name
                    };
                })
                .ToDictionary(x => x.Name, x => x.CssNames);
        }

        public bool ContainsKey(string key)
        {
            return map.ContainsKey(key);
        }

        public string[] Get(string key)
        {
            return map[key];
        }

        public string Format(string key, string value)
        {
            return string.Join("", Get(key).Select(cssProperty => $"{cssProperty}: {value};"));
        }
    }
}
