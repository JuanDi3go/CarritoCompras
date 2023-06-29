using Application.Interfaces.IRepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence.ServiceExtensions
{
    public static class InfraesturctureIOC
    {
        public static IServiceCollection AddInfraestructureServiceExtensions(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddPersistenceServiceExtensions(configuration);


            return services;
        }

        private static IServiceCollection AddPersistenceServiceExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbCarritoComprasContext>(op => op.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IRepostioryAsync<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
