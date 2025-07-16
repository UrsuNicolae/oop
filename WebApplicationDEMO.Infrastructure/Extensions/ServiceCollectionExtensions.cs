using Microsoft.Extensions.DependencyInjection;
using WebApplicationDEMO.Application.Interfaces;
using WebApplicationDEMO.Infrastructure.Persistance;

namespace WebApplicationDEMO.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
