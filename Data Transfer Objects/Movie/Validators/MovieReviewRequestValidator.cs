using FluentValidation;
using movielandia_.net_api.DTOs.Requests;

namespace movielandia_.net_api.DTOs.Validators
{
    public class MovieReviewRequestValidator : AbstractValidator<MovieReviewRequest>
    {
        public MovieReviewRequestValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .MaximumLength(2000)
                .WithMessage("Review content is required and must not exceed 2000 characters");

            RuleFor(x => x.Rating)
                .InclusiveBetween(0, 10)
                .When(x => x.Rating.HasValue)
                .WithMessage("Rating must be between 0 and 10");

            RuleFor(x => x.MovieId).GreaterThan(0).WithMessage("Invalid movie ID");

            RuleFor(x => x.IsUpvote)
                .NotEqual(x => x.IsDownvote)
                .When(x =>
                    x.IsUpvote.HasValue
                    && x.IsDownvote.HasValue
                    && x.IsUpvote.Value
                    && x.IsDownvote.Value
                )
                .WithMessage("A review cannot be both upvoted and downvoted");
        }
    }
}
