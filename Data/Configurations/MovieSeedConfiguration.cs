using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Data.Configurations
{
    public class MovieSeedConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Freaks Out",
                    TrailerSrc = "https://www.youtube.com/embed/D8La5G1DzCM",
                    Duration = 141,
                    DateAired = new DateTime(2021, 10, 28),
                    RatingImdb = 7.4f,
                    Description =
                        "Matilde, Cencio, Fulvio, and Mario are united when World War II strikes Rome. Israel, their circus owner, disappears in an attempt to find a place abroad for all of them.",
                    PhotoSrc =
                        "http://localhost:4000/images/movies/1TkkTo8UiRl5lWM5qkAISHXg0fU.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/movies/1TkkTo8UiRl5lWM5qkAISHXg0fU.jpg",
                },
                new Movie
                {
                    Id = 2,
                    Title = "My Father's Violin",
                    TrailerSrc = "https://www.youtube.com/embed/GAmo87Ep-tI",
                    Duration = 112,
                    DateAired = new DateTime(2022, 11, 17),
                    RatingImdb = 6.5f,
                    Description =
                        "Through their shared grief and connection to music, an orphaned girl bonds with her emotionally distant, successful violinist uncle.",
                    PhotoSrc = "http://localhost:4000/images/movies/fathersviolin.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/movies/fathersviolin.jpg",
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Invisible Guest",
                    TrailerSrc = "https://www.youtube.com/embed/epCg2RbyF80",
                    Duration = 126,
                    DateAired = new DateTime(2017, 3, 24),
                    RatingImdb = 8.1f,
                    Description =
                        "A young businessman faces a lawyer in an attempt to prove his innocence for the murder of his girlfriend.",
                    PhotoSrc =
                        "http://localhost:4000/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg",
                    PhotoSrcProd =
                        "https://movielandia-avenger22s-projects.vercel.app/images/movies/8c9fce3c0ffa46576423d44b525447edc25f1396.jpg",
                }
            );
        }
    }
}
