using movielandia_.net_api.BLLs.Implementations;
using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.DAL.Implementations;
using movielandia_.net_api.DAL.Interfaces;
using movielandia_.net_api.Mappings;

namespace movielandia_.net_api.Extensions
{
    public static class ServiceCollectionExtensions
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
