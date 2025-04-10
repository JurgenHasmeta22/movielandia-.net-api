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

            // Seed data using anonymous type to bypass navigation property requirements
            var data = new[]
            {
                new
                {
                    Id = 1,
                    MovieId = 1,
                    GenreId = 1,
                },
                new
                {
                    Id = 2,
                    MovieId = 1,
                    GenreId = 2,
                },
                new
                {
                    Id = 3,
                    MovieId = 1,
                    GenreId = 3,
                },
            };

            builder.HasData(data);
        }
    }
}
