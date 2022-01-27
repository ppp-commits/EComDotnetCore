using Ecom.DataAccess.Persistence;
using Ecom.DataAccess.Repository;
using Ecom.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecom.DataAccess
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<DatabaseContext>(options =>
             options.UseSqlServer(
                 configuration.GetConnectionString("DefaultConnection"),
                 b => b.MigrationsAssembly(typeof(DatabaseContext).Assembly.FullName)));
            services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IGenericRepository, GenericRepository>();
            return services;
        }
    }
}
