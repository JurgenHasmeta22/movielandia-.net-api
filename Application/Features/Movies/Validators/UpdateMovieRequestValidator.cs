using FluentValidation;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;

namespace movielandia_.net_api.Application.Features.Movies.Validators;

public sealed class UpdateMovieRequestValidator : AbstractValidator<UpdateMovieRequest>
{
    public UpdateMovieRequestValidator()
    {
        RuleFor(x => x.Title).MaximumLength(200).When(x => x.Title != null);
        RuleFor(x => x.PhotoSrc).Must(IsValidUrl!).When(x => x.PhotoSrc != null).WithMessage("Photo URL must be valid.");
        RuleFor(x => x.PhotoSrcProd).Must(IsValidUrl!).When(x => x.PhotoSrcProd != null).WithMessage("Production photo URL must be valid.");
        RuleFor(x => x.TrailerSrc).Must(IsValidUrl!).When(x => x.TrailerSrc != null).WithMessage("Trailer URL must be valid.");
        RuleFor(x => x.Duration).GreaterThan(0).When(x => x.Duration.HasValue);
        RuleFor(x => x.RatingImdb).InclusiveBetween(0, 10).When(x => x.RatingImdb.HasValue);
        RuleFor(x => x.Description).MaximumLength(2000).When(x => x.Description != null);
        RuleForEach(x => x.Cast).SetValidator(new CastMemberRequestValidator()).When(x => x.Cast != null);
        RuleForEach(x => x.Crew).SetValidator(new CrewMemberRequestValidator()).When(x => x.Crew != null);
    }

    private static bool IsValidUrl(string url)
        => Uri.TryCreate(url, UriKind.Absolute, out _);
}

public sealed class MovieSearchParamsValidator : AbstractValidator<MovieSearchParams>
{
    private static readonly string[] AllowedSortFields = ["title", "dateAired", "ratingImdb", "duration"];
    private static readonly string[] AllowedDirections = ["asc", "desc"];

    public MovieSearchParamsValidator()
    {
        RuleFor(x => x.SearchTerm).NotEmpty().MinimumLength(2).WithMessage("Search term must be at least 2 characters.");
        RuleFor(x => x.Page).GreaterThan(0);
        RuleFor(x => x.PageSize).InclusiveBetween(1, 100);
        RuleFor(x => x.SortBy).Must(f => AllowedSortFields.Contains(f.ToLower())).When(x => !string.IsNullOrEmpty(x.SortBy)).WithMessage($"sortBy must be one of: {string.Join(", ", AllowedSortFields)}");
        RuleFor(x => x.SortDirection).Must(d => AllowedDirections.Contains(d.ToLower())).When(x => !string.IsNullOrEmpty(x.SortDirection)).WithMessage("sortDirection must be 'asc' or 'desc'.");
        RuleFor(x => x.MinRating).InclusiveBetween(0, 10).When(x => x.MinRating.HasValue);
        RuleFor(x => x.MaxRating).InclusiveBetween(0, 10).GreaterThanOrEqualTo(x => x.MinRating).When(x => x.MaxRating.HasValue && x.MinRating.HasValue);
        RuleFor(x => x.FromDate).LessThanOrEqualTo(x => x.ToDate).When(x => x.FromDate.HasValue && x.ToDate.HasValue);
        RuleFor(x => x.GenreIds).Must(ids => ids == null || ids.All(id => id > 0));
    }
}
