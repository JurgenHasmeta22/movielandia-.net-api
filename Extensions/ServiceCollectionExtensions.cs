using Microsoft.Extensions.DependencyInjection;
using movielandia_.net_api.Infrastructures.Implementations;
using movielandia_.net_api.Infrastructures.Interfaces;
using movielandia_.net_api.Repositories.Implementations;
using movielandia_.net_api.Repositories.Interfaces;
using movielandia_.net_api.Mappings;
using System.Reflection;

namespace movielandia_.net_api.Extensions
{
    public static class InfrastructureCollectionExtensions
    {
        public static IServiceCollection AddMovieInfrastructures(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IMovieInfrastructure, MovieInfrastructure>();
            services.AddMemoryCache();
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            return services;
        }
    }
}
