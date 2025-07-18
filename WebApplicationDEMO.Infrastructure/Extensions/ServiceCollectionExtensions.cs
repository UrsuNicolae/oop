using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationDEMO.Application.Interfaces;
using WebApplicationDEMO.Infrastructure.Data;
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

        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>options.UseSqlite(configuration.GetConnectionString("sql_conn")));
            return services;
        }
    }
}
