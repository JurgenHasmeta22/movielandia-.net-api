using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class CastMovieSeedConfiguration : IEntityTypeConfiguration<CastMovie>
    {
        public void Configure(EntityTypeBuilder<CastMovie> builder)
        {
            builder.HasData(
                new CastMovie
                {
                    Id = 1,
                    MovieId = 5,
                    ActorId = 1,
                },
                new CastMovie
                {
                    Id = 2,
                    MovieId = 5,
                    ActorId = 2,
                },
                new CastMovie
                {
                    Id = 3,
                    MovieId = 5,
                    ActorId = 3,
                },
                new CastMovie
                {
                    Id = 4,
                    MovieId = 13,
                    ActorId = 4,
                },
                new CastMovie
                {
                    Id = 5,
                    MovieId = 13,
                    ActorId = 5,
                },
                new CastMovie
                {
                    Id = 6,
                    MovieId = 13,
                    ActorId = 6,
                },
                new CastMovie
                {
                    Id = 7,
                    MovieId = 14,
                    ActorId = 7,
                },
                new CastMovie
                {
                    Id = 8,
                    MovieId = 14,
                    ActorId = 8,
                },
                new CastMovie
                {
                    Id = 9,
                    MovieId = 1,
                    ActorId = 11,
                },
                new CastMovie
                {
                    Id = 10,
                    MovieId = 1,
                    ActorId = 12,
                }
            );
        }
    }
}
