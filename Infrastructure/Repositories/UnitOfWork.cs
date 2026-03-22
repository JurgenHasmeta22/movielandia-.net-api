using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Infrastructure.Persistence;

namespace movielandia_.net_api.Infrastructure.Repositories;

/// <summary>
/// Wraps the EF Core SaveChanges so services can commit multiple repository operations atomically.
/// </summary>
public sealed class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context) => _context = context;

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => _context.SaveChangesAsync(cancellationToken);

    public void Dispose() => _context.Dispose();
}
