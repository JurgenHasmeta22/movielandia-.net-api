using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Enums;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Configure required properties
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Password).IsRequired();

            // Removed dynamic DateTime variable

            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin22",
                    Email = "admin@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Admin22%"),
                    Role = UserType.Admin,
                    Bio = "System administrator",
                    Active = true,
                },
                new User
                {
                    Id = 2,
                    UserName = "moviefan1",
                    Email = "moviefan1@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("MovieFan1%"),
                    Role = UserType.User,
                    Bio = "Passionate about movies",
                    Active = true,
                },
                new User
                {
                    Id = 3,
                    UserName = "cinephile2",
                    Email = "cinephile2@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Cinephile2%"),
                    Role = UserType.User,
                    Bio = "Film enthusiast and reviewer",
                    Active = true,
                },
                new User
                {
                    Id = 4,
                    UserName = "reviewer3",
                    Email = "reviewer3@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Reviewer3%"),
                    Role = UserType.User,
                    Bio = "Professional movie critic",
                    Active = true,
                },
                new User
                {
                    Id = 5,
                    UserName = "filmcritic4",
                    Email = "filmcritic4@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("FilmCritic4%"),
                    Role = UserType.User,
                    Bio = "Aspiring film critic",
                    Active = true,
                },
                new User
                {
                    Id = 6,
                    UserName = "moviebuff5",
                    Email = "moviebuff5@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("MovieBuff5%"),
                    Role = UserType.User,
                    Bio = "Movie enthusiast",
                    Active = true,
                },
                new User
                {
                    Id = 7,
                    UserName = "filmlover6",
                    Email = "filmlover6@movielandia.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("FilmLover6%"),
                    Role = UserType.User,
                    Bio = "Just love watching movies",
                    Active = true,
                }
            );
        }
    }
}
