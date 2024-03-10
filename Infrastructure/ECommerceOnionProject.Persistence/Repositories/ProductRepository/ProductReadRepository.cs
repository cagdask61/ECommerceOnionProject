using ECommerceOnionProject.Application.Repositories.ProductRepository;
using ECommerceOnionProject.Domain.Entities;
using ECommerceOnionProject.Persistence.Contexts;
using ECommerceOnionProject.Persistence.Repositories.Common;

namespace ECommerceOnionProject.Persistence.Repositories.ProductRepository;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(BaseDbContext context) : base(context)
    {
    }
}
