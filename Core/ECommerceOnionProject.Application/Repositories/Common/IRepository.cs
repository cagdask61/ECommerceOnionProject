using ECommerceOnionProject.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceOnionProject.Application.Repositories.Common;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public DbSet<TEntity> Table { get; }
}
