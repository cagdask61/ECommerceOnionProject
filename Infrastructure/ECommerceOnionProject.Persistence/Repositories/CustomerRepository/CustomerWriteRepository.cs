

using ECommerceOnionProject.Application.Repositories.CustomerRepository;
using ECommerceOnionProject.Domain.Entities;
using ECommerceOnionProject.Persistence.Contexts;
using ECommerceOnionProject.Persistence.Repositories.Common;

namespace ECommerceOnionProject.Persistence.Repositories.CustomerRepository;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(BaseDbContext context) : base(context)
    {
    }
}
