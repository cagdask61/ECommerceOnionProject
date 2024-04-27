using ECommerceOnionProject.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceOnionProject.Application.Repositories.Common;

public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll(bool tracking = true);
    IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, bool tracking = true);

    Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true);
    Task<TEntity?> GetFirstAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true);
}