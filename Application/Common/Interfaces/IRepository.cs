using System.Linq.Expressions;

namespace movielandia_.net_api.Application.Common.Interfaces;

/// <summary>
/// Generic repository contract providing standard CRUD and query operations.
/// </summary>
public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}
