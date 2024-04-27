using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ECommerceOnionProject.Application.Repositories.Common;
using ECommerceOnionProject.Domain.Entities.Common;
using ECommerceOnionProject.Persistence.Contexts;

namespace ECommerceOnionProject.Persistence.Repositories.Common;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly BaseDbContext _context;

    public ReadRepository(BaseDbContext context)
    {
        _context = context;
    }
    public DbSet<T> Table => _context.Set<T>();


    public IQueryable<T> GetAll(bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query;
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if(!tracking)
            query = query.AsNoTracking();
        return query.Where(predicate);
    }

    public Task<T?> GetFirstAsync(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query.FirstOrDefaultAsync(predicate);
    }

    public Task<T?> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        var query = Table.AsQueryable();
        if (!tracking)
            query = query.AsNoTracking();
        return query.SingleOrDefaultAsync(predicate);
    }
}
