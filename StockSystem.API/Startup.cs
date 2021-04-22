using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockSystem.API.Extensions;
using StockSystem.Infra.Common.AutoMapper;
using StockSystem.Infra.Common.Extensions;
using System.Globalization;

namespace StockSystem.API
{
    public class Startup
    {
        public Startup(IWebHostEnvironment webHostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(webHostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            ConfigurationRoot = builder.Build();
        }

        public IConfigurationRoot ConfigurationRoot { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServiceDependencies(ConfigurationRoot);
            services.AddSwaggerCustom();
            services.AddCorsCustom();
            services.AddAuthenticationCustom();
            services.AddAutoMapper(typeof(AutoMapperConfigAPI));
            services.AddLocalizationCustom();

            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.Culture = new CultureInfo("pt-BR");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            
            app.UseRouting();
            
            app.UseCors("CorsPolicy");
            
            app.UseAuthentication();
            
            app.UseAuthorization();
            
            app.UseRequestLocalization();

            app.UseSwagger();
            app.UseSwaggerUI(conf => {
                conf.RoutePrefix = string.Empty;
                conf.SwaggerEndpoint("/swagger/API/swagger.json", "API");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
