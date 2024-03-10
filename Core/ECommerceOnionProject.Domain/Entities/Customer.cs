using ECommerceOnionProject.Domain.Entities.Common;

namespace ECommerceOnionProject.Domain.Entities;

public class Customer : BaseEntity
{
    public ICollection<Order> Orders { get; set; }
}
