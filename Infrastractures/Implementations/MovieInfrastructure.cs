using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Infrastructures.Interfaces;
using movielandia_.net_api.Models.Domain;
using movielandia_.net_api.Repositories.Interfaces;

namespace movielandia_.net_api.Infrastructures.Implementations
{
    public class MovieInfrastructure : IMovieInfrastructure
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMemoryCache _cache;
        private static readonly TimeSpan CacheDuration = TimeSpan.FromDays(1);

        public MovieInfrastructure(IMovieRepository movieRepository, IMemoryCache cache)
        {
            _movieRepository = movieRepository;
            _cache = cache;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        )
        {
            var (movies, totalCount) = await _movieRepository.GetMoviesWithFiltersAsync(filter);

            // Get all movie IDs to fetch ratings and bookmarks in batch
            var movieIds = movies.Select(m => m.Id).ToList();

            // Get ratings for all movies in one go
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

            // Process each movie to add extra data (ratings, bookmarks)
            List<MovieDTO> result = new List<MovieDTO>();

            foreach (var movie in movies)
            {
                var movieDTO = MapToDTO(movie);

                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDTO.AverageRating = ratingInfo.AverageRating;
                    movieDTO.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (filter.UserId.HasValue)
                {
                    movieDTO.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                        movie.Id,
                        filter.UserId.Value
                    );
                }

                result.Add(movieDTO);
            }

