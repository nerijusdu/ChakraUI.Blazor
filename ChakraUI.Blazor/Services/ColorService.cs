using System.Collections.Generic;
using ChakraUI.Blazor.Models;

namespace ChakraUI.Blazor.Services
{
    public interface IColorService
    {
        Dictionary<string, string> GetColorMap();

        ColorScheme GetColorScheme(string name);
    }

    public class ColorService : IColorService
    {

        private static readonly Dictionary<string, string> colorMap = new()
        {
            {"transparent", "transparent"},
            {"current", "currentColor"},
            {"black", "#000000"},
            {"white", "#FFFFFF"},
            {"whiteAlpha.50", "rgba(255, 255, 255, 0.04)"},
            {"whiteAlpha.100", "rgba(255, 255, 255, 0.06)"},
            {"whiteAlpha.200", "rgba(255, 255, 255, 0.08)"},
            {"whiteAlpha.300", "rgba(255, 255, 255, 0.16)"},
            {"whiteAlpha.400", "rgba(255, 255, 255, 0.24)"},
            {"whiteAlpha.500", "rgba(255, 255, 255, 0.36)"},
            {"whiteAlpha.600", "rgba(255, 255, 255, 0.48)"},
            {"whiteAlpha.700", "rgba(255, 255, 255, 0.64)"},
            {"whiteAlpha.800", "rgba(255, 255, 255, 0.80)"},
            {"whiteAlpha.900", "rgba(255, 255, 255, 0.92)"},
            {"blackAlpha.50", "rgba(0, 0, 0, 0.04)"},
            {"blackAlpha.100", "rgba(0, 0, 0, 0.06)"},
            {"blackAlpha.200", "rgba(0, 0, 0, 0.08)"},
            {"blackAlpha.300", "rgba(0, 0, 0, 0.16)"},
            {"blackAlpha.400", "rgba(0, 0, 0, 0.24)"},
            {"blackAlpha.500", "rgba(0, 0, 0, 0.36)"},
            {"blackAlpha.600", "rgba(0, 0, 0, 0.48)"},
            {"blackAlpha.700", "rgba(0, 0, 0, 0.64)"},
            {"blackAlpha.800", "rgba(0, 0, 0, 0.80)"},
            {"blackAlpha.900", "rgba(0, 0, 0, 0.92)"},
            {"gray.50", "#F7FAFC"},
            {"gray.100", "#EDF2F7"},
            {"gray.200", "#E2E8F0"},
            {"gray.300", "#CBD5E0"},
            {"gray.400", "#A0AEC0"},
            {"gray.500", "#718096"},
            {"gray.600", "#4A5568"},
            {"gray.700", "#2D3748"},
            {"gray.800", "#1A202C"},
            {"gray.900", "#171923"},
            {"red.50", "#FFF5F5"},
            {"red.100", "#FED7D7"},
            {"red.200", "#FEB2B2"},
            {"red.300", "#FC8181"},
            {"red.400", "#F56565"},
            {"red.500", "#E53E3E"},
            {"red.600", "#C53030"},
            {"red.700", "#9B2C2C"},
            {"red.800", "#822727"},
            {"red.900", "#63171B"},
            {"orange.50", "#FFFAF0"},
            {"orange.100", "#FEEBC8"},
            {"orange.200", "#FBD38D"},
            {"orange.300", "#F6AD55"},
            {"orange.400", "#ED8936"},
            {"orange.500", "#DD6B20"},
            {"orange.600", "#C05621"},
            {"orange.700", "#9C4221"},
            {"orange.800", "#7B341E"},
            {"orange.900", "#652B19"},
            {"yellow.50", "#FFFFF0"},
            {"yellow.100", "#FEFCBF"},
            {"yellow.200", "#FAF089"},
            {"yellow.300", "#F6E05E"},
            {"yellow.400", "#ECC94B"},
            {"yellow.500", "#D69E2E"},
            {"yellow.600", "#B7791F"},
            {"yellow.700", "#975A16"},
            {"yellow.800", "#744210"},
            {"yellow.900", "#5F370E"},
            {"green.50", "#F0FFF4"},
            {"green.100", "#C6F6D5"},
            {"green.200", "#9AE6B4"},
            {"green.300", "#68D391"},
            {"green.400", "#48BB78"},
            {"green.500", "#38A169"},
            {"green.600", "#2F855A"},
            {"green.700", "#276749"},
            {"green.800", "#22543D"},
            {"green.900", "#1C4532"},
            {"teal.50", "#E6FFFA"},
            {"teal.100", "#B2F5EA"},
            {"teal.200", "#81E6D9"},
            {"teal.300", "#4FD1C5"},
            {"teal.400", "#38B2AC"},
            {"teal.500", "#319795"},
            {"teal.600", "#2C7A7B"},
            {"teal.700", "#285E61"},
            {"teal.800", "#234E52"},
            {"teal.900", "#1D4044"},
            {"blue.50", "#ebf8ff"},
            {"blue.100", "#bee3f8"},
            {"blue.200", "#90cdf4"},
            {"blue.300", "#63b3ed"},
            {"blue.400", "#4299e1"},
            {"blue.500", "#3182ce"},
            {"blue.600", "#2b6cb0"},
            {"blue.700", "#2c5282"},
            {"blue.800", "#2a4365"},
            {"blue.900", "#1A365D"},
            {"cyan.50", "#EDFDFD"},
            {"cyan.100", "#C4F1F9"},
            {"cyan.200", "#9DECF9"},
            {"cyan.300", "#76E4F7"},
            {"cyan.400", "#0BC5EA"},
            {"cyan.500", "#00B5D8"},
            {"cyan.600", "#00A3C4"},
            {"cyan.700", "#0987A0"},
            {"cyan.800", "#086F83"},
            {"cyan.900", "#065666"},
            {"purple.50", "#FAF5FF"},
            {"purple.100", "#E9D8FD"},
            {"purple.200", "#D6BCFA"},
            {"purple.300", "#B794F4"},
            {"purple.400", "#9F7AEA"},
            {"purple.500", "#805AD5"},
            {"purple.600", "#6B46C1"},
            {"purple.700", "#553C9A"},
            {"purple.800", "#44337A"},
            {"purple.900", "#322659"},
            {"pink.50", "#FFF5F7"},
            {"pink.100", "#FED7E2"},
            {"pink.200", "#FBB6CE"},
            {"pink.300", "#F687B3"},
            {"pink.400", "#ED64A6"},
            {"pink.500", "#D53F8C"},
            {"pink.600", "#B83280"},
            {"pink.700", "#97266D"},
            {"pink.800", "#702459"},
            {"pink.900", "#521B41"}
        };

        public Dictionary<string, string> GetColorMap()
        {
            return colorMap;
        }

        public ColorScheme GetColorScheme(string name)
        {
            return new()
            {
                Primary = colorMap[$"{name}.500"],
                Hover = colorMap[$"{name}.600"],
                Active = colorMap[$"{name}.700"],
                Text = colorMap["white"]
            };
        }
    }
}
