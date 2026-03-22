using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.Interfaces;
using movielandia_.net_api.Domain.Entities;
using movielandia_.net_api.Domain.Enums;
using movielandia_.net_api.Infrastructure.Persistence;

namespace movielandia_.net_api.Infrastructure.Repositories;

/// <summary>
/// EF Core implementation of IMovieRepository.
/// All complex querying lives here — the service layer stays focused on orchestration.
/// </summary>
public sealed class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    public MovieRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Movie>> GetForHomePageAsync()
        => await Context.Movie
            .AsNoTracking()
            .OrderByDescending(m => m.DateAired)
            .Take(30)
            .ToListAsync();

    public async Task<IEnumerable<Movie>> GetLatestAsync(int count = 6)
        => await Context.Movie
            .AsNoTracking()
            .OrderByDescending(m => m.DateAired)
            .Take(count)
            .ToListAsync();

    public async Task<Movie?> GetWithDetailsAsync(int id, MovieQueryParams p)
    {
        var reviewSkip = (p.ReviewsPage - 1) * 5;
        var castSkip = (p.CastPage - 1) * 5;
        var crewSkip = (p.CrewPage - 1) * 5;
        var reviewDir = p.ReviewsAscOrDesc.Equals("asc", StringComparison.OrdinalIgnoreCase);

        var movie = await Context.Movie
            .Include(m => m.Genres).ThenInclude(mg => mg.Genre)
            .Include(m => m.Cast.OrderBy(c => c.Id).Skip(castSkip).Take(5)).ThenInclude(cm => cm.Actor)
            .Include(m => m.Crew.OrderBy(c => c.Id).Skip(crewSkip).Take(5)).ThenInclude(cm => cm.Crew)
            .Include(m => m.Reviews).ThenInclude(r => r.User)
            .Include(m => m.Reviews).ThenInclude(r => r.Upvotes).ThenInclude(u => u.User)
            .Include(m => m.Reviews).ThenInclude(r => r.Downvotes).ThenInclude(d => d.User)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (movie is not null)
            movie.Reviews = SortAndPageReviews(movie.Reviews, p.ReviewsSortBy, reviewDir, reviewSkip).ToList();

        return movie;
    }

    public async Task<Movie?> GetWithDetailsByTitleAsync(string title, MovieQueryParams p)
    {
        var slug = title.Replace("-", " ");
        var reviewSkip = (p.ReviewsPage - 1) * 5;
        var reviewDir = p.ReviewsAscOrDesc.Equals("asc", StringComparison.OrdinalIgnoreCase);

        var movie = await Context.Movie
            .Include(m => m.Genres).ThenInclude(mg => mg.Genre)
            .Include(m => m.Cast).ThenInclude(cm => cm.Actor)
            .Include(m => m.Crew).ThenInclude(cm => cm.Crew)
            .Include(m => m.Reviews).ThenInclude(r => r.User)
            .Include(m => m.Reviews).ThenInclude(r => r.Upvotes).ThenInclude(u => u.User)
            .Include(m => m.Reviews).ThenInclude(r => r.Downvotes).ThenInclude(d => d.User)
            .FirstOrDefaultAsync(m => m.Title == slug);

        if (movie is not null)
            movie.Reviews = SortAndPageReviews(movie.Reviews, p.ReviewsSortBy, reviewDir, reviewSkip).ToList();

        return movie;
    }

    public async Task<(IEnumerable<Movie> Items, int TotalCount)> GetPagedAsync(MovieFilterParams filter)
    {
        var query = Context.Movie.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(filter.Title))
            query = query.Where(m => m.Title.Contains(filter.Title));

        query = ApplyDynamicFilter(query, filter.FilterField, filter.FilterValue, filter.FilterOperator);
        query = ApplySort(query, filter.SortBy, filter.AscOrDesc);

        var total = await query.CountAsync();
        var items = await query
            .Skip((filter.Page - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .ToListAsync();

        return (items, total);
    }

    public async Task<(IEnumerable<Movie> Items, int TotalCount)> GetRelatedAsync(int movieId, int page, int pageSize)
    {
        var genreIds = await Context.MovieGenre
            .Where(mg => mg.MovieId == movieId)
            .Select(mg => mg.GenreId)
            .ToListAsync();

        if (!genreIds.Any())
            return ([], 0);

        var relatedIds = await Context.MovieGenre
            .Where(mg => genreIds.Contains(mg.GenreId) && mg.MovieId != movieId)
            .Select(mg => mg.MovieId)
            .Distinct()
            .ToListAsync();

        if (!relatedIds.Any())
            return ([], 0);

        var total = relatedIds.Count;
        var pagedIds = relatedIds.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        var items = await Context.Movie.Where(m => pagedIds.Contains(m.Id)).ToListAsync();
        return (items, total);
    }

    public async Task<(IEnumerable<Movie> Items, int TotalCount)> SearchAsync(MovieSearchParams search)
    {
        var query = Context.Movie.AsNoTracking().AsQueryable();

        if (!string.IsNullOrWhiteSpace(search.SearchTerm))
            query = query.Where(m => m.Title.Contains(search.SearchTerm));

        if (search.MinRating.HasValue)
            query = query.Where(m => m.RatingImdb >= search.MinRating.Value);

        query = ApplySort(query, search.SortBy, search.SortDirection);

        var total = await query.CountAsync();
        var items = await query
            .Skip((search.Page - 1) * search.PageSize)
            .Take(search.PageSize)
            .Include(m => m.Genres)
            .ToListAsync();

        return (items, total);
    }

    public Task<int> CountAsync()
        => Context.Movie.CountAsync();

    public Task<bool> IsBookmarkedByUserAsync(int movieId, int userId)
        => Context.UserMovieFavorite.AnyAsync(f => f.MovieId == movieId && f.UserId == userId);

    public Task<bool> IsReviewedByUserAsync(int movieId, int userId)
        => Context.MovieReview.AnyAsync(r => r.MovieId == movieId && r.UserId == userId);

    public async Task<(float AverageRating, int TotalReviews)> GetRatingStatsAsync(int movieId)
    {
        var reviews = await Context.MovieReview
            .Where(r => r.MovieId == movieId && r.Rating.HasValue)
            .Select(r => r.Rating!.Value)
            .ToListAsync();

        if (reviews.Count == 0)
            return (0f, 0);

        return (reviews.Average(), reviews.Count);
    }

    public async Task<Dictionary<int, (float AverageRating, int TotalReviews)>> GetBulkRatingStatsAsync(IEnumerable<int> movieIds)
    {
        var grouped = await Context.MovieReview
            .Where(r => movieIds.Contains(r.MovieId) && r.Rating.HasValue)
            .GroupBy(r => r.MovieId)
            .Select(g => new { g.Key, Avg = g.Average(r => r.Rating!.Value), Count = g.Count() })
            .ToListAsync();

        var result = grouped.ToDictionary(
            g => g.Key,
            g => ((float)g.Avg, g.Count));

        foreach (var id in movieIds.Where(id => !result.ContainsKey(id)))
            result[id] = (0f, 0);

        return result;
    }

    // ── Private Helpers ──────────────────────────────────────────────────────

    private static IEnumerable<MovieReview> SortAndPageReviews(
        ICollection<MovieReview> reviews, string sortBy, bool ascending, int skip)
    {
        IEnumerable<MovieReview> sorted = sortBy.Equals("Rating", StringComparison.OrdinalIgnoreCase)
            ? ascending ? reviews.OrderBy(r => r.Rating) : reviews.OrderByDescending(r => r.Rating)
            : ascending ? reviews.OrderBy(r => r.CreatedAt) : reviews.OrderByDescending(r => r.CreatedAt);

        return sorted.Skip(skip).Take(5);
    }

    private static IQueryable<Movie> ApplySort(IQueryable<Movie> query, string sortBy, string direction)
    {
        var desc = direction.Equals("desc", StringComparison.OrdinalIgnoreCase);

        return sortBy.ToLower() switch
        {
            "dateaired" => desc ? query.OrderByDescending(m => m.DateAired) : query.OrderBy(m => m.DateAired),
            "ratingimdb" => desc ? query.OrderByDescending(m => m.RatingImdb) : query.OrderBy(m => m.RatingImdb),
            "duration" => desc ? query.OrderByDescending(m => m.Duration) : query.OrderBy(m => m.Duration),
            _ => desc ? query.OrderByDescending(m => m.Title) : query.OrderBy(m => m.Title),
        };
    }

    private static IQueryable<Movie> ApplyDynamicFilter(IQueryable<Movie> query, string? field, object? value, FilterOperator? op)
    {
        if (field is null || value is null || op is null)
            return query;

        var property = typeof(Movie).GetProperty(field);
        if (property is null)
            return query;

        var converted = Convert.ChangeType(value, property.PropertyType);

        return op switch
        {
            FilterOperator.Equal => query.Where(m => EF.Property<object>(m, field).Equals(converted)),
            FilterOperator.Contains when property.PropertyType == typeof(string)
                => query.Where(m => EF.Property<string>(m, field).Contains(converted.ToString() ?? string.Empty)),
            FilterOperator.GreaterThan when property.PropertyType == typeof(float)
                => query.Where(m => EF.Property<float>(m, field) > Convert.ToSingle(converted)),
            FilterOperator.GreaterThan when property.PropertyType == typeof(int)
                => query.Where(m => EF.Property<int>(m, field) > Convert.ToInt32(converted)),
            FilterOperator.LessThan when property.PropertyType == typeof(float)
                => query.Where(m => EF.Property<float>(m, field) < Convert.ToSingle(converted)),
            FilterOperator.LessThan when property.PropertyType == typeof(int)
                => query.Where(m => EF.Property<int>(m, field) < Convert.ToInt32(converted)),
            _ => query,
        };
    }
}
