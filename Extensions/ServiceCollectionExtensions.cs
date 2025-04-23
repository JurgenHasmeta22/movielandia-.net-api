using movielandia_.net_api.BLLs.Implementations;
using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.Mappings;
using movielandia_.net_api.Repositories.Implementations;
using movielandia_.net_api.Repositories.Interfaces;

namespace movielandia_.net_api.Extensions
{
    public static class BLLCollectionExtensions
    {
        public static IServiceCollection AddMovieBLLs(this IServiceCollection services)
        {
            services.AddScoped<IMovieDAL, MovieDAL>();
            services.AddScoped<IMovieBLL, MovieBLL>();
            services.AddMemoryCache();
            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            return services;
        }
    }
}
