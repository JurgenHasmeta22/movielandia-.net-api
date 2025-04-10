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
                new Genre
                {
                    Id = 1,
                    Name = "Action",
                    Description = "Action-packed entertainment",
                },
                new Genre
                {
                    Id = 2,
                    Name = "Drama",
                    Description = "Character-driven stories",
                },
                new Genre
                {
                    Id = 3,
                    Name = "Comedy",
                    Description = "Light-hearted entertainment",
                },
                new Genre
                {
                    Id = 4,
                    Name = "Science Fiction",
                    Description = "Futuristic and speculative fiction",
                },
                new Genre
                {
                    Id = 5,
                    Name = "Horror",
                    Description = "Scary and suspenseful content",
                },
                new Genre
                {
                    Id = 6,
                    Name = "Romance",
                    Description = "Love and relationships",
                },
                new Genre
                {
                    Id = 7,
                    Name = "Thriller",
                    Description = "Suspenseful and exciting content",
                },
                new Genre
                {
                    Id = 8,
                    Name = "Documentary",
                    Description = "Factual and educational content",
                },
                new Genre
                {
                    Id = 9,
                    Name = "Animation",
                    Description = "Animated content for all ages",
                },
                new Genre
                {
                    Id = 10,
                    Name = "Fantasy",
                    Description = "Magical and imaginative stories",
                }
            );
        }
    }
}
