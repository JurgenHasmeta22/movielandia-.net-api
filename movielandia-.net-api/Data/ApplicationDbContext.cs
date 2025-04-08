using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Models.Domain;

namespace movielandia_.net_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // User related entities
        public DbSet<User> Users { get; set; }
        public DbSet<Avatar> Avatars { get; set; }

        // Content entities
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Genre> Genres { get; set; }

        // Relationship entities
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<SerieGenre> SerieGenres { get; set; }
        public DbSet<CastMovie> CastMovies { get; set; }
        public DbSet<CastSerie> CastSeries { get; set; }
        public DbSet<CrewMovie> CrewMovies { get; set; }
        public DbSet<CrewSerie> CrewSeries { get; set; }

        // Review entities
        public DbSet<MovieReview> MovieReviews { get; set; }
        public DbSet<SerieReview> SerieReviews { get; set; }
        public DbSet<SeasonReview> SeasonReviews { get; set; }
        public DbSet<EpisodeReview> EpisodeReviews { get; set; }
        public DbSet<ActorReview> ActorReviews { get; set; }
        public DbSet<CrewReview> CrewReviews { get; set; }

        // User Favorites
        public DbSet<UserMovieFavorite> UserMovieFavorites { get; set; }
        public DbSet<UserSerieFavorite> UserSerieFavorites { get; set; }
        public DbSet<UserSeasonFavorite> UserSeasonFavorites { get; set; }
        public DbSet<UserEpisodeFavorite> UserEpisodeFavorites { get; set; }
        public DbSet<UserActorFavorite> UserActorFavorites { get; set; }
        public DbSet<UserCrewFavorite> UserCrewFavorites { get; set; }
        public DbSet<UserGenreFavorite> UserGenreFavorites { get; set; }

        // User Ratings
        public DbSet<UserMovieRating> UserMovieRatings { get; set; }
        public DbSet<UserSerieRating> UserSerieRatings { get; set; }
        public DbSet<UserSeasonRating> UserSeasonRatings { get; set; }
        public DbSet<UserEpisodeRating> UserEpisodeRatings { get; set; }
        public DbSet<UserActorRating> UserActorRatings { get; set; }
        public DbSet<UserCrewRating> UserCrewRatings { get; set; }

        // Review Votes
        public DbSet<UpvoteMovieReview> UpvoteMovieReviews { get; set; }
        public DbSet<DownvoteMovieReview> DownvoteMovieReviews { get; set; }
        public DbSet<UpvoteSerieReview> UpvoteSerieReviews { get; set; }
        public DbSet<DownvoteSerieReview> DownvoteSerieReviews { get; set; }
        public DbSet<UpvoteSeasonReview> UpvoteSeasonReviews { get; set; }
        public DbSet<DownvoteSeasonReview> DownvoteSeasonReviews { get; set; }
        public DbSet<UpvoteEpisodeReview> UpvoteEpisodeReviews { get; set; }
        public DbSet<DownvoteEpisodeReview> DownvoteEpisodeReviews { get; set; }
        public DbSet<UpvoteActorReview> UpvoteActorReviews { get; set; }
        public DbSet<DownvoteActorReview> DownvoteActorReviews { get; set; }
        public DbSet<UpvoteCrewReview> UpvoteCrewReviews { get; set; }
        public DbSet<DownvoteCrewReview> DownvoteCrewReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure unique indexes and relationships here
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // Configure one-to-one relationship between User and Avatar
            modelBuilder.Entity<User>()
                .HasOne(u => u.Avatar)
                .WithOne(a => a.User)
                .HasForeignKey<Avatar>(a => a.UserId);

            // Configure unique constraints for favorite relationships
            modelBuilder.Entity<UserMovieFavorite>()
                .HasIndex(umf => new { umf.UserId, umf.MovieId })
                .IsUnique();

            modelBuilder.Entity<UserSerieFavorite>()
                .HasIndex(usf => new { usf.UserId, usf.SerieId })
                .IsUnique();

            // Add more configuration as needed

            base.OnModelCreating(modelBuilder);
        }
    }
}