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

            // Ignore required navigation properties during seeding
            var data = new[]
            {
                new
                {
                    Id = 1,
                    Content = "test",
                    Rating = 4.5f,
                    CreatedAt = now,
                    UpdatedAt = (DateTime?)null,
                    UserId = 2,
                    MovieId = 1,
                },
                new
                {
                    Id = 2,
                    Content = "test",
                    Rating = 4.0f,
                    CreatedAt = now,
                    UpdatedAt = (DateTime?)null,
                    UserId = 3,
                    MovieId = 1,
                },
                new
                {
                    Id = 3,
                    Content = "test",
                    Rating = 3.5f,
                    CreatedAt = now,
                    UpdatedAt = (DateTime?)null,
                    UserId = 4,
                    MovieId = 1,
                },
            };

            builder.HasData(data);
        }
    }
}
