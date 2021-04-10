using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Globalization;

namespace StockSystem.Infra.Common.Extensions
{
    public static class Localization
    {
        public static void AddLocalizationCustom(this IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("pt-BR");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("pt-BR") };

                options.RequestCultureProviders = new List<IRequestCultureProvider>();
            });
        }
    }
}
