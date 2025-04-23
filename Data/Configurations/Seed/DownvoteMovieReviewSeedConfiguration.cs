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

            builder.Ignore(dmr => dmr.User);
            builder.Ignore(dmr => dmr.Movie);
            builder.Ignore(dmr => dmr.MovieReview);

            builder.HasData(
                new DownvoteMovieReview
                {
                    Id = 1,
                    UserId = 6,
                    MovieId = 1,
                    MovieReviewId = 2,
                },
                new DownvoteMovieReview
                {
                    Id = 2,
                    UserId = 7,
                    MovieId = 1,
                    MovieReviewId = 3,
                }
            );
        }
    }
}
