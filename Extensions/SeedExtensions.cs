using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Data;

namespace movielandia_.net_api.Extensions
{
    public static class SeedExtensions
    {
        public static async Task SeedDatabaseAsync(this ApplicationDbContext dbContext)
        {
            if (
                !await dbContext.User.AnyAsync()
                && !await dbContext.Genre.AnyAsync()
                && !await dbContext.Movie.AnyAsync()
                && !await dbContext.Actor.AnyAsync()
            )
            {
                await using var transaction = await dbContext.Database.BeginTransactionAsync();

                try
                {
                    // 1. Seed users first
                    await dbContext.User.AddRangeAsync(); // Users from UserSeedConfiguration
                    await dbContext.SaveChangesAsync();

                    // 2. Seed basic entities
                    await dbContext.Genre.AddRangeAsync(); // Genres from GenreSeedConfiguration
                    await dbContext.Movie.AddRangeAsync(); // Movies from MovieSeedConfiguration
                    await dbContext.Actor.AddRangeAsync(); // Actors from ActorSeedConfiguration
                    await dbContext.SaveChangesAsync();

                    // 3. Seed relationship entities
                    await dbContext.MovieGenre.AddRangeAsync(); // MovieGenres from MovieGenreSeedConfiguration
                    await dbContext.CastMovie.AddRangeAsync(); // CastMovies from CastMovieSeedConfiguration
                    await dbContext.SaveChangesAsync();

                    // 4. Seed review-related entities
                    await dbContext.MovieReview.AddRangeAsync(); // MovieReviews from MovieReviewSeedConfiguration
                    await dbContext.SaveChangesAsync();

                    // 5. Seed review interaction entities
                    await dbContext.UpvoteMovieReview.AddRangeAsync(); // Upvotes from UpvoteMovieReviewSeedConfiguration
                    await dbContext.DownvoteMovieReview.AddRangeAsync(); // Downvotes from DownvoteMovieReviewSeedConfiguration
                    await dbContext.SaveChangesAsync();

                    await dbContext.Database.CommitTransactionAsync();
                }
                catch (Exception)
                {
                    await dbContext.Database.RollbackTransactionAsync();
                    throw;
                }
            }
        }
    }
}
