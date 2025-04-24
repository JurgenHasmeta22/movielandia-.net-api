using FluentValidation;
using movielandia_.net_api.DTOs.Requests;

namespace movielandia_.net_api.DTOs.Validators
{
    public class CreateMovieRequestDTOValidator : AbstractValidator<CreateMovieRequestDTO>
    {
        public CreateMovieRequestDTOValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(200)
                .WithMessage("Title is required and must not exceed 200 characters");

            RuleFor(x => x.PhotoSrc)
                .NotEmpty()
                .Must(BeAValidUrl)
                .WithMessage("A valid photo URL is required");

            RuleFor(x => x.PhotoSrcProd)
                .NotEmpty()
                .Must(BeAValidUrl)
                .WithMessage("A valid production photo URL is required");

            RuleFor(x => x.TrailerSrc)
                .NotEmpty()
                .Must(BeAValidUrl)
                .WithMessage("A valid trailer URL is required");

            RuleFor(x => x.Duration)
                .GreaterThan(0)
                .WithMessage("Duration must be greater than 0 minutes");

            RuleFor(x => x.RatingImdb)
                .InclusiveBetween(0, 10)
                .WithMessage("IMDb rating must be between 0 and 10");

            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(2000)
                .WithMessage("Description is required and must not exceed 2000 characters");

            RuleFor(x => x.GenreIds).NotEmpty().WithMessage("At least one genre must be specified");

            RuleFor(x => x.Cast)
                .NotEmpty()
                .WithMessage("At least one cast member must be specified");

            RuleForEach(x => x.Cast).SetValidator(new MovieCastRequestValidator());

            RuleFor(x => x.Crew)
                .NotEmpty()
                .WithMessage("At least one crew member must be specified");

            RuleForEach(x => x.Crew).SetValidator(new MovieCrewRequestValidator());
        }

        private bool BeAValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }

    public class MovieCastRequestValidator : AbstractValidator<MovieCastRequest>
    {
        public MovieCastRequestValidator()
        {
            RuleFor(x => x.ActorId).GreaterThan(0).WithMessage("Invalid actor ID");

            RuleFor(x => x.Role)
                .NotEmpty()
                .MaximumLength(100)
                .WithMessage("Role is required and must not exceed 100 characters");
        }
    }

    public class MovieCrewRequestValidator : AbstractValidator<MovieCrewRequest>
    {
        public MovieCrewRequestValidator()
        {
            RuleFor(x => x.CrewId).GreaterThan(0).WithMessage("Invalid crew ID");

            RuleFor(x => x.Role)
                .NotEmpty()
                .MaximumLength(100)
                .WithMessage("Role is required and must not exceed 100 characters");
        }
    }
}
