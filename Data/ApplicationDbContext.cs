using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Models.Domain;

namespace movielandia_.net_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<SerieGenre> SerieGenre { get; set; }
        public DbSet<CastMovie> CastMovie { get; set; }
        public DbSet<CastSerie> CastSerie { get; set; }
        public DbSet<CrewMovie> CrewMovie { get; set; }
        public DbSet<CrewSerie> CrewSerie { get; set; }
        public DbSet<MovieReview> MovieReview { get; set; }
        public DbSet<SerieReview> SerieReview { get; set; }
        public DbSet<SeasonReview> SeasonReview { get; set; }
        public DbSet<EpisodeReview> EpisodeReview { get; set; }
        public DbSet<ActorReview> ActorReview { get; set; }
        public DbSet<CrewReview> CrewReview { get; set; }
        public DbSet<UserMovieFavorite> UserMovieFavorite { get; set; }
        public DbSet<UserSerieFavorite> UserSerieFavorite { get; set; }
        public DbSet<UserSeasonFavorite> UserSeasonFavorite { get; set; }
        public DbSet<UserEpisodeFavorite> UserEpisodeFavorite { get; set; }
        public DbSet<UserActorFavorite> UserActorFavorite { get; set; }
        public DbSet<UserCrewFavorite> UserCrewFavorite { get; set; }
        public DbSet<UserGenreFavorite> UserGenreFavorite { get; set; }
        public DbSet<UserMovieRating> UserMovieRating { get; set; }
        public DbSet<UserSerieRating> UserSerieRating { get; set; }
        public DbSet<UserSeasonRating> UserSeasonRating { get; set; }
        public DbSet<UserEpisodeRating> UserEpisodeRating { get; set; }
        public DbSet<UserActorRating> UserActorRating { get; set; }
        public DbSet<UserCrewRating> UserCrewRating { get; set; }
        public DbSet<UpvoteMovieReview> UpvoteMovieReview { get; set; }
        public DbSet<DownvoteMovieReview> DownvoteMovieReview { get; set; }
        public DbSet<UpvoteSerieReview> UpvoteSerieReview { get; set; }
        public DbSet<DownvoteSerieReview> DownvoteSerieReview { get; set; }
        public DbSet<UpvoteSeasonReview> UpvoteSeasonReview { get; set; }
        public DbSet<DownvoteSeasonReview> DownvoteSeasonReview { get; set; }
        public DbSet<UpvoteEpisodeReview> UpvoteEpisodeReview { get; set; }
        public DbSet<DownvoteEpisodeReview> DownvoteEpisodeReview { get; set; }
        public DbSet<UpvoteActorReview> UpvoteActorReview { get; set; }
        public DbSet<DownvoteActorReview> DownvoteActorReview { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure singular table names
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Avatar>().ToTable("Avatar");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Serie>().ToTable("Serie");
            modelBuilder.Entity<Season>().ToTable("Season");
            modelBuilder.Entity<Episode>().ToTable("Episode");
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Crew>().ToTable("Crew");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<MovieGenre>().ToTable("MovieGenre");
            modelBuilder.Entity<SerieGenre>().ToTable("SerieGenre");
            modelBuilder.Entity<CastMovie>().ToTable("CastMovie");
            modelBuilder.Entity<CastSerie>().ToTable("CastSerie");
            modelBuilder.Entity<CrewMovie>().ToTable("CrewMovie");
            modelBuilder.Entity<CrewSerie>().ToTable("CrewSerie");
            modelBuilder.Entity<MovieReview>().ToTable("MovieReview");
            modelBuilder.Entity<SerieReview>().ToTable("SerieReview");
            modelBuilder.Entity<SeasonReview>().ToTable("SeasonReview");
            modelBuilder.Entity<EpisodeReview>().ToTable("EpisodeReview");
            modelBuilder.Entity<ActorReview>().ToTable("ActorReview");
            modelBuilder.Entity<CrewReview>().ToTable("CrewReview");
            modelBuilder.Entity<UserMovieFavorite>().ToTable("UserMovieFavorite");
            modelBuilder.Entity<UserSerieFavorite>().ToTable("UserSerieFavorite");
            modelBuilder.Entity<UserSeasonFavorite>().ToTable("UserSeasonFavorite");
            modelBuilder.Entity<UserEpisodeFavorite>().ToTable("UserEpisodeFavorite");
            modelBuilder.Entity<UserActorFavorite>().ToTable("UserActorFavorite");
            modelBuilder.Entity<UserCrewFavorite>().ToTable("UserCrewFavorite");
            modelBuilder.Entity<UserGenreFavorite>().ToTable("UserGenreFavorite");
            modelBuilder.Entity<UserMovieRating>().ToTable("UserMovieRating");
            modelBuilder.Entity<UserSerieRating>().ToTable("UserSerieRating");
            modelBuilder.Entity<UserSeasonRating>().ToTable("UserSeasonRating");
            modelBuilder.Entity<UserEpisodeRating>().ToTable("UserEpisodeRating");
            modelBuilder.Entity<UserActorRating>().ToTable("UserActorRating");
            modelBuilder.Entity<UserCrewRating>().ToTable("UserCrewRating");
            modelBuilder.Entity<UpvoteMovieReview>().ToTable("UpvoteMovieReview");
            modelBuilder.Entity<DownvoteMovieReview>().ToTable("DownvoteMovieReview");
            modelBuilder.Entity<UpvoteSerieReview>().ToTable("UpvoteSerieReview");
            modelBuilder.Entity<DownvoteSerieReview>().ToTable("DownvoteSerieReview");
            modelBuilder.Entity<UpvoteSeasonReview>().ToTable("UpvoteSeasonReview");
            modelBuilder.Entity<DownvoteSeasonReview>().ToTable("DownvoteSeasonReview");
            modelBuilder.Entity<UpvoteEpisodeReview>().ToTable("UpvoteEpisodeReview");
            modelBuilder.Entity<DownvoteEpisodeReview>().ToTable("DownvoteEpisodeReview");
            modelBuilder.Entity<UpvoteActorReview>().ToTable("UpvoteActorReview");
            modelBuilder.Entity<DownvoteActorReview>().ToTable("DownvoteActorReview");

            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder
                .Entity<User>()
                .HasOne(u => u.Avatar)
                .WithOne(a => a.User)
                .HasForeignKey<Avatar>(a => a.UserId);

            modelBuilder
                .Entity<UserMovieFavorite>()
                .HasIndex(umf => new { umf.UserId, umf.MovieId })
                .IsUnique();

            modelBuilder
                .Entity<UserSerieFavorite>()
                .HasIndex(usf => new { usf.UserId, usf.SerieId })
                .IsUnique();

            modelBuilder
                .Entity<Episode>()
                .HasOne(e => e.Season)
                .WithMany(s => s.Episodes)
                .HasForeignKey(e => e.SeasonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Season>()
                .HasOne(s => s.Serie)
                .WithMany(s => s.Seasons)
                .HasForeignKey(s => s.SerieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumPost>()
                .HasOne(fp => fp.User)
                .WithMany()
                .HasForeignKey(fp => fp.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<ForumReply>()
                .HasOne(fr => fr.User)
                .WithMany()
                .HasForeignKey(fr => fr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<ForumTopic>()
                .HasOne(ft => ft.User)
                .WithMany()
                .HasForeignKey(ft => ft.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteForumPost>()
                .HasOne(ufp => ufp.User)
                .WithMany()
                .HasForeignKey(ufp => ufp.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteForumPost>()
                .HasOne(dfp => dfp.User)
                .WithMany()
                .HasForeignKey(dfp => dfp.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteForumReply>()
                .HasOne(ufr => ufr.User)
                .WithMany()
                .HasForeignKey(ufr => ufr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteForumReply>()
                .HasOne(dfr => dfr.User)
                .WithMany()
                .HasForeignKey(dfr => dfr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteForumTopic>()
                .HasOne(uft => uft.User)
                .WithMany()
                .HasForeignKey(uft => uft.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteForumTopic>()
                .HasOne(dft => dft.User)
                .WithMany()
                .HasForeignKey(dft => dft.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteForumPost>()
                .HasOne(ufp => ufp.Post)
                .WithMany()
                .HasForeignKey(ufp => ufp.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteForumPost>()
                .HasOne(dfp => dfp.Post)
                .WithMany()
                .HasForeignKey(dfp => dfp.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteForumReply>()
                .HasOne(ufr => ufr.Reply)
                .WithMany()
                .HasForeignKey(ufr => ufr.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteForumReply>()
                .HasOne(dfr => dfr.Reply)
                .WithMany()
                .HasForeignKey(dfr => dfr.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteForumTopic>()
                .HasOne(uft => uft.Topic)
                .WithMany()
                .HasForeignKey(uft => uft.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteForumTopic>()
                .HasOne(dft => dft.Topic)
                .WithMany()
                .HasForeignKey(dft => dft.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumModerator>()
                .HasOne(ufm => ufm.User)
                .WithMany()
                .HasForeignKey(ufm => ufm.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumTopicFavorite>()
                .HasOne(uftf => uftf.User)
                .WithMany()
                .HasForeignKey(uftf => uftf.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumTopicWatch>()
                .HasOne(uftw => uftw.User)
                .WithMany()
                .HasForeignKey(uftw => uftw.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumModerator>()
                .HasOne(ufm => ufm.Category)
                .WithMany()
                .HasForeignKey(ufm => ufm.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumTopicFavorite>()
                .HasOne(uftf => uftf.Topic)
                .WithMany()
                .HasForeignKey(uftf => uftf.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserForumTopicWatch>()
                .HasOne(uftw => uftw.Topic)
                .WithMany()
                .HasForeignKey(uftw => uftw.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Message>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserInbox>()
                .HasOne(ui => ui.User)
                .WithMany()
                .HasForeignKey(ui => ui.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Message>()
                .HasOne(m => m.Inbox)
                .WithMany()
                .HasForeignKey(m => m.InboxId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany()
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UserInbox>()
                .HasOne(ui => ui.Inbox)
                .WithMany()
                .HasForeignKey(ui => ui.InboxId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserEpisodeFavorite>()
                .HasOne(uef => uef.Episode)
                .WithMany()
                .HasForeignKey(uef => uef.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserEpisodeRating>()
                .HasOne(uer => uer.Episode)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<EpisodeReview>()
                .HasOne(er => er.Episode)
                .WithMany()
                .HasForeignKey(er => er.EpisodeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<EpisodeReview>()
                .HasOne(er => er.User)
                .WithMany(u => u.EpisodeReviews)
                .HasForeignKey(er => er.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.EpisodeReview)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.EpisodeReview)
                .WithMany()
                .HasForeignKey(der => der.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumTopic>()
                .HasOne(ft => ft.Category)
                .WithMany()
                .HasForeignKey(ft => ft.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumPost>()
                .HasOne(fp => fp.Topic)
                .WithMany()
                .HasForeignKey(fp => fp.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumReply>()
                .HasOne(fr => fr.Post)
                .WithMany()
                .HasForeignKey(fr => fr.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumPostHistory>()
                .HasOne(fph => fph.Post)
                .WithMany()
                .HasForeignKey(fph => fph.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ForumReplyHistory>()
                .HasOne(frh => frh.Reply)
                .WithMany()
                .HasForeignKey(frh => frh.ReplyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Attachment>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<MovieReview>()
                .HasOne(mr => mr.Movie)
                .WithMany()
                .HasForeignKey(mr => mr.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<MovieReview>()
                .HasOne(mr => mr.User)
                .WithMany(u => u.MovieReviews)
                .HasForeignKey(mr => mr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<SerieReview>()
                .HasOne(sr => sr.Serie)
                .WithMany()
                .HasForeignKey(sr => sr.SerieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<SerieReview>()
                .HasOne(sr => sr.User)
                .WithMany(u => u.SerieReviews)
                .HasForeignKey(sr => sr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<SeasonReview>()
                .HasOne(sr => sr.Season)
                .WithMany()
                .HasForeignKey(sr => sr.SeasonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<SeasonReview>()
                .HasOne(sr => sr.User)
                .WithMany(u => u.SeasonReviews)
                .HasForeignKey(sr => sr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<ActorReview>()
                .HasOne(ar => ar.Actor)
                .WithMany()
                .HasForeignKey(ar => ar.ActorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<ActorReview>()
                .HasOne(ar => ar.User)
                .WithMany(u => u.ActorReviews)
                .HasForeignKey(ar => ar.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<CrewReview>()
                .HasOne(cr => cr.Crew)
                .WithMany()
                .HasForeignKey(cr => cr.CrewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<CrewReview>()
                .HasOne(cr => cr.User)
                .WithMany(u => u.CrewReviews)
                .HasForeignKey(cr => cr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UserEpisodeRating>()
                .HasOne(uer => uer.User)
                .WithMany()
                .HasForeignKey(uer => uer.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UserEpisodeFavorite>()
                .HasOne(uef => uef.User)
                .WithMany()
                .HasForeignKey(uef => uef.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.User)
                .WithMany()
                .HasForeignKey(uer => uer.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.User)
                .WithMany()
                .HasForeignKey(der => der.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.Episode)
                .WithMany()
                .HasForeignKey(der => der.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.Episode)
                .WithMany()
                .HasForeignKey(uer => uer.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<MovieGenre>()
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<MovieGenre>()
                .HasOne(mg => mg.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(mg => mg.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteActorReview>()
                .HasOne(dar => dar.Actor)
                .WithMany(a => a.DownvoteActorReviews)
                .HasForeignKey(dar => dar.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteActorReview>()
                .HasOne(dar => dar.ActorReview)
                .WithMany(ar => ar.Downvotes)
                .HasForeignKey(dar => dar.ActorReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteActorReview>()
                .HasOne(dar => dar.User)
                .WithMany()
                .HasForeignKey(dar => dar.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteActorReview>()
                .HasOne(uar => uar.Actor)
                .WithMany(a => a.UpvoteActorReviews)
                .HasForeignKey(uar => uar.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteActorReview>()
                .HasOne(uar => uar.ActorReview)
                .WithMany(ar => ar.Upvotes)
                .HasForeignKey(uar => uar.ActorReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteActorReview>()
                .HasOne(uar => uar.User)
                .WithMany()
                .HasForeignKey(uar => uar.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteMovieReview>()
                .HasOne(umr => umr.Movie)
                .WithMany(m => m.UpvoteMovieReviews)
                .HasForeignKey(umr => umr.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteMovieReview>()
                .HasOne(umr => umr.MovieReview)
                .WithMany(mr => mr.Upvotes)
                .HasForeignKey(umr => umr.MovieReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteMovieReview>()
                .HasOne(umr => umr.User)
                .WithMany()
                .HasForeignKey(umr => umr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteMovieReview>()
                .HasOne(dmr => dmr.Movie)
                .WithMany(m => m.DownvoteMovieReviews)
                .HasForeignKey(dmr => dmr.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteMovieReview>()
                .HasOne(dmr => dmr.MovieReview)
                .WithMany(mr => mr.Downvotes)
                .HasForeignKey(dmr => dmr.MovieReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteMovieReview>()
                .HasOne(dmr => dmr.User)
                .WithMany()
                .HasForeignKey(dmr => dmr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteSerieReview>()
                .HasOne(usr => usr.Serie)
                .WithMany(s => s.UpvoteSerieReviews)
                .HasForeignKey(usr => usr.SerieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteSerieReview>()
                .HasOne(usr => usr.SerieReview)
                .WithMany(sr => sr.Upvotes)
                .HasForeignKey(usr => usr.SerieReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteSerieReview>()
                .HasOne(usr => usr.User)
                .WithMany()
                .HasForeignKey(usr => usr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteSerieReview>()
                .HasOne(dsr => dsr.Serie)
                .WithMany(s => s.DownvoteSerieReviews)
                .HasForeignKey(dsr => dsr.SerieId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteSerieReview>()
                .HasOne(dsr => dsr.SerieReview)
                .WithMany(sr => sr.Downvotes)
                .HasForeignKey(dsr => dsr.SerieReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteSerieReview>()
                .HasOne(dsr => dsr.User)
                .WithMany()
                .HasForeignKey(dsr => dsr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteSeasonReview>()
                .HasOne(usr => usr.Season)
                .WithMany(s => s.UpvoteSeasonReviews)
                .HasForeignKey(usr => usr.SeasonId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteSeasonReview>()
                .HasOne(usr => usr.SeasonReview)
                .WithMany(sr => sr.Upvotes)
                .HasForeignKey(usr => usr.SeasonReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteSeasonReview>()
                .HasOne(usr => usr.User)
                .WithMany()
                .HasForeignKey(usr => usr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteSeasonReview>()
                .HasOne(dsr => dsr.Season)
                .WithMany(s => s.DownvoteSeasonReviews)
                .HasForeignKey(dsr => dsr.SeasonId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteSeasonReview>()
                .HasOne(dsr => dsr.SeasonReview)
                .WithMany(sr => sr.Downvotes)
                .HasForeignKey(dsr => dsr.SeasonReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteSeasonReview>()
                .HasOne(dsr => dsr.User)
                .WithMany()
                .HasForeignKey(dsr => dsr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.Episode)
                .WithMany(e => e.UpvoteEpisodeReviews)
                .HasForeignKey(uer => uer.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.EpisodeReview)
                .WithMany(er => er.Upvotes)
                .HasForeignKey(uer => uer.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteEpisodeReview>()
                .HasOne(uer => uer.User)
                .WithMany()
                .HasForeignKey(uer => uer.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.Episode)
                .WithMany(e => e.DownvoteEpisodeReviews)
                .HasForeignKey(der => der.EpisodeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.EpisodeReview)
                .WithMany(er => er.Downvotes)
                .HasForeignKey(der => der.EpisodeReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteEpisodeReview>()
                .HasOne(der => der.User)
                .WithMany()
                .HasForeignKey(der => der.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<UpvoteCrewReview>()
                .HasOne(ucr => ucr.Crew)
                .WithMany(c => c.UpvoteCrewReviews)
                .HasForeignKey(ucr => ucr.CrewId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<UpvoteCrewReview>()
                .HasOne(ucr => ucr.CrewReview)
                .WithMany(cr => cr.Upvotes)
                .HasForeignKey(ucr => ucr.CrewReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<UpvoteCrewReview>()
                .HasOne(ucr => ucr.User)
                .WithMany()
                .HasForeignKey(ucr => ucr.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<DownvoteCrewReview>()
                .HasOne(dcr => dcr.Crew)
                .WithMany(c => c.DownvoteCrewReviews)
                .HasForeignKey(dcr => dcr.CrewId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder
                .Entity<DownvoteCrewReview>()
                .HasOne(dcr => dcr.CrewReview)
                .WithMany(cr => cr.Downvotes)
                .HasForeignKey(dcr => dcr.CrewReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<DownvoteCrewReview>()
                .HasOne(dcr => dcr.User)
                .WithMany()
                .HasForeignKey(dcr => dcr.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }
    }
}
