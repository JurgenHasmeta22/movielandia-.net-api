using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class GenreSeedConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Drama" },
                new Genre { Id = 3, Name = "Comedy" },
                new Genre { Id = 4, Name = "Science Fiction" },
                new Genre { Id = 5, Name = "Horror" },
                new Genre { Id = 6, Name = "Romance" },
                new Genre { Id = 7, Name = "Thriller" },
                new Genre { Id = 8, Name = "Documentary" },
                new Genre { Id = 9, Name = "Animation" },
                new Genre { Id = 10, Name = "Fantasy" }
            );
        }
    }
}
