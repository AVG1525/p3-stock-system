using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockSystem.Domain.Interfaces.Repository;
using StockSystem.Domain.Interfaces.Service;
using StockSystem.Infra.Data.Context;
using StockSystem.Infra.Data.UnitOfWork;
using StockSystem.Infra.Repository;
using StockSystem.Service;
using System;

namespace StockSystem.API.Extensions
{
    public static class DependencyInjection
    {
        public static void AddServiceDependencies(this IServiceCollection services, IConfigurationRoot configurationRoot) 
        {
            services.AddDbContext<ApplicationDbContextAPI>(context => context.UseNpgsql(
                string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PostgreConnection")) 
                ? configurationRoot.GetConnectionString("PostgreConnection") 
                : Environment.GetEnvironmentVariable("PostgreConnection")));
            
            services.AddScoped<IServiceBase, ServiceBase>();
            services.AddScoped<IUnitOfWork, UnitOfWorkAPI>();
            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            AddServices(services);
            AddRepositories(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEstablishmentService, EstablishmentService>();
            services.AddScoped<ICloseDayService, CloseDayService>();
            services.AddScoped<ISaleDayService, SaleDayService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();
            services.AddScoped<ISaleDayRepository, SaleDayRepository>();
        }
    }
}