            return (result, totalCount);
        }

        public async Task<IEnumerable<MovieDTO>> GetMoviesForHomePageAsync()
        {
            // Try to get from cache
            if (!_cache.TryGetValue("HomePageMovies", out List<MovieDTO>? cachedMovies))
            {
                var movies = await _movieRepository.GetMoviesForHomePageAsync();

                // Get ratings for all movies
                var movieIds = movies.Select(m => m.Id);
                var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

                // Map to DTOs and add rating info
                cachedMovies = movies
                    .Select(m =>
                    {
                        var dto = MapToDTO(m);
                        if (ratingsByMovieId.TryGetValue(m.Id, out var ratingInfo))
                        {
                            dto.AverageRating = ratingInfo.AverageRating;
                            dto.TotalReviews = ratingInfo.TotalReviews;
                        }
                        return dto;
                    })
                    .ToList();

                // Cache the result
                _cache.Set("HomePageMovies", cachedMovies, CacheDuration);
            }

            return cachedMovies ?? new List<MovieDTO>();
        }

        public async Task<MovieDetailDTO> GetMovieByIdAsync(int id, MovieQueryParameters parameters)
        {
            // Get movie with all necessary details
            var movie = await _movieRepository.GetMovieByIdWithDetailsAsync(id, parameters);

            if (movie == null)
            {
                throw new KeyNotFoundException("Movie not found.");
            }

            // Map to detail DTO
            var movieDetail = MapToDetailDTO(movie);

            // Add total counts
            var totalCast = movie.Cast?.Count() ?? 0;
            var totalCrew = movie.Crew?.Count() ?? 0;
            movieDetail.TotalCast = totalCast;
            movieDetail.TotalCrew = totalCrew;

            // Calculate average rating
            var (averageRating, totalReviews) = await _movieRepository.CalculateMovieRatingAsync(
                id
            );
            movieDetail.AverageRating = averageRating;
            movieDetail.TotalReviews = totalReviews;

            // Check if movie is bookmarked and reviewed by user
            if (parameters.UserId.HasValue)
            {
                movieDetail.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                    id,
                    parameters.UserId.Value
                );
                movieDetail.IsReviewed = await _movieRepository.IsMovieReviewedByUserAsync(
                    id,
                    parameters.UserId.Value
                );

                // Process reviews to add upvote/downvote status
                if (movieDetail.Reviews != null)
                {
                    foreach (var review in movieDetail.Reviews)
                    {
                        // Check if the user has upvoted/downvoted each review
                        var upvote =
                            movie
                                .Reviews.FirstOrDefault(r => r.Id == review.Id)
                                ?.Upvotes?.Any(u => u.UserId == parameters.UserId) ?? false;

                        var downvote =
                            movie
                                .Reviews.FirstOrDefault(r => r.Id == review.Id)
                                ?.Downvotes?.Any(d => d.UserId == parameters.UserId) ?? false;

                        review.IsUpvoted = upvote;
                        review.IsDownvoted = downvote;
                    }
                }
            }

            return movieDetail;
        }

        public async Task<MovieDetailDTO> GetMovieByTitleAsync(
            string title,
            MovieQueryParameters parameters
        )
        {
            // Get movie with all necessary details
            var movie = await _movieRepository.GetMovieByTitleWithDetailsAsync(title, parameters);

            if (movie == null)
            {
                return null;
            }

            // Map to detail DTO
            var movieDetail = MapToDetailDTO(movie);

            // Calculate average rating
            var (averageRating, totalReviews) = await _movieRepository.CalculateMovieRatingAsync(
                movie.Id
            );
            movieDetail.AverageRating = averageRating;
            movieDetail.TotalReviews = totalReviews;

            // Check if movie is bookmarked and reviewed by user
            if (parameters.UserId.HasValue)
            {
                movieDetail.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                    movie.Id,
                    parameters.UserId.Value
                );
                movieDetail.IsReviewed = await _movieRepository.IsMovieReviewedByUserAsync(
                    movie.Id,
                    parameters.UserId.Value
                );

                // Process reviews to add upvote/downvote status
                if (movieDetail.Reviews != null)
                {
                    foreach (var review in movieDetail.Reviews)
                    {
                        // Check if the user has upvoted/downvoted each review
                        var upvote =
                            movie
                                .Reviews.FirstOrDefault(r => r.Id == review.Id)
                                ?.Upvotes?.Any(u => u.UserId == parameters.UserId) ?? false;

                        var downvote =
                            movie
                                .Reviews.FirstOrDefault(r => r.Id == review.Id)
                                ?.Downvotes?.Any(d => d.UserId == parameters.UserId) ?? false;

                        review.IsUpvoted = upvote;
                        review.IsDownvoted = downvote;
                    }
                }
            }

            return movieDetail;
        }

        public async Task<IEnumerable<MovieDTO>> GetLatestMoviesAsync(int? userId = null)
        {
            // Try to get from cache if no userId provided
            string cacheKey = "LatestMovies";
            if (userId == null && _cache.TryGetValue(cacheKey, out List<MovieDTO> cachedMovies))
            {
                return cachedMovies;
            }

            var movies = await _movieRepository.GetLatestMoviesAsync(userId);

            // Get ratings for all movies
            var movieIds = movies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

            // Map to DTOs and add rating info
            List<MovieDTO> result = new List<MovieDTO>();

            foreach (var movie in movies)
            {
                var movieDTO = MapToDTO(movie);

                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDTO.AverageRating = ratingInfo.AverageRating;
                    movieDTO.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (userId.HasValue)
                {
                    movieDTO.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                        movie.Id,
                        userId.Value
                    );
                }

                result.Add(movieDTO);
            }

            // Cache only if no userId provided (since results are personalized with userId)
            if (userId == null)
            {
                _cache.Set(cacheKey, result, CacheDuration);
            }

            return result;
        }

        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        )
        {
            // Use cache only if no user id (since results could be personalized)
            string cacheKey = $"RelatedMovies_{id}_{page}_{perPage}";
            if (
                userId == null
                && _cache.TryGetValue(
                    cacheKey,
                    out (List<MovieDTO> Movies, int TotalCount) cachedResult
                )
            )
            {
                return cachedResult;
            }

            var (relatedMovies, totalCount) = await _movieRepository.GetRelatedMoviesAsync(
                id,
                userId,
                page,
                perPage
            );

            if (relatedMovies == null || !relatedMovies.Any())
            {
                return (new List<MovieDTO>(), 0);
            }

            // Get ratings for all movies
            var movieIds = relatedMovies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

            // Map to DTOs and add rating info
            List<MovieDTO> result = new List<MovieDTO>();

            foreach (var movie in relatedMovies)
            {
                var movieDTO = MapToDTO(movie);

                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDTO.AverageRating = ratingInfo.AverageRating;
                    movieDTO.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (userId.HasValue)
                {
                    movieDTO.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                        movie.Id,
                        userId.Value
                    );
                }

                result.Add(movieDTO);
            }

            // Cache only if no userId provided (since results are personalized with userId)
            if (userId == null)
            {
                _cache.Set(cacheKey, (result, totalCount), CacheDuration);
            }

            return (result, totalCount);
        }

        public async Task<int> GetMoviesTotalCountAsync()
        {
            // Try to get from cache
            if (_cache.TryGetValue("MoviesTotalCount", out int cachedCount))
            {
                return cachedCount;
            }

            int count = await _movieRepository.GetMoviesTotalCountAsync();

            // Cache the result
            _cache.Set("MoviesTotalCount", count, CacheDuration);

            return count;
        }

        public async Task<MovieDTO> CreateMovieAsync(MovieDTO movieDTO)
        {
            // Map DTO to entity
            var movie = new Movie
            {
                Title = movieDTO.Title,
                PhotoSrc = movieDTO.PhotoSrc,
                PhotoSrcProd = movieDTO.PhotoSrcProd,
                TrailerSrc = movieDTO.TrailerSrc,
                Duration = movieDTO.Duration,
                RatingImdb = movieDTO.RatingImdb,
                DateAired = movieDTO.DateAired,
                Description = movieDTO.Description,
            };

            // Add movie to repository
            var createdMovie = await _movieRepository.AddAsync(movie);

            // Invalidate related cache entries
            InvalidateMovieCache();

            return MapToDTO(createdMovie);
        }

        public async Task<MovieDTO> UpdateMovieAsync(int id, MovieDTO movieDTO)
        {
            // Find existing movie
            var existingMovie = await _movieRepository.GetByIdAsync(id);

            if (existingMovie == null)
            {
                return null;
            }

            // Update properties
            existingMovie.Title = movieDTO.Title;
            existingMovie.PhotoSrc = movieDTO.PhotoSrc;
            existingMovie.PhotoSrcProd = movieDTO.PhotoSrcProd;
            existingMovie.TrailerSrc = movieDTO.TrailerSrc;
            existingMovie.Duration = movieDTO.Duration;
            existingMovie.RatingImdb = movieDTO.RatingImdb;
            existingMovie.DateAired = movieDTO.DateAired;
            existingMovie.Description = movieDTO.Description;

            // Update movie
            await _movieRepository.UpdateAsync(existingMovie);

            // Invalidate related cache entries
            InvalidateMovieCache();

            return MapToDTO(existingMovie);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);

            if (movie == null)
            {
                return false;
            }

            await _movieRepository.DeleteAsync(movie.Id);

            // Invalidate related cache entries
            InvalidateMovieCache();

            return true;
        }

        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        )
        {
            var (movies, totalCount) = await _movieRepository.SearchMoviesByTitleAsync(
                title,
                filter
            );

            if (movies == null || !movies.Any())
            {
                return (new List<MovieDTO>(), 0);
            }

            // Get ratings for all movies
            var movieIds = movies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

            // Map to DTOs and add rating info
            List<MovieDTO> result = new List<MovieDTO>();

            foreach (var movie in movies)
            {
                var movieDTO = MapToDTO(movie);

                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDTO.AverageRating = ratingInfo.AverageRating;
                    movieDTO.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (filter.UserId.HasValue)
                {
                    movieDTO.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(
                        movie.Id,
                        filter.UserId.Value
                    );
                }

                result.Add(movieDTO);
            }

            return (result, totalCount);
        }

        #region Helper Methods

        private MovieDTO MapToDTO(Movie movie)
        {
            if (movie == null)
            {
                return null;
            }

            return new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                PhotoSrc = movie.PhotoSrc,
                PhotoSrcProd = movie.PhotoSrcProd,
                TrailerSrc = movie.TrailerSrc,
                Duration = movie.Duration,
                RatingImdb = movie.RatingImdb,
                DateAired = movie.DateAired,
                Description = movie.Description,
            };
        }

        private MovieDetailDTO MapToDetailDTO(Movie movie)
        {
            if (movie == null)
                return null;

            var dto = new MovieDetailDTO
            {
                // Base properties from MovieDTO
                Id = movie.Id,
                Title = movie.Title,
                PhotoSrc = movie.PhotoSrc,
                PhotoSrcProd = movie.PhotoSrcProd,
                TrailerSrc = movie.TrailerSrc,
                Duration = movie.Duration,
                RatingImdb = movie.RatingImdb,
                DateAired = movie.DateAired,
                Description = movie.Description,

                // Related collections
                Genres = movie.Genres?.Select(mg => new MovieGenreDTO
                {
                    Id = mg.Id,
                    GenreId = mg.GenreId,
                    Name = mg.Genre?.Name,
                }),

                Cast = movie.Cast?.Select(cm => new MovieCastDTO
                {
                    Id = cm.Id,
                    ActorId = cm.ActorId,
                    Fullname = cm.Actor?.Fullname,
                    PhotoSrc = cm.Actor?.PhotoSrc,
                }),

                Crew = movie.Crew?.Select(cm => new MovieCrewDTO
                {
                    Id = cm.Id,
                    CrewId = cm.CrewId,
                    Fullname = cm.Crew?.Fullname,
                    Role = cm.Crew?.Role,
                    PhotoSrc = cm.Crew?.PhotoSrc,
                }),

                Reviews = movie.Reviews?.Select(r => new MovieReviewDTO
                {
                    Id = r.Id,
                    Content = r.Content,
                    Rating = r.Rating,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt,
                    UserId = r.UserId,
                    UserName = r.User?.UserName,
                    UpvotesCount = r.Upvotes?.Count ?? 0,
                    DownvotesCount = r.Downvotes?.Count ?? 0,
                }),
            };

            return dto;
        }

        private void InvalidateMovieCache()
        {
            // Invalidate all movie-related cache entries
            _cache.Remove("HomePageMovies");
            _cache.Remove("MoviesTotalCount");

            // For RelatedMovies, we'd need to iterate through a pattern of keys
            // This is a simplification and would need to be expanded in a real system
        }

        #endregion
    }
}
