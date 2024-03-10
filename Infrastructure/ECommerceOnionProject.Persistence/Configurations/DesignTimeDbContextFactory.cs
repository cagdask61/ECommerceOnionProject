using ECommerceOnionProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceOnionProject.Persistence.Configurations;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BaseDbContext>
{
    public BaseDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BaseDbContext> builder = new();
        builder.UseNpgsql(ConnectionString.Configure());
        return new(builder.Options);
    }
}