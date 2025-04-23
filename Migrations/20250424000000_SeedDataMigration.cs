using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var seedSqlPath = Path.Combine("Data", "Configurations", "Seed", "seed.sql");

            if (File.Exists(seedSqlPath))
            {
                var sqlScript = File.ReadAllText(seedSqlPath);
                migrationBuilder.Sql(sqlScript);
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                DELETE FROM UserGenreFavorite;
                DELETE FROM UserMovieFavorite;
                DELETE FROM UserMovieRating;
                DELETE FROM MovieReview;
                DELETE FROM CastMovie;
                DELETE FROM MovieGenre;
                DELETE FROM Actor;
                DELETE FROM Movie;
                DELETE FROM [User] WHERE Id IN (1, 2, 3);
                DELETE FROM Genre;
            "
            );
        }
    }
}
