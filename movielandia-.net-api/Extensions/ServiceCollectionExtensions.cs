using Microsoft.Extensions.DependencyInjection;
using movielandia_.net_api.Repositories.Implementations;
using movielandia_.net_api.Repositories.Interfaces;
using movielandia_.net_api.Infrastructures.Implementations;
using movielandia_.net_api.Infrastructures.Interfaces;

namespace movielandia_.net_api.Extensions
{
    public static class InfrastructureCollectionExtensions
    {
        public static IServiceCollection AddMovieInfrastructures(this IServiceCollection services)
        {
            // Register repositories
            services.AddScoped<IMovieRepository, MovieRepository>();
            
            // Register services
            services.AddScoped<IMovieInfrastructure, MovieInfrastructure>();
            
            // Add memory cache for caching movie data
            services.AddMemoryCache();
            
            return services;
        }
    }
}