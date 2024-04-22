
using ECommerceOnionProject.Domain.Entities;
using ECommerceOnionProject.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceOnionProject.Persistence.Contexts;

public class BaseDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<BaseEntity>();
        foreach (var entry in entries)
        {
            var _ = entry.State switch
            {
                EntityState.Modified => entry.Entity.UpdatedDate = DateTime.UtcNow,
                EntityState.Added => entry.Entity.CreatedDate = DateTime.UtcNow,
                _ => DateTime.UtcNow,
            };
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}