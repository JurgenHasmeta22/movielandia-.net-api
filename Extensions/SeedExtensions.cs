using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Data;

namespace movielandia_.net_api.Extensions
{
    public static class SeedExtensions
    {
        public static async Task SeedDatabaseAsync(this ApplicationDbContext dbContext)
        {
            // Only seed if the database is empty
            if (
                !await dbContext.Genre.AnyAsync()
                && !await dbContext.Movie.AnyAsync()
                && !await dbContext.Actor.AnyAsync()
            )
            {
                // The configurations will be automatically applied through
                // ApplyConfigurationsFromAssembly in OnModelCreating
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
