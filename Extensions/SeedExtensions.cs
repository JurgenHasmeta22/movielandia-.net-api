using System.Reflection;
using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Data;

namespace movielandia_.net_api.Extensions
{
    public static class SeedExtensions
    {
        public static async Task SeedDatabaseAsync(this ApplicationDbContext dbContext)
        {
            await using var transaction = await dbContext.Database.BeginTransactionAsync();

            try
            {
                var assemblyLocation = Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location
                );
                var sqlFilePath = Path.Combine(
                    assemblyLocation!,
                    "Data",
                    "Configurations",
                    "Seed",
                    "seed.sql"
                );

                if (File.Exists(sqlFilePath))
                {
                    var sql = await File.ReadAllTextAsync(sqlFilePath);
                    await dbContext.Database.ExecuteSqlRawAsync(sql);
                    await dbContext.Database.CommitTransactionAsync();
                }
                else
                {
                    throw new FileNotFoundException($"Seed file not found: {sqlFilePath}");
                }
            }
            catch (Exception)
            {
                await dbContext.Database.RollbackTransactionAsync();
                throw;
            }
        }
    }
}
