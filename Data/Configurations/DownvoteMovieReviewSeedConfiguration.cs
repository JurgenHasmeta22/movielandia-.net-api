using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class DownvoteMovieReviewSeedConfiguration
        : IEntityTypeConfiguration<DownvoteMovieReview>
    {
        public void Configure(EntityTypeBuilder<DownvoteMovieReview> builder)
        {
            // Configure relationships
            builder
                .HasOne(dmr => dmr.Movie)
                .WithMany(m => m.DownvoteMovieReviews)
                .HasForeignKey(dmr => dmr.MovieId)
                .IsRequired();

            builder
                .HasOne(dmr => dmr.MovieReview)
                .WithMany(mr => mr.Downvotes)
                .HasForeignKey(dmr => dmr.MovieReviewId)
                .IsRequired();

            builder
                .HasOne(dmr => dmr.User)
                .WithMany()
                .HasForeignKey(dmr => dmr.UserId)
                .IsRequired();

            // Seed data using anonymous type to bypass navigation property requirements
            var data = new[]
            {
                new
                {
                    Id = 1,
                    UserId = 6,
                    MovieId = 1,
                    MovieReviewId = 2,
                },
                new
                {
                    Id = 2,
                    UserId = 4,
                    MovieId = 1,
                    MovieReviewId = 5,
                },
            };

            builder.HasData(data);
        }
    }
}
