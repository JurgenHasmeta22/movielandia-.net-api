using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class ActorSeedConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(a => a.Fullname).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.PhotoSrc).IsRequired();
            builder.Property(a => a.PhotoSrcProd).IsRequired();

            builder.HasData(
                new Actor
                {
                    Id = 1,
                    Fullname = "Tom Holland",
                    Description =
                        "Thomas Stanley Holland is an English actor. His accolades include a British Academy Film Award and three Saturn Awards.",
                    Debut = "2012",
                    PhotoSrc = "http://localhost:4000/images/actors/tom-holland.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/actors/tom-holland.jpg",
                    CreatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                    UpdatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                },
                new Actor
                {
                    Id = 2,
                    Fullname = "Zendaya",
                    Description =
                        "Zendaya Maree Stoermer Coleman is an American actress and singer. She has received various accolades, including two Primetime Emmy Awards.",
                    Debut = "2010",
                    PhotoSrc = "http://localhost:4000/images/actors/zendaya.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/actors/zendaya.jpg",
                    CreatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                    UpdatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                },
                new Actor
                {
                    Id = 3,
                    Fullname = "Benedict Cumberbatch",
                    Description =
                        "Benedict Timothy Carlton Cumberbatch CBE is an English actor. He is known for his work on screen and stage.",
                    Debut = "2000",
                    PhotoSrc = "http://localhost:4000/images/actors/benedict-cumberbatch.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/actors/benedict-cumberbatch.jpg",
                    CreatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                    UpdatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                },
                new Actor
                {
                    Id = 4,
                    Fullname = "Aurora Giovinazzo",
                    Description =
                        "Aurora Giovinazzo is an Italian actress known for her role in Freaks Out.",
                    Debut = "2019",
                    PhotoSrc = "http://localhost:4000/images/actors/aurora-giovinazzo.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/actors/aurora-giovinazzo.jpg",
                    CreatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                    UpdatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                },
                new Actor
                {
                    Id = 5,
                    Fullname = "Pietro Castellitto",
                    Description =
                        "Pietro Castellitto is an Italian actor and director known for his work in Freaks Out.",
                    Debut = "2015",
                    PhotoSrc = "http://localhost:4000/images/actors/pietro-castellitto.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/actors/pietro-castellitto.jpg",
                    CreatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                    UpdatedAt = new DateTime(2025, 4, 10, 0, 0, 0),
                }
            );
        }
    }
}
