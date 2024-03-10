using ECommerceOnionProject.Application.Repositories.Common;
using ECommerceOnionProject.Domain.Entities.Common;
using ECommerceOnionProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceOnionProject.Persistence.Repositories.Common;

public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
{
    private readonly BaseDbContext _context;
    public WriteRepository(BaseDbContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        Table.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        Table.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
