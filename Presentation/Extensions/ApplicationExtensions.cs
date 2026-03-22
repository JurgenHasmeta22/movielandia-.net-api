using FluentValidation;
using FluentValidation.AspNetCore;
using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Application.Features.Movies;
using movielandia_.net_api.Application.Features.Movies.Interfaces;
using movielandia_.net_api.Application.Features.Movies.Validators;
using movielandia_.net_api.Infrastructure.Repositories;

namespace movielandia_.net_api.Presentation.Extensions;

/// <summary>
/// Registers application services (features, validators, AutoMapper) into the DI container.
/// </summary>
public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Feature services
        services.AddScoped<IMovieService, MovieService>();

        // AutoMapper — scans the entire assembly for Profile classes
        services.AddAutoMapper(typeof(ApplicationExtensions).Assembly);

        // FluentValidation
        services.AddFluentValidationAutoValidation();
        services.AddValidatorsFromAssemblyContaining<CreateMovieRequestValidator>();

        return services;
    }
}
