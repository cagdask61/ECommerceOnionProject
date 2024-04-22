using ECommerceOnionProject.Application.Repositories.CustomerRepository;
using ECommerceOnionProject.Domain.Entities;
using ECommerceOnionProject.Persistence.Contexts;
using ECommerceOnionProject.Persistence.Repositories.Common;

namespace ECommerceOnionProject.Persistence.Repositories.CustomerRepository;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(BaseDbContext context) : base(context)
    {
    }
}