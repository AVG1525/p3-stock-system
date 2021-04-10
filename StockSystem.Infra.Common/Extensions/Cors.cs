using Microsoft.Extensions.DependencyInjection;

namespace StockSystem.Infra.Common.Extensions
{
    public static class Cors
    {
        public static void AddCorsCustom(this IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });
        }
    }
}
