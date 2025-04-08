using Microsoft.Extensions.DependencyInjection;
using movielandia_.net_api.Repositories.Implementations;
using movielandia_.net_api.Repositories.Interfaces;
using movielandia_.net_api.Services.Implementations;
using movielandia_.net_api.Services.Interfaces;

namespace movielandia_.net_api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieServices(this IServiceCollection services)
        {
            // Register repositories
            services.AddScoped<IMovieRepository, MovieRepository>();
            
            // Register services
            services.AddScoped<IMovieService, MovieService>();
            
            // Add memory cache for caching movie data
            services.AddMemoryCache();
            
            return services;
        }
    }
}