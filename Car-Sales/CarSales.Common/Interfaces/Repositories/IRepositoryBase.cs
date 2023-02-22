using System.Linq.Expressions;

namespace CarSales.Common.Interfaces.Repositories;

public interface IRepositoryBase <T>
{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges);
    Task<T> CreateAsync(T entity);
    void CreateManyAsync(T[] entities);
    Task<T> UpdateAsync(T entity);
    void DeleteAsync(T entity);
}