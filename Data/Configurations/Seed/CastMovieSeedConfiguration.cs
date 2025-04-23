using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class CastMovieSeedConfiguration : IEntityTypeConfiguration<CastMovie>
    {
        public void Configure(EntityTypeBuilder<CastMovie> builder)
        {
            builder
                .HasOne(cm => cm.Movie)
                .WithMany(m => m.Cast)
                .HasForeignKey(cm => cm.MovieId)
                .IsRequired();

            builder
                .HasOne(cm => cm.Actor)
                .WithMany(a => a.Movies)
                .HasForeignKey(cm => cm.ActorId)
                .IsRequired();

            builder.Ignore(cm => cm.Movie);
            builder.Ignore(cm => cm.Actor);

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
                    MovieId = 1,
                    ActorId = 4,
                },
                new CastMovie
                {
                    Id = 5,
                    MovieId = 1,
                    ActorId = 5,
                }
            );
        }
    }
}
