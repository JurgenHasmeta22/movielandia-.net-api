using System;
using System.Collections.Generic;
using movielandia_.net_api.Enums;

namespace movielandia_.net_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Role { get; set; } = UserType.User;
        public string Bio { get; set; }
        public int? Age { get; set; }
        public DateTime? Birthday { get; set; }
        public Gender Gender { get; set; } = Gender.Male;
        public string Phone { get; set; } = "+11234567890";
        public string CountryFrom { get; set; } = "United States";
        public bool Active { get; set; } = false;
        public bool CanResetPassword { get; set; } = false;
        public bool Subscribed { get; set; } = false;

        // Navigation properties for relationships
        // Profile
        public virtual Avatar? Avatar { get; set; }

        // Favorites
        public virtual ICollection<UserMovieFavorite> FavMovies { get; set; }
        public virtual ICollection<UserSerieFavorite> FavSeries { get; set; }
        public virtual ICollection<UserGenreFavorite> FavGenres { get; set; }
        public virtual ICollection<UserSeasonFavorite> FavSeasons { get; set; }
        public virtual ICollection<UserEpisodeFavorite> FavEpisodes { get; set; }
        public virtual ICollection<UserActorFavorite> FavActors { get; set; }
        public virtual ICollection<UserCrewFavorite> FavCrew { get; set; }

        // Ratings
        public virtual ICollection<UserMovieRating> RatingsInMovie { get; set; }
        public virtual ICollection<UserSerieRating> RatingsInSerie { get; set; }
        public virtual ICollection<UserSeasonRating> RatingsInSeason { get; set; }
        public virtual ICollection<UserEpisodeRating> RatingsInEpisode { get; set; }
        public virtual ICollection<UserActorRating> RatingsInActor { get; set; }
        public virtual ICollection<UserCrewRating> RatingsInCrew { get; set; }

        // Reviews
        public virtual ICollection<MovieReview> MovieReviews { get; set; }
        public virtual ICollection<SerieReview> SerieReviews { get; set; }
        public virtual ICollection<SeasonReview> SeasonReviews { get; set; }
        public virtual ICollection<EpisodeReview> EpisodeReviews { get; set; }
        public virtual ICollection<ActorReview> ActorReviews { get; set; }
        public virtual ICollection<CrewReview> CrewReviews { get; set; }

        // Forum Interactions
        public virtual ICollection<ForumTopic> Topics { get; set; }
        public virtual ICollection<ForumPost> Posts { get; set; }
        public virtual ICollection<ForumPost> PostsAnswered { get; set; }
        public virtual ICollection<ForumPost> PostsDeleted { get; set; }
        public virtual ICollection<ForumReply> Replies { get; set; }
        public virtual ICollection<UserForumTopicFavorite> FavTopics { get; set; }
        public virtual ICollection<UserForumTopicWatch> WatchedTopics { get; set; }
        public virtual ICollection<UserForumModerator> ModeratedCategories { get; set; }

        // Lists
        public virtual ICollection<List> Lists { get; set; }

        // Content Management
        public virtual ICollection<ContentHistory> ContentHistories { get; set; }
        public virtual ICollection<ContentChangeLog> ContentChangeLogs { get; set; }

        // Social Features
        public virtual ICollection<UserFollow> Followers { get; set; }
        public virtual ICollection<UserFollow> Following { get; set; }
        public virtual ICollection<UserBlock> BlockedUsers { get; set; }
        public virtual ICollection<UserBlock> BlockedByUsers { get; set; }
        public virtual ICollection<UserMute> MutedUsers { get; set; }
        public virtual ICollection<UserMute> MutedByModerators { get; set; }
        public virtual ICollection<UserContact> Contacts { get; set; }
        public virtual ICollection<UserActivity> Activities { get; set; }

        // Notifications & Messages
        public virtual UserNotificationSettings? NotificationSettings { get; set; }
        public virtual ICollection<NotificationUser> Notifications { get; set; }
        public virtual ICollection<UserInbox> Inboxes { get; set; }

        // Authentication
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

        // Moderation
        public virtual ICollection<UserReport> ReportsSubmitted { get; set; }
        public virtual ICollection<UserReport> ReportsReceived { get; set; }
        public virtual ICollection<UserReport> ReportsModerated { get; set; }
        public virtual ICollection<UserBadge> Badges { get; set; }
        public virtual ForumUserStats? ForumStats { get; set; }

        public User()
        {
            UserName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Bio = string.Empty;
            CountryFrom = "United States";
            Phone = "+11234567890";

            // Initialize collections
            FavMovies = new HashSet<UserMovieFavorite>();
            FavSeries = new HashSet<UserSerieFavorite>();
            FavGenres = new HashSet<UserGenreFavorite>();
            FavSeasons = new HashSet<UserSeasonFavorite>();
            FavEpisodes = new HashSet<UserEpisodeFavorite>();
            FavActors = new HashSet<UserActorFavorite>();
            FavCrew = new HashSet<UserCrewFavorite>();
            
            RatingsInMovie = new HashSet<UserMovieRating>();
            RatingsInSerie = new HashSet<UserSerieRating>();
            RatingsInSeason = new HashSet<UserSeasonRating>();
            RatingsInEpisode = new HashSet<UserEpisodeRating>();
            RatingsInActor = new HashSet<UserActorRating>();
            RatingsInCrew = new HashSet<UserCrewRating>();
            
            MovieReviews = new HashSet<MovieReview>();
            SerieReviews = new HashSet<SerieReview>();
            SeasonReviews = new HashSet<SeasonReview>();
            EpisodeReviews = new HashSet<EpisodeReview>();
            ActorReviews = new HashSet<ActorReview>();
            CrewReviews = new HashSet<CrewReview>();
            
            Topics = new HashSet<ForumTopic>();
            Posts = new HashSet<ForumPost>();
            PostsAnswered = new HashSet<ForumPost>();
            PostsDeleted = new HashSet<ForumPost>();
            Replies = new HashSet<ForumReply>();
            FavTopics = new HashSet<UserForumTopicFavorite>();
            WatchedTopics = new HashSet<UserForumTopicWatch>();
            ModeratedCategories = new HashSet<UserForumModerator>();
            
            Lists = new HashSet<List>();
            ContentHistories = new HashSet<ContentHistory>();
            ContentChangeLogs = new HashSet<ContentChangeLog>();
            
            Followers = new HashSet<UserFollow>();
            Following = new HashSet<UserFollow>();
            BlockedUsers = new HashSet<UserBlock>();
            BlockedByUsers = new HashSet<UserBlock>();
            MutedUsers = new HashSet<UserMute>();
            MutedByModerators = new HashSet<UserMute>();
            Contacts = new HashSet<UserContact>();
            Activities = new HashSet<UserActivity>();
            
            Notifications = new HashSet<NotificationUser>();
            Inboxes = new HashSet<UserInbox>();
            
            Accounts = new HashSet<Account>();
            Sessions = new HashSet<Session>();
            
            ReportsSubmitted = new HashSet<UserReport>();
            ReportsReceived = new HashSet<UserReport>();
            ReportsModerated = new HashSet<UserReport>();
            Badges = new HashSet<UserBadge>();
        }
    }
}
