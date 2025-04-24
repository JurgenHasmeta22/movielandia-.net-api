using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cleanupPath = Path.Combine("Data", "Configurations", "Seed", "CleanupAndSetup.sql");

            if (File.Exists(cleanupPath))
            {
                migrationBuilder.Sql(File.ReadAllText(cleanupPath));
            }

            var seedFiles = new[]
            {
                "UserSeed.sql",
                "GenreSeed.sql",
                "ActorSeed.sql",
                "CrewSeed.sql",
                "MovieSeed.sql",
                "MovieGenreSeed.sql",
                "MovieCastAndCrewSeed.sql",
                "SerieSeed.sql",
                "SerieGenreSeed.sql",
                "SerieCastAndCrewSeed.sql",
                "SeasonSeed.sql",
                "EpisodeSeed.sql",
                "ForumSeed.sql",
                "ReviewRelationshipsSeed.sql",
            };

            foreach (var seedFile in seedFiles)
            {
                var filePath = Path.Combine("Data", "Configurations", "Seed", seedFile);

                if (File.Exists(filePath))
                {
                    migrationBuilder.Sql(File.ReadAllText(filePath));
                }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cleanupPath = Path.Combine("Data", "Configurations", "Seed", "CleanupAndSetup.sql");

            if (File.Exists(cleanupPath))
            {
                migrationBuilder.Sql(File.ReadAllText(cleanupPath));
            }
        }
    }
}
