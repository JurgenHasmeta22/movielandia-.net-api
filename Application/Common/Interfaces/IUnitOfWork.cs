namespace movielandia_.net_api.Application.Common.Interfaces;

/// <summary>
/// Coordinates the work of multiple repositories by sharing a single DbContext transaction.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
