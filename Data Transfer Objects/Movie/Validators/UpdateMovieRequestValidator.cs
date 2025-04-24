using FluentValidation;
using movielandia_.net_api.DTOs.Requests;

namespace movielandia_.net_api.DTOs.Validators
{
    public class UpdateMovieRequestDTOValidator : AbstractValidator<UpdateMovieRequestDTO>
    {
        public UpdateMovieRequestDTOValidator()
        {
            RuleFor(x => x.Title)
                .MaximumLength(200)
                .When(x => x.Title != null)
                .WithMessage("Title must not exceed 200 characters");

            RuleFor(x => x.PhotoSrc)
                .Must(BeAValidUrl)
                .When(x => x.PhotoSrc != null)
                .WithMessage("Photo URL must be valid");

            RuleFor(x => x.PhotoSrcProd)
                .Must(BeAValidUrl)
                .When(x => x.PhotoSrcProd != null)
                .WithMessage("Production photo URL must be valid");

            RuleFor(x => x.TrailerSrc)
                .Must(BeAValidUrl)
                .When(x => x.TrailerSrc != null)
                .WithMessage("Trailer URL must be valid");

            RuleFor(x => x.Duration)
                .GreaterThan(0)
                .When(x => x.Duration.HasValue)
                .WithMessage("Duration must be greater than 0 minutes");

            RuleFor(x => x.RatingImdb)
                .InclusiveBetween(0, 10)
                .When(x => x.RatingImdb.HasValue)
                .WithMessage("IMDb rating must be between 0 and 10");

            RuleFor(x => x.Description)
                .MaximumLength(2000)
                .When(x => x.Description != null)
                .WithMessage("Description must not exceed 2000 characters");

            RuleForEach(x => x.Cast)
                .SetValidator(new MovieCastRequestValidator())
                .When(x => x.Cast != null);

            RuleForEach(x => x.Crew)
                .SetValidator(new MovieCrewRequestValidator())
                .When(x => x.Crew != null);
        }

        private bool BeAValidUrl(string? url)
        {
            return url != null && Uri.TryCreate(url, UriKind.Absolute, out _);
        }
    }
}
