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
                    await dbContext.User.AddRangeAsync();
                    await dbContext.SaveChangesAsync();

                    await dbContext.Genre.AddRangeAsync();
                    await dbContext.Movie.AddRangeAsync();
                    await dbContext.Actor.AddRangeAsync();
                    await dbContext.SaveChangesAsync();

                    await dbContext.MovieGenre.AddRangeAsync();
                    await dbContext.CastMovie.AddRangeAsync();
                    await dbContext.SaveChangesAsync();

                    await dbContext.MovieReview.AddRangeAsync();
                    await dbContext.SaveChangesAsync();

                    await dbContext.UpvoteMovieReview.AddRangeAsync();
                    await dbContext.DownvoteMovieReview.AddRangeAsync();
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
