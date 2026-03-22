using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Infrastructure.Persistence;

namespace movielandia_.net_api.Infrastructure.Repositories;

/// <summary>
/// Thread-safe generic repository backed by EF Core.
/// Provides base CRUD for all entity types.
/// </summary>
public class GenericRepository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext Context;
    protected readonly DbSet<T> DbSet;

    public GenericRepository(AppDbContext context)
    {
        Context = context;
        DbSet = context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
        => await DbSet.AsNoTracking().ToListAsync();

    public virtual async Task<T?> GetByIdAsync(int id)
        => await DbSet.FindAsync(id);

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        => await DbSet.AsNoTracking().Where(predicate).ToListAsync();

    public virtual async Task<T> AddAsync(T entity)
    {
        await DbSet.AddAsync(entity);
        return entity;
    }

    public virtual Task UpdateAsync(T entity)
    {
        DbSet.Update(entity);
        return Task.CompletedTask;
    }

    public virtual async Task<bool> DeleteAsync(int id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity is null)
            return false;

        DbSet.Remove(entity);
        return true;
    }
}
