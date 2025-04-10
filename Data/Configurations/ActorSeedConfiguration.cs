using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class ActorSeedConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(
                new Actor
                {
                    Id = 1,
                    Fullname = "Tom Holland",
                    Description = "A brief description for Tom Holland.",
                    Debut = "2012",
                    PhotoSrc = "http://localhost:4000/images/placeholder.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg",
                },
                new Actor
                {
                    Id = 2,
                    Fullname = "Zendaya",
                    Description = "A brief description for Zendaya.",
                    Debut = "2010",
                    PhotoSrc = "http://localhost:4000/images/placeholder.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg",
                },
                new Actor
                {
                    Id = 3,
                    Fullname = "Benedict Cumberbatch",
                    Description = "A brief description for Benedict Cumberbatch.",
                    Debut = "2000",
                    PhotoSrc = "http://localhost:4000/images/placeholder.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/placeholder.jpg",
                }
            );
        }
    }
}
