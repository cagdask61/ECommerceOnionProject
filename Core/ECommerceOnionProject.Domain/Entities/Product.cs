using ECommerceOnionProject.Domain.Entities.Common;

namespace ECommerceOnionProject.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Order> Orders { get; set; }
}
