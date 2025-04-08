using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using movielandia_.net_api.Models.Domain;
using movielandia_.net_api.Models.DTOs;
using movielandia_.net_api.Repositories.Interfaces;
using movielandia_.net_api.Services.Interfaces;

namespace movielandia_.net_api.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMemoryCache _cache;
        private static readonly TimeSpan CacheDuration = TimeSpan.FromDays(1);

        public MovieService(IMovieRepository movieRepository, IMemoryCache cache)
        {
            _movieRepository = movieRepository;
            _cache = cache;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public async Task<(IEnumerable<MovieDto> Movies, int TotalCount)> GetMoviesWithFiltersAsync(MovieFilterDto filter)
        {
            var (movies, totalCount) = await _movieRepository.GetMoviesWithFiltersAsync(filter);
            
            // Get all movie IDs to fetch ratings and bookmarks in batch
            var movieIds = movies.Select(m => m.Id).ToList();

            // Get ratings for all movies in one go
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);

            // Process each movie to add extra data (ratings, bookmarks)
            List<MovieDto> result = new List<MovieDto>();
            
            foreach (var movie in movies)
            {
                var movieDto = MapToDto(movie);
                
                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDto.AverageRating = ratingInfo.AverageRating;
                    movieDto.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (filter.UserId.HasValue)
                {
                    movieDto.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(movie.Id, filter.UserId.Value);
                }

                result.Add(movieDto);
            }

            return (result, totalCount);
        }

        public async Task<IEnumerable<MovieDto>> GetMoviesForHomePageAsync()
        {
            // Try to get from cache
            if (!_cache.TryGetValue("HomePageMovies", out List<MovieDto> cachedMovies))
            {
                var movies = await _movieRepository.GetMoviesForHomePageAsync();
                
                // Get ratings for all movies
                var movieIds = movies.Select(m => m.Id);
                var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);
                
                // Map to DTOs and add rating info
                cachedMovies = movies.Select(m => 
                {
                    var dto = MapToDto(m);
                    if (ratingsByMovieId.TryGetValue(m.Id, out var ratingInfo))
                    {
                        dto.AverageRating = ratingInfo.AverageRating;
                        dto.TotalReviews = ratingInfo.TotalReviews;
                    }
                    return dto;
                }).ToList();
                
                // Cache the result
                _cache.Set("HomePageMovies", cachedMovies, CacheDuration);
            }
            
            return cachedMovies;
        }

        public async Task<MovieDetailDto> GetMovieByIdAsync(int id, MovieQueryParameters parameters)
        {
            // Get movie with all necessary details
            var movie = await _movieRepository.GetMovieByIdWithDetailsAsync(id, parameters);
            
            if (movie == null)
            {
                return null;
            }

            // Map to detail DTO
            var movieDetail = MapToDetailDto(movie);

            // Add total counts
            var totalCast = movie.Cast?.Count() ?? 0;
            var totalCrew = movie.Crew?.Count() ?? 0;
            movieDetail.TotalCast = totalCast;
            movieDetail.TotalCrew = totalCrew;

            // Calculate average rating
            var (averageRating, totalReviews) = await _movieRepository.CalculateMovieRatingAsync(id);
            movieDetail.AverageRating = averageRating;
            movieDetail.TotalReviews = totalReviews;

            // Check if movie is bookmarked and reviewed by user
            if (parameters.UserId.HasValue)
            {
                movieDetail.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(id, parameters.UserId.Value);
                movieDetail.IsReviewed = await _movieRepository.IsMovieReviewedByUserAsync(id, parameters.UserId.Value);

                // Process reviews to add upvote/downvote status
                if (movieDetail.Reviews != null)
                {
                    foreach (var review in movieDetail.Reviews)
                    {
                        // Check if the user has upvoted/downvoted each review
                        var upvote = movie.Reviews
                            .FirstOrDefault(r => r.Id == review.Id)?
                            .Upvotes?
                            .Any(u => u.UserId == parameters.UserId) ?? false;
                            
                        var downvote = movie.Reviews
                            .FirstOrDefault(r => r.Id == review.Id)?
                            .Downvotes?
                            .Any(d => d.UserId == parameters.UserId) ?? false;

                        review.IsUpvoted = upvote;
                        review.IsDownvoted = downvote;
                    }
                }
            }

            return movieDetail;
        }

        public async Task<MovieDetailDto> GetMovieByTitleAsync(string title, MovieQueryParameters parameters)
        {
            // Get movie with all necessary details
            var movie = await _movieRepository.GetMovieByTitleWithDetailsAsync(title, parameters);
            
            if (movie == null)
            {
                return null;
            }

            // Map to detail DTO
            var movieDetail = MapToDetailDto(movie);

            // Calculate average rating
            var (averageRating, totalReviews) = await _movieRepository.CalculateMovieRatingAsync(movie.Id);
            movieDetail.AverageRating = averageRating;
            movieDetail.TotalReviews = totalReviews;

            // Check if movie is bookmarked and reviewed by user
            if (parameters.UserId.HasValue)
            {
                movieDetail.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(movie.Id, parameters.UserId.Value);
                movieDetail.IsReviewed = await _movieRepository.IsMovieReviewedByUserAsync(movie.Id, parameters.UserId.Value);

                // Process reviews to add upvote/downvote status
                if (movieDetail.Reviews != null)
                {
                    foreach (var review in movieDetail.Reviews)
                    {
                        // Check if the user has upvoted/downvoted each review
                        var upvote = movie.Reviews
                            .FirstOrDefault(r => r.Id == review.Id)?
                            .Upvotes?
                            .Any(u => u.UserId == parameters.UserId) ?? false;
                            
                        var downvote = movie.Reviews
                            .FirstOrDefault(r => r.Id == review.Id)?
                            .Downvotes?
                            .Any(d => d.UserId == parameters.UserId) ?? false;

                        review.IsUpvoted = upvote;
                        review.IsDownvoted = downvote;
                    }
                }
            }

            return movieDetail;
        }

        public async Task<IEnumerable<MovieDto>> GetLatestMoviesAsync(int? userId = null)
        {
            // Try to get from cache if no userId provided
            string cacheKey = "LatestMovies";
            if (userId == null && _cache.TryGetValue(cacheKey, out List<MovieDto> cachedMovies))
            {
                return cachedMovies;
            }

            var movies = await _movieRepository.GetLatestMoviesAsync(userId);
            
            // Get ratings for all movies
            var movieIds = movies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);
            
            // Map to DTOs and add rating info
            List<MovieDto> result = new List<MovieDto>();
            
            foreach (var movie in movies)
            {
                var movieDto = MapToDto(movie);
                
                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDto.AverageRating = ratingInfo.AverageRating;
                    movieDto.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (userId.HasValue)
                {
                    movieDto.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(movie.Id, userId.Value);
                }

                result.Add(movieDto);
            }
            
            // Cache only if no userId provided (since results are personalized with userId)
            if (userId == null)
            {
                _cache.Set(cacheKey, result, CacheDuration);
            }
            
            return result;
        }

        public async Task<(IEnumerable<MovieDto> Movies, int TotalCount)> GetRelatedMoviesAsync(int id, int? userId, int page, int perPage)
        {
            // Use cache only if no user id (since results could be personalized)
            string cacheKey = $"RelatedMovies_{id}_{page}_{perPage}";
            if (userId == null && _cache.TryGetValue(cacheKey, out (List<MovieDto> Movies, int TotalCount) cachedResult))
            {
                return cachedResult;
            }
            
            var (relatedMovies, totalCount) = await _movieRepository.GetRelatedMoviesAsync(id, userId, page, perPage);
            
            if (relatedMovies == null || !relatedMovies.Any())
            {
                return (new List<MovieDto>(), 0);
            }
            
            // Get ratings for all movies
            var movieIds = relatedMovies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);
            
            // Map to DTOs and add rating info
            List<MovieDto> result = new List<MovieDto>();
            
            foreach (var movie in relatedMovies)
            {
                var movieDto = MapToDto(movie);
                
                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDto.AverageRating = ratingInfo.AverageRating;
                    movieDto.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (userId.HasValue)
                {
                    movieDto.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(movie.Id, userId.Value);
                }

                result.Add(movieDto);
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

        public async Task<MovieDto> CreateMovieAsync(MovieDto movieDto)
        {
            // Map DTO to entity
            var movie = new Movie
            {
                Title = movieDto.Title,
                PhotoSrc = movieDto.PhotoSrc,
                PhotoSrcProd = movieDto.PhotoSrcProd,
                TrailerSrc = movieDto.TrailerSrc,
                Duration = movieDto.Duration,
                RatingImdb = movieDto.RatingImdb,
                DateAired = movieDto.DateAired,
                Description = movieDto.Description
            };

            // Add movie to repository
            var createdMovie = await _movieRepository.AddAsync(movie);
            
            // Invalidate related cache entries
            InvalidateMovieCache();
            
            return MapToDto(createdMovie);
        }

        public async Task<MovieDto> UpdateMovieAsync(int id, MovieDto movieDto)
        {
            // Find existing movie
            var existingMovie = await _movieRepository.GetByIdAsync(id);
            
            if (existingMovie == null)
            {
                return null;
            }
            
            // Update properties
            existingMovie.Title = movieDto.Title;
            existingMovie.PhotoSrc = movieDto.PhotoSrc;
            existingMovie.PhotoSrcProd = movieDto.PhotoSrcProd;
            existingMovie.TrailerSrc = movieDto.TrailerSrc;
            existingMovie.Duration = movieDto.Duration;
            existingMovie.RatingImdb = movieDto.RatingImdb;
            existingMovie.DateAired = movieDto.DateAired;
            existingMovie.Description = movieDto.Description;
            
            // Update movie
            await _movieRepository.UpdateAsync(existingMovie);
            
            // Invalidate related cache entries
            InvalidateMovieCache();
            
            return MapToDto(existingMovie);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            
            if (movie == null)
            {
                return false;
            }
            
            await _movieRepository.DeleteAsync(movie);
            
            // Invalidate related cache entries
            InvalidateMovieCache();
            
            return true;
        }

        public async Task<(IEnumerable<MovieDto> Movies, int TotalCount)> SearchMoviesByTitleAsync(string title, MovieFilterDto filter)
        {
            var (movies, totalCount) = await _movieRepository.SearchMoviesByTitleAsync(title, filter);
            
            if (movies == null || !movies.Any())
            {
                return (new List<MovieDto>(), 0);
            }
            
            // Get ratings for all movies
            var movieIds = movies.Select(m => m.Id);
            var ratingsByMovieId = await _movieRepository.GetMovieRatingsAsync(movieIds);
            
            // Map to DTOs and add rating info
            List<MovieDto> result = new List<MovieDto>();
            
            foreach (var movie in movies)
            {
                var movieDto = MapToDto(movie);
                
                // Add rating info
                if (ratingsByMovieId.TryGetValue(movie.Id, out var ratingInfo))
                {
                    movieDto.AverageRating = ratingInfo.AverageRating;
                    movieDto.TotalReviews = ratingInfo.TotalReviews;
                }

                // Check if movie is bookmarked by user
                if (filter.UserId.HasValue)
                {
                    movieDto.IsBookmarked = await _movieRepository.IsMovieBookmarkedByUserAsync(movie.Id, filter.UserId.Value);
                }

                result.Add(movieDto);
            }
            
            return (result, totalCount);
        }

        #region Helper Methods
        
        private MovieDto MapToDto(Movie movie)
        {
            if (movie == null)
            {
                return null;
            }
            
            return new MovieDto
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
        
        private MovieDetailDto MapToDetailDto(Movie movie)
        {
            if (movie == null) return null;

            var dto = new MovieDetailDto
            {
                // Base properties from MovieDto
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
                Genres = movie.Genres?.Select(mg => new MovieGenreDto
                {
                    Id = mg.Id,
                    GenreId = mg.GenreId,
                    Name = mg.Genre?.Name
                }),
                
                Cast = movie.Cast?.Select(cm => new MovieCastDto
                {
                    Id = cm.Id,
                    ActorId = cm.ActorId,
                    Fullname = cm.Actor?.Fullname,
                    PhotoSrc = cm.Actor?.PhotoSrc
                }),
                
                Crew = movie.Crew?.Select(cm => new MovieCrewDto
                {
                    Id = cm.Id,
                    CrewId = cm.CrewId,
                    Fullname = cm.Crew?.Fullname,
                    Role = cm.Crew?.Role,
                    PhotoSrc = cm.Crew?.PhotoSrc
                }),
                
                Reviews = movie.Reviews?.Select(r => new MovieReviewDto
                {
                    Id = r.Id,
                    Content = r.Content,
                    Rating = r.Rating,
                    CreatedAt = r.CreatedAt,
                    UpdatedAt = r.UpdatedAt,
                    UserId = r.UserId,
                    UserName = r.User?.UserName,
                    UpvotesCount = r.Upvotes?.Count ?? 0,
                    DownvotesCount = r.Downvotes?.Count ?? 0
                })
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