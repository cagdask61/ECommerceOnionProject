using ECommerceOnionProject.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceOnionProject.Application.Repositories.Common;

public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);

    Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> GetFirstAsync(Expression<Func<TEntity, bool>> predicate);
}