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
        public virtual Avatar Avatar { get; set; }
        public virtual ICollection<UserMovieFavorite> FavMovies { get; set; }
        public virtual ICollection<UserSerieFavorite> FavSeries { get; set; }
        public virtual ICollection<UserGenreFavorite> FavGenres { get; set; }
        public virtual ICollection<UserSeasonFavorite> FavSeasons { get; set; }
        public virtual ICollection<UserEpisodeFavorite> FavEpisodes { get; set; }
        public virtual ICollection<UserActorFavorite> FavActors { get; set; }
        public virtual ICollection<UserCrewFavorite> FavCrew { get; set; }
        public virtual ICollection<UserMovieRating> RatingsInMovie { get; set; }
        public virtual ICollection<UserSerieRating> RatingsInSerie { get; set; }
        public virtual ICollection<UserSeasonRating> RatingsInSeason { get; set; }
        public virtual ICollection<UserEpisodeRating> RatingsInEpisode { get; set; }
        public virtual ICollection<UserActorRating> RatingsInActor { get; set; }
        public virtual ICollection<UserCrewRating> RatingsInCrew { get; set; }
        public virtual ICollection<MovieReview> MovieReviews { get; set; }
        public virtual ICollection<SerieReview> SerieReviews { get; set; }
        public virtual ICollection<SeasonReview> SeasonReviews { get; set; }
        public virtual ICollection<EpisodeReview> EpisodeReviews { get; set; }
        public virtual ICollection<ActorReview> ActorReviews { get; set; }
        public virtual ICollection<CrewReview> CrewReviews { get; set; }

        public User()
        {
            UserName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Bio = string.Empty;
            Avatar = new Avatar { PhotoSrc = string.Empty, User = this };
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
        }
    }
}
