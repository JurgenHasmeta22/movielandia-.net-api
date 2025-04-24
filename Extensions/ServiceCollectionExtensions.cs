using FluentValidation;
using FluentValidation.AspNetCore;
using movielandia_.net_api.BLLs.Implementations;
using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.DAL.Implementations;
using movielandia_.net_api.DAL.Interfaces;
using movielandia_.net_api.DTOs.Validators;
using movielandia_.net_api.Managers.Implementations;
using movielandia_.net_api.Managers.Interfaces;

namespace movielandia_.net_api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieDAL, MovieDAL>();
            services.AddScoped<IMovieBLL, MovieBLL>();
            services.AddScoped<IMovieManager, MovieManager>();
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<CreateMovieRequestDTOValidator>();

            return services;
        }
    }
}
