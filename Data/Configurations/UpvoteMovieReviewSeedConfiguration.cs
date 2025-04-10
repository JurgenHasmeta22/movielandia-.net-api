using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class UpvoteMovieReviewSeedConfiguration : IEntityTypeConfiguration<UpvoteMovieReview>
    {
        public void Configure(EntityTypeBuilder<UpvoteMovieReview> builder)
        {
            builder.HasData(
                new UpvoteMovieReview
                {
                    Id = 1,
                    UserId = 3,
                    MovieId = 1,
                    MovieReviewId = 1,
                },
                new UpvoteMovieReview
                {
                    Id = 2,
                    UserId = 4,
                    MovieId = 1,
                    MovieReviewId = 2,
                },
                new UpvoteMovieReview
                {
                    Id = 3,
                    UserId = 5,
                    MovieId = 1,
                    MovieReviewId = 4,
                },
                new UpvoteMovieReview
                {
                    Id = 4,
                    UserId = 6,
                    MovieId = 1,
                    MovieReviewId = 5,
                },
                new UpvoteMovieReview
                {
                    Id = 5,
                    UserId = 7,
                    MovieId = 1,
                    MovieReviewId = 7,
                }
            );
        }
    }
}
