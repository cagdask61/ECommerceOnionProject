
using ECommerceOnionProject.Application.Repositories.OrderRepository;
using ECommerceOnionProject.Domain.Entities;
using ECommerceOnionProject.Persistence.Contexts;
using ECommerceOnionProject.Persistence.Repositories.Common;

namespace ECommerceOnionProject.Persistence.Repositories.OrderRepository;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(BaseDbContext context) : base(context)
    {
    }
}
