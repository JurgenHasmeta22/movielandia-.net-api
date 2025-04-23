using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class MovieReviewSeedConfiguration : IEntityTypeConfiguration<MovieReview>
    {
        public void Configure(EntityTypeBuilder<MovieReview> builder)
        {
            var now = new DateTime(2025, 4, 10); // Current date for seeding

            // Configure navigation properties to be auto-included when loading the entity
            builder.Navigation(r => r.User).AutoInclude();
            builder.Navigation(r => r.Movie).AutoInclude();

            // Configure relationships
            builder
                .HasOne(r => r.User)
                .WithMany(u => u.MovieReviews)
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            builder
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieId)
                .IsRequired();

            // Configure required properties
            builder.Property(r => r.CreatedAt).IsRequired();
            builder.Property(r => r.Content).IsRequired();

            // Configure ignore rules for seeding
            builder.Ignore(r => r.User);
            builder.Ignore(r => r.Movie);

            builder.HasData(
                new[]
                {
                    new MovieReview
                    {
                        Id = 1,
                        UserId = 2,
                        MovieId = 1,
                        Content = "Great movie, highly recommended!",
                        Rating = 4.5f,
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                    new MovieReview
                    {
                        Id = 2,
                        UserId = 3,
                        MovieId = 1,
                        Content = "Interesting plot and good acting.",
                        Rating = 4.0f,
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                    new MovieReview
                    {
                        Id = 3,
                        UserId = 4,
                        MovieId = 1,
                        Content = "Could have been better, but still entertaining.",
                        Rating = 3.5f,
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                    new MovieReview
                    {
                        Id = 4,
                        UserId = 5,
                        MovieId = 1,
                        Content = "Excellent cinematography and direction!",
                        Rating = 5.0f,
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                    new MovieReview
                    {
                        Id = 5,
                        UserId = 6,
                        MovieId = 1,
                        Content = "A decent watch, nothing special.",
                        Rating = 3.0f,
                        CreatedAt = now,
                        UpdatedAt = now,
                    },
                }
            );
        }
    }
}
