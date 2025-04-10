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
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin22",
                    Email = "admin@yahoo.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Admin22%"),
                    Role = UserType.Admin,
                    Bio = "Admin bio test",
                    Active = true,
                },
                new User
                {
                    Id = 2,
                    UserName = "test1",
                    Email = "test1@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test2222%"),
                    Role = UserType.User,
                    Bio = "Test 1 bio test",
                    Active = true,
                },
                new User
                {
                    Id = 3,
                    UserName = "test2",
                    Email = "test2@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test2222%"),
                    Role = UserType.User,
                    Bio = "Test 2 bio test",
                    Active = true,
                },
                new User
                {
                    Id = 4,
                    UserName = "test3",
                    Email = "test3@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test3333%"),
                    Role = UserType.User,
                    Bio = "Test 3 bio test",
                    Active = true,
                },
                new User
                {
                    Id = 5,
                    UserName = "test4",
                    Email = "test4@email.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("Test4444%"),
                    Role = UserType.User,
                    Bio = "Test 4 bio test",
                    Active = true,
                }
            );
        }
    }
}
