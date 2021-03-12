using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace ChakraUI.Blazor.Parameters
{
    public partial class StyledComponentBase : ComponentBase
    {
        private static readonly List<PropertyInfo> Properties = typeof(StyledComponentBase)
            .GetProperties()
            .ToList();

        protected Dictionary<string, object> GetPropertiesDict()
        {
            return Properties
                .Select(property => new
                {
                    Value = property.GetValue(this),
                    Name = property.Name
                })
                .Where(x => x.Value != null)
                .ToDictionary(x => x.Name, x => x.Value);
        }
    }
}
