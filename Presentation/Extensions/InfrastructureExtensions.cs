using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Application.Features.Movies.Interfaces;
using movielandia_.net_api.Infrastructure.Persistence;
using movielandia_.net_api.Infrastructure.Repositories;

namespace movielandia_.net_api.Presentation.Extensions;

/// <summary>
/// Registers infrastructure services (DbContext, repositories, unit-of-work) into the DI container.
/// </summary>
public static class InfrastructureExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Unit of Work
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        // Repositories
        services.AddScoped<IMovieRepository, MovieRepository>();

        return services;
    }
}
