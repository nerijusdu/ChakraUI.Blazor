using BlazorStyled;
using ChakraUI.Blazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ChakraUI.Blazor.Extensions
{
    public static class ServiceCollectionExtensions
    {
        // ReSharper disable once InconsistentNaming
        public static void AddChakraUI(this IServiceCollection services)
        {
            services.AddBlazorStyled();

            services.AddSingleton<IColorService, ColorService>();
            services.AddSingleton<ICssAttributesMapper, CssAttributesMapper>();
            services.AddSingleton<ITransformerManager, TransformerManager>();
        }
    }
}
