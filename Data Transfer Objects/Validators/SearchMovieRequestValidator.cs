using FluentValidation;
using movielandia_.net_api.DTOs.Requests;

namespace movielandia_.net_api.DTOs.Validators
{
    public class SearchMovieRequestDTOValidator : AbstractValidator<SearchMovieRequestDTO>
    {
        private readonly string[] allowedSortFields =
        {
            "title",
            "dateAired",
            "rating",
            "duration",
        };
        private readonly string[] allowedSortDirections = { "asc", "desc" };

        public SearchMovieRequestDTOValidator()
        {
            RuleFor(x => x.SearchTerm)
                .NotEmpty()
                .MinimumLength(2)
                .WithMessage("Search term must be at least 2 characters long");

            RuleFor(x => x.Page).GreaterThan(0).WithMessage("Page number must be greater than 0");

            RuleFor(x => x.PerPage)
                .InclusiveBetween(1, 100)
                .WithMessage("Items per page must be between 1 and 100");

            RuleFor(x => x.SortBy)
                .Must(field => allowedSortFields.Contains(field.ToLower()))
                .When(x => !string.IsNullOrEmpty(x.SortBy))
                .WithMessage($"Sort field must be one of: {string.Join(", ", allowedSortFields)}");

            RuleFor(x => x.SortDirection)
                .Must(direction => allowedSortDirections.Contains(direction.ToLower()))
                .When(x => !string.IsNullOrEmpty(x.SortDirection))
                .WithMessage("Sort direction must be either 'asc' or 'desc'");

            RuleFor(x => x.MinRating)
                .InclusiveBetween(0, 10)
                .When(x => x.MinRating.HasValue)
                .WithMessage("Minimum rating must be between 0 and 10");

            RuleFor(x => x.MaxRating)
                .InclusiveBetween(0, 10)
                .When(x => x.MaxRating.HasValue)
                .WithMessage("Maximum rating must be between 0 and 10")
                .GreaterThanOrEqualTo(x => x.MinRating)
                .When(x => x.MaxRating.HasValue && x.MinRating.HasValue)
                .WithMessage("Maximum rating must be greater than or equal to minimum rating");

            RuleFor(x => x.FromDate)
                .LessThanOrEqualTo(x => x.ToDate)
                .When(x => x.FromDate.HasValue && x.ToDate.HasValue)
                .WithMessage("From date must be before or equal to to date");

            RuleFor(x => x.GenreIds)
                .Must(ids => ids == null || ids.All(id => id > 0))
                .WithMessage("All genre IDs must be greater than 0");
        }
    }
}
