using FluentValidation;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;

namespace movielandia_.net_api.Application.Features.Movies.Validators;

public sealed class CreateMovieRequestValidator : AbstractValidator<CreateMovieRequest>
{
    public CreateMovieRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(200).WithMessage("Title must not exceed 200 characters.");

        RuleFor(x => x.PhotoSrc)
            .NotEmpty().Must(IsValidUrl).WithMessage("A valid photo URL is required.");

        RuleFor(x => x.PhotoSrcProd)
            .NotEmpty().Must(IsValidUrl).WithMessage("A valid production photo URL is required.");

        RuleFor(x => x.TrailerSrc)
            .NotEmpty().Must(IsValidUrl).WithMessage("A valid trailer URL is required.");

        RuleFor(x => x.Duration)
            .GreaterThan(0).WithMessage("Duration must be greater than 0 minutes.");

        RuleFor(x => x.RatingImdb)
            .InclusiveBetween(0, 10).WithMessage("IMDb rating must be between 0 and 10.");

        RuleFor(x => x.Description)
            .NotEmpty().MaximumLength(2000).WithMessage("Description is required and must not exceed 2000 characters.");

        RuleFor(x => x.GenreIds)
            .NotEmpty().WithMessage("At least one genre is required.");

        RuleFor(x => x.Cast)
            .NotEmpty().WithMessage("At least one cast member is required.");

        RuleForEach(x => x.Cast).SetValidator(new CastMemberRequestValidator());

        RuleFor(x => x.Crew)
            .NotEmpty().WithMessage("At least one crew member is required.");

        RuleForEach(x => x.Crew).SetValidator(new CrewMemberRequestValidator());
    }

    private static bool IsValidUrl(string url)
        => Uri.TryCreate(url, UriKind.Absolute, out _);
}

public sealed class CastMemberRequestValidator : AbstractValidator<CastMemberRequest>
{
    public CastMemberRequestValidator()
    {
        RuleFor(x => x.ActorId).GreaterThan(0).WithMessage("Invalid actor ID.");
        RuleFor(x => x.Role).NotEmpty().MaximumLength(100).WithMessage("Role is required (max 100 chars).");
    }
}

public sealed class CrewMemberRequestValidator : AbstractValidator<CrewMemberRequest>
{
    public CrewMemberRequestValidator()
    {
        RuleFor(x => x.CrewId).GreaterThan(0).WithMessage("Invalid crew ID.");
        RuleFor(x => x.Role).NotEmpty().MaximumLength(100).WithMessage("Role is required (max 100 chars).");
    }
}
