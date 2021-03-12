using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ChakraUI.Blazor.Attributes;
using ChakraUI.Blazor.Extensions;
using ChakraUI.Blazor.Parameters;

namespace ChakraUI.Blazor.Services
{
    public interface ICssAttributesMapper
    {
        bool ContainsKey(string key);

        string[] Get(string key);

        string Format(string key, string value);
    }

    public class CssAttributesMapper : ICssAttributesMapper
    {
        private readonly Dictionary<string, string[]> map;

        public CssAttributesMapper()
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
                    if (attr?.Ignore == true)
                    {
                        return null;
                    }

                    var cssNames = attr?.CssProperties ?? new[] {x.Name.ToKebabCase()};
                    return new
                    {
                        CssNames = cssNames,
                        Name = x.Name
                    };
                })
                .Where(x => x != null)
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
