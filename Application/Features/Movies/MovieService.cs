using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using movielandia_.net_api.Application.Common.DTOs;
using movielandia_.net_api.Application.Common.Exceptions;
using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;
using movielandia_.net_api.Application.Features.Movies.DTOs.Responses;
using movielandia_.net_api.Application.Features.Movies.Interfaces;
using movielandia_.net_api.Domain.Entities;

namespace movielandia_.net_api.Application.Features.Movies;

/// <summary>
/// Handles all movie use cases: querying, searching, CRUD, caching, and DTO projection.
/// Replaces the old Manager + BLL dual-layer pattern.
/// </summary>
public sealed class MovieService : IMovieService
{
    private static readonly TimeSpan DefaultCacheDuration = TimeSpan.FromMinutes(30);

    private readonly IMovieRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _cache;

    public MovieService(
        IMovieRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IMemoryCache cache)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cache = cache;
    }

    // ── Queries ─────────────────────────────────────────────────────────────

    public async Task<PagedResult<MovieDto>> GetPagedAsync(MovieFilterParams filter)
    {
        var cacheKey = $"movies_paged_{filter.Page}_{filter.PageSize}_{filter.SortBy}_{filter.AscOrDesc}_{filter.Title}";

        if (_cache.TryGetValue(cacheKey, out PagedResult<MovieDto>? cached) && cached is not null)
            return cached;

        var (items, total) = await _repository.GetPagedAsync(filter);
        var dtos = _mapper.Map<IEnumerable<MovieDto>>(items);
        var result = PagedResult<MovieDto>.Create(dtos, total, filter.Page, filter.PageSize);

        _cache.Set(cacheKey, result, DefaultCacheDuration);
        return result;
    }

    public async Task<IEnumerable<MovieDto>> GetForHomePageAsync()
    {
        const string key = "movies_homepage";

        if (_cache.TryGetValue(key, out IEnumerable<MovieDto>? cached) && cached is not null)
            return cached;

        var movies = await _repository.GetForHomePageAsync();
        var dtos = _mapper.Map<IEnumerable<MovieDto>>(movies);

        _cache.Set(key, dtos, DefaultCacheDuration);
        return dtos;
    }

    public async Task<IEnumerable<MovieDto>> GetLatestAsync(int? userId = null)
    {
        var key = $"movies_latest_{userId}";

        if (userId is null && _cache.TryGetValue(key, out IEnumerable<MovieDto>? cached) && cached is not null)
            return cached;

        var movies = await _repository.GetLatestAsync();
        var dtos = _mapper.Map<IEnumerable<MovieDto>>(movies);

        if (userId is null)
            _cache.Set(key, dtos, DefaultCacheDuration);

        return dtos;
    }

    public async Task<MovieDetailResponse> GetByIdAsync(int id, MovieQueryParams queryParams)
    {
        var key = $"movie_detail_{id}_{queryParams.ReviewsPage}_{queryParams.ReviewsSortBy}";

        if (_cache.TryGetValue(key, out MovieDetailResponse? cached) && cached is not null)
            return cached;

        var movie = await _repository.GetWithDetailsAsync(id, queryParams)
            ?? throw new NotFoundException(nameof(Movie), id);

        var response = await BuildDetailResponseAsync(movie, id);
        _cache.Set(key, response, DefaultCacheDuration);
        return response;
    }

    public async Task<MovieDetailResponse> GetByTitleAsync(string title, MovieQueryParams queryParams)
    {
        var key = $"movie_title_{title}_{queryParams.ReviewsPage}";

        if (_cache.TryGetValue(key, out MovieDetailResponse? cached) && cached is not null)
            return cached;

        var movie = await _repository.GetWithDetailsByTitleAsync(title, queryParams)
            ?? throw new NotFoundException(nameof(Movie), title);

        var response = await BuildDetailResponseAsync(movie, movie.Id);
        _cache.Set(key, response, DefaultCacheDuration);
        return response;
    }

    public async Task<PagedResult<MovieDto>> SearchAsync(MovieSearchParams search)
    {
        var (items, total) = await _repository.SearchAsync(search);

        var filtered = items.AsEnumerable();

        if (search.MaxRating.HasValue)
            filtered = filtered.Where(m => m.RatingImdb <= search.MaxRating.Value);
        if (search.FromDate.HasValue)
            filtered = filtered.Where(m => m.DateAired >= search.FromDate.Value);
        if (search.ToDate.HasValue)
            filtered = filtered.Where(m => m.DateAired <= search.ToDate.Value);
        if (search.GenreIds?.Any() == true)
            filtered = filtered.Where(m => m.Genres.Any(g => search.GenreIds.Contains(g.GenreId)));

        var dtos = _mapper.Map<IEnumerable<MovieDto>>(filtered);
        return PagedResult<MovieDto>.Create(dtos, total, search.Page, search.PageSize);
    }

    public async Task<(IEnumerable<MovieDto> Items, int TotalCount)> GetRelatedAsync(int movieId, int? userId, int page, int pageSize)
    {
        var key = $"movies_related_{movieId}_{page}_{pageSize}";

        if (userId is null && _cache.TryGetValue(key, out (IEnumerable<MovieDto>, int) cached))
            return cached;

        var (items, total) = await _repository.GetRelatedAsync(movieId, page, pageSize);
        var dtos = _mapper.Map<IEnumerable<MovieDto>>(items);
        var result = (dtos, total);

        if (userId is null)
            _cache.Set(key, result, DefaultCacheDuration);

        return result;
    }

    public async Task<int> CountAsync()
    {
        const string key = "movies_total_count";

        if (_cache.TryGetValue(key, out int cached))
            return cached;

        var count = await _repository.CountAsync();
        _cache.Set(key, count, DefaultCacheDuration);
        return count;
    }

    // ── Commands ─────────────────────────────────────────────────────────────

    public async Task<MovieDto> CreateAsync(CreateMovieRequest request)
    {
        var movie = _mapper.Map<Movie>(request);
        await _repository.AddAsync(movie);
        await _unitOfWork.SaveChangesAsync();
        InvalidateListCaches();
        return _mapper.Map<MovieDto>(movie);
    }

    public async Task<MovieDto> UpdateAsync(int id, UpdateMovieRequest request)
    {
        var movie = await _repository.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Movie), id);

        _mapper.Map(request, movie);
        await _unitOfWork.SaveChangesAsync();
        InvalidateCachesForMovie(id);
        return _mapper.Map<MovieDto>(movie);
    }

    public async Task DeleteAsync(int id)
    {
        var deleted = await _repository.DeleteAsync(id);

        if (!deleted)
            throw new NotFoundException(nameof(Movie), id);

        await _unitOfWork.SaveChangesAsync();
        InvalidateCachesForMovie(id);
    }

    // ── Helpers ──────────────────────────────────────────────────────────────

    private async Task<MovieDetailResponse> BuildDetailResponseAsync(Movie movie, int movieId)
    {
        var dto = _mapper.Map<MovieDetailDto>(movie);
        var (avgRating, totalReviews) = await _repository.GetRatingStatsAsync(movieId);
        var (similar, _) = await _repository.GetRelatedAsync(movieId, 1, 6);

        return new MovieDetailResponse
        {
            Movie = dto,
            Stats = new MovieStats
            {
                AverageRating = avgRating,
                TotalReviews = totalReviews,
                SimilarMovies = _mapper.Map<IEnumerable<MovieDto>>(similar),
            },
        };
    }

    private void InvalidateListCaches()
    {
        _cache.Remove("movies_homepage");
        _cache.Remove("movies_total_count");
    }

    private void InvalidateCachesForMovie(int id)
    {
        InvalidateListCaches();
        _cache.Remove($"movie_detail_{id}");
    }
}
