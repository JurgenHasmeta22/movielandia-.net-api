using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class MovieGenreSeedConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
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

            builder.Ignore(mg => mg.Movie);
            builder.Ignore(mg => mg.Genre);

            builder.HasData(
                new MovieGenre
                {
                    Id = 1,
                    MovieId = 1,
                    GenreId = 1,
                },
                new MovieGenre
                {
                    Id = 2,
                    MovieId = 1,
                    GenreId = 2,
                },
                new MovieGenre
                {
                    Id = 3,
                    MovieId = 1,
                    GenreId = 10,
                },
                new MovieGenre
                {
                    Id = 4,
                    MovieId = 5,
                    GenreId = 1,
                },
                new MovieGenre
                {
                    Id = 5,
                    MovieId = 5,
                    GenreId = 4,
                },
                new MovieGenre
                {
                    Id = 6,
                    MovieId = 5,
                    GenreId = 10,
                }
            );
        }
    }
}
