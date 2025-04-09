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

            // Configure cascade delete for Episode-Season relationship
            modelBuilder.Entity<Episode>()
                .HasOne(e => e.Season)
                .WithMany()
                .HasForeignKey(e => e.SeasonId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Season-Serie relationship
            modelBuilder.Entity<Season>()
                .HasOne(s => s.Serie)
                .WithMany()
                .HasForeignKey(s => s.SerieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for all Forum related tables
            modelBuilder.Entity<ForumPost>()
                .HasOne(fp => fp.User)
                .WithMany()
                .HasForeignKey(fp => fp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumReply>()
                .HasOne(fr => fr.User)
                .WithMany()
                .HasForeignKey(fr => fr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumTopic>()
                .HasOne(ft => ft.User)
                .WithMany()
                .HasForeignKey(ft => ft.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Forum votes
            modelBuilder.Entity<UpvoteForumPost>()
                .HasOne(ufp => ufp.User)
                .WithMany()
                .HasForeignKey(ufp => ufp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumPost>()
                .HasOne(dfp => dfp.User)
                .WithMany()
                .HasForeignKey(dfp => dfp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteForumReply>()
                .HasOne(ufr => ufr.User)
                .WithMany()
                .HasForeignKey(ufr => ufr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumReply>()
                .HasOne(dfr => dfr.User)
                .WithMany()
                .HasForeignKey(dfr => dfr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteForumTopic>()
                .HasOne(uft => uft.User)
                .WithMany()
                .HasForeignKey(uft => uft.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumTopic>()
                .HasOne(dft => dft.User)
                .WithMany()
                .HasForeignKey(dft => dft.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Forum votes to posts, replies and topics
            modelBuilder.Entity<UpvoteForumPost>()
                .HasOne(ufp => ufp.Post)
                .WithMany()
                .HasForeignKey(ufp => ufp.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumPost>()
                .HasOne(dfp => dfp.Post)
                .WithMany()
                .HasForeignKey(dfp => dfp.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteForumReply>()
                .HasOne(ufr => ufr.Reply)
                .WithMany()
                .HasForeignKey(ufr => ufr.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumReply>()
                .HasOne(dfr => dfr.Reply)
                .WithMany()
                .HasForeignKey(dfr => dfr.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteForumTopic>()
                .HasOne(uft => uft.Topic)
                .WithMany()
                .HasForeignKey(uft => uft.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteForumTopic>()
                .HasOne(dft => dft.Topic)
                .WithMany()
                .HasForeignKey(dft => dft.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Forum user relationships
            modelBuilder.Entity<UserForumModerator>()
                .HasOne(ufm => ufm.User)
                .WithMany()
                .HasForeignKey(ufm => ufm.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserForumTopicFavorite>()
                .HasOne(uftf => uftf.User)
                .WithMany()
                .HasForeignKey(uftf => uftf.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserForumTopicWatch>()
                .HasOne(uftw => uftw.User)
                .WithMany()
                .HasForeignKey(uftw => uftw.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for User relationships to Forums
            modelBuilder.Entity<UserForumModerator>()
                .HasOne(ufm => ufm.Category)
                .WithMany()
                .HasForeignKey(ufm => ufm.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserForumTopicFavorite>()
                .HasOne(uftf => uftf.Topic)
                .WithMany()
                .HasForeignKey(uftf => uftf.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserForumTopicWatch>()
                .HasOne(uftw => uftw.Topic)
                .WithMany()
                .HasForeignKey(uftw => uftw.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Message and Inbox using shadow property for User
            modelBuilder.Entity<Message>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserInbox>()
                .HasOne(ui => ui.User)
                .WithMany()
                .HasForeignKey(ui => ui.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Messages
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Inbox)
                .WithMany()
                .HasForeignKey(m => m.InboxId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserInbox>()
                .HasOne(ui => ui.Inbox)
                .WithMany()
                .HasForeignKey(ui => ui.InboxId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Episode relationships
            modelBuilder.Entity<UserEpisodeFavorite>()
                .HasOne(uef => uef.Episode)
                .WithMany()
                .HasForeignKey(uef => uef.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserEpisodeRating>()
                .HasOne(uer => uer.Episode)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EpisodeReview>()
                .HasOne(er => er.Episode)
                .WithMany()
                .HasForeignKey(er => er.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EpisodeReview>()
                .HasOne(er => er.User)
                .WithMany()
                .HasForeignKey(er => er.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.EpisodeReview)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.EpisodeReview)
                .WithMany()
                .HasForeignKey(der => der.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for remaining Forum relationships
            modelBuilder.Entity<ForumTopic>()
                .HasOne(ft => ft.Category)
                .WithMany()
                .HasForeignKey(ft => ft.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumPost>()
                .HasOne(fp => fp.Topic)
                .WithMany()
                .HasForeignKey(fp => fp.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumReply>()
                .HasOne(fr => fr.Post)
                .WithMany()
                .HasForeignKey(fr => fr.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumPostHistory>()
                .HasOne(fph => fph.Post)
                .WithMany()
                .HasForeignKey(fph => fph.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ForumReplyHistory>()
                .HasOne(frh => frh.Reply)
                .WithMany()
                .HasForeignKey(frh => frh.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure cascade delete for Attachment relationships
            modelBuilder.Entity<Attachment>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Movie reviews and ratings
            modelBuilder.Entity<MovieReview>()
                .HasOne(mr => mr.Movie)
                .WithMany()
                .HasForeignKey(mr => mr.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Serie reviews and ratings
            modelBuilder.Entity<SerieReview>()
                .HasOne(sr => sr.Serie)
                .WithMany()
                .HasForeignKey(sr => sr.SerieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Season reviews and ratings
            modelBuilder.Entity<SeasonReview>()
                .HasOne(sr => sr.Season)
                .WithMany()
                .HasForeignKey(sr => sr.SeasonId)
                .OnDelete(DeleteBehavior.Cascade);

            // Actor reviews and ratings
            modelBuilder.Entity<ActorReview>()
                .HasOne(ar => ar.Actor)
                .WithMany()
                .HasForeignKey(ar => ar.ActorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Crew reviews and ratings
            modelBuilder.Entity<CrewReview>()
                .HasOne(cr => cr.Crew)
                .WithMany()
                .HasForeignKey(cr => cr.CrewId)
                .OnDelete(DeleteBehavior.Cascade);

            // Episode reviews and ratings (additional relationships)
            modelBuilder.Entity<UserEpisodeRating>()
                .HasOne(uer => uer.User)
                .WithMany()
                .HasForeignKey(uer => uer.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserEpisodeFavorite>()
                .HasOne(uef => uef.User)
                .WithMany()
                .HasForeignKey(uef => uef.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Review votes with cascade delete
            modelBuilder.Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.User)
                .WithMany()
                .HasForeignKey(uer => uer.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.User)
                .WithMany()
                .HasForeignKey(der => der.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Additional relationships for votes
            modelBuilder.Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.Episode)
                .WithMany()
                .HasForeignKey(der => der.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.Episode)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // Configure cascade delete for MovieGenre relationships
            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(mg => mg.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure relationships for reviews and votes to avoid multiple cascade paths
            modelBuilder.Entity<DownvoteActorReview>()
                .HasOne(dar => dar.Actor)
                .WithMany(a => a.DownvoteActorReviews)
                .HasForeignKey(dar => dar.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DownvoteActorReview>()
                .HasOne(dar => dar.ActorReview)
                .WithMany(ar => ar.Downvotes)
                .HasForeignKey(dar => dar.ActorReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DownvoteActorReview>()
                .HasOne(dar => dar.User)
                .WithMany()
                .HasForeignKey(dar => dar.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteActorReview>()
                .HasOne(uar => uar.Actor)
                .WithMany(a => a.UpvoteActorReviews)
                .HasForeignKey(uar => uar.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UpvoteActorReview>()
                .HasOne(uar => uar.ActorReview)
                .WithMany(ar => ar.Upvotes)
                .HasForeignKey(uar => uar.ActorReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UpvoteActorReview>()
                .HasOne(uar => uar.User)
                .WithMany()
                .HasForeignKey(uar => uar.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}