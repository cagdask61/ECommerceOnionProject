using ECommerceOnionProject.Persistence.Configurations;
using ECommerceOnionProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceOnionProject.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(ConnectionString.Configure()));
        }
    }
}
