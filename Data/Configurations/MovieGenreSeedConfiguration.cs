using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class MovieGenreSeedConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            // Configure relationships
            builder
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MovieId)
                .IsRequired();

            builder
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(mg => mg.GenreId)
                .IsRequired();

            // Configure ignore rules for seeding
            builder.Ignore(mg => mg.Movie);
            builder.Ignore(mg => mg.Genre);

            builder.HasData(
                // Freaks Out (Movie Id = 1)
                new MovieGenre
                {
                    Id = 1,
                    MovieId = 1,
                    GenreId = 1, // Action
                },
                new MovieGenre
                {
                    Id = 2,
                    MovieId = 1,
                    GenreId = 2, // Drama
                },
                new MovieGenre
                {
                    Id = 3,
                    MovieId = 1,
                    GenreId = 10, // Fantasy
                },
                // Spider-Man: No Way Home (Movie Id = 5)
                new MovieGenre
                {
                    Id = 4,
                    MovieId = 5,
                    GenreId = 1, // Action
                },
                new MovieGenre
                {
                    Id = 5,
                    MovieId = 5,
                    GenreId = 4, // Science Fiction
                },
                new MovieGenre
                {
                    Id = 6,
                    MovieId = 5,
                    GenreId = 10, // Fantasy
                }
            );
        }
    }
}
