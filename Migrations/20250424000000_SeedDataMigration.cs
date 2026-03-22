using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace movielandia_.net_api.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(ReadEmbeddedSql("CleanupAndSetup.sql"));

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
                migrationBuilder.Sql(ReadEmbeddedSql(seedFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
            => migrationBuilder.Sql(ReadEmbeddedSql("CleanupAndSetup.sql"));

        /// <summary>
        /// Reads an embedded SQL resource by filename.
        /// Resources are baked into the assembly at build time — no files needed on disk at runtime.
        /// </summary>
        private static string ReadEmbeddedSql(string fileName)
        {
            var assembly = typeof(SeedDataMigration).Assembly;

            var resourceName = assembly
                .GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith(fileName, StringComparison.OrdinalIgnoreCase))
                ?? throw new InvalidOperationException(
                    $"Embedded SQL resource '{fileName}' was not found in assembly '{assembly.GetName().Name}'. " +
                    $"Available resources: {string.Join(", ", assembly.GetManifestResourceNames())}");

            using var stream = assembly.GetManifestResourceStream(resourceName)!;
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
