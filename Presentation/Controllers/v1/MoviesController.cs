using Microsoft.AspNetCore.Mvc;
using movielandia_.net_api.Application.Common.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;
using movielandia_.net_api.Application.Features.Movies.DTOs.Responses;
using movielandia_.net_api.Application.Features.Movies.Interfaces;

namespace movielandia_.net_api.Presentation.Controllers.v1;

/// <summary>
/// Movie resource endpoints — list, detail, search, CRUD.
/// </summary>
[ApiController]
[Route("api/movies")]
[Produces("application/json")]
public sealed class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
        => _movieService = movieService;

    // ── Queries ──────────────────────────────────────────────────────────────

    /// <summary>Gets a paginated, filterable list of movies.</summary>
    [HttpGet]
    [ProducesResponseType(typeof(PagedResult<MovieDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<MovieDto>>> GetPaged([FromQuery] MovieFilterParams filter)
    {
        var result = await _movieService.GetPagedAsync(filter);
        return Ok(result);
    }

    /// <summary>Gets movies for the home page (latest 30).</summary>
    [HttpGet("homepage")]
    [ProducesResponseType(typeof(IEnumerable<MovieDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetHomePage()
    {
        var result = await _movieService.GetForHomePageAsync();
        return Ok(result);
    }

    /// <summary>Gets the 6 most recently released movies.</summary>
    [HttpGet("latest")]
    [ProducesResponseType(typeof(IEnumerable<MovieDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetLatest([FromQuery] int? userId = null)
    {
        var result = await _movieService.GetLatestAsync(userId);
        return Ok(result);
    }

    /// <summary>Gets total movie count.</summary>
    [HttpGet("count")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public async Task<ActionResult<int>> GetCount()
    {
        var count = await _movieService.CountAsync();
        return Ok(count);
    }

    /// <summary>Gets a movie by ID with full detail, cast, crew, and reviews.</summary>
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(MovieDetailResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDetailResponse>> GetById(
        int id,
        [FromQuery] MovieQueryParams queryParams)
    {
        var result = await _movieService.GetByIdAsync(id, queryParams);
        return Ok(result);
    }

    /// <summary>Gets a movie by slug title.</summary>
    [HttpGet("by-title/{title}")]
    [ProducesResponseType(typeof(MovieDetailResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDetailResponse>> GetByTitle(
        string title,
        [FromQuery] MovieQueryParams queryParams)
    {
        var result = await _movieService.GetByTitleAsync(title, queryParams);
        return Ok(result);
    }

    /// <summary>Gets related movies (same genres) for a given movie.</summary>
    [HttpGet("{id:int}/related")]
    [ProducesResponseType(typeof(IEnumerable<MovieDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<MovieDto>>> GetRelated(
        int id,
        [FromQuery] int? userId = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 6)
    {
        var (items, total) = await _movieService.GetRelatedAsync(id, userId, page, pageSize);
        Response.Headers.Append("X-Total-Count", total.ToString());
        return Ok(items);
    }

    /// <summary>Full-text search with optional filters.</summary>
    [HttpGet("search")]
    [ProducesResponseType(typeof(PagedResult<MovieDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedResult<MovieDto>>> Search([FromQuery] MovieSearchParams search)
    {
        var result = await _movieService.SearchAsync(search);
        return Ok(result);
    }

    // ── Commands ─────────────────────────────────────────────────────────────

    /// <summary>Creates a new movie.</summary>
    [HttpPost]
    [ProducesResponseType(typeof(MovieDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<MovieDto>> Create([FromBody] CreateMovieRequest request)
    {
        var movie = await _movieService.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
    }

    /// <summary>Updates an existing movie (partial or full).</summary>
    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(MovieDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDto>> Update(int id, [FromBody] UpdateMovieRequest request)
    {
        var movie = await _movieService.UpdateAsync(id, request);
        return Ok(movie);
    }

    /// <summary>Deletes a movie by ID.</summary>
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        await _movieService.DeleteAsync(id);
        return NoContent();
    }
}
