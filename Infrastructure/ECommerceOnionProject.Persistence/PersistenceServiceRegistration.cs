using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ECommerceOnionProject.Application.Repositories.CustomerRepository;
using ECommerceOnionProject.Application.Repositories.OrderRepository;
using ECommerceOnionProject.Application.Repositories.ProductRepository;
using ECommerceOnionProject.Persistence.Configurations;
using ECommerceOnionProject.Persistence.Contexts;
using ECommerceOnionProject.Persistence.Repositories.CustomerRepository;
using ECommerceOnionProject.Persistence.Repositories.OrderRepository;
using ECommerceOnionProject.Persistence.Repositories.ProductRepository;

namespace ECommerceOnionProject.Persistence;

public static class PersistenceServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(ConnectionString.Configure()));

        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
    }
}
