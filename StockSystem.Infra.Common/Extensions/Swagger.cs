using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace StockSystem.Infra.Common.Extensions
{
    public static class Swagger
    {
        public static void AddSwaggerCustom(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.IncludeXmlComments(@"E:\Projects\dotnet\StockSystem\StockSystem.API\StockSystem.API.xml", includeControllerXmlComments: true);

                opt.SwaggerDoc("API", new OpenApiInfo { Title = "StockSystem - API", Version = "API" });

                opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Autorização via JWT. \r\n\r\n Digite 'Bearer' [espaço] e o JWT gerando na rota Autenticador.\r\n\r\nExemplo: \"Bearer 12345abcdef\"",
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                        new string[] { }
                    }
                });
            });
        }
    }
}
