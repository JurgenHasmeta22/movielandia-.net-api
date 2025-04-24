using Microsoft.AspNetCore.Mvc;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.DTOs.Requests;
using movielandia_.net_api.DTOs.Responses;
using movielandia_.net_api.Managers.Interfaces;

namespace movielandia_.net_api.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        #region Constructor

        private readonly IMovieManager _movieManager;

        public MovieController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        #endregion

        #region Query Operations

        [HttpGet]
        [ProducesResponseType(typeof(MovieListResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieListResponseDTO>> GetMoviesWithFilters(
            [FromQuery] MovieFilterDTO filter
        )
        {
            try
            {
                var result = await _movieManager.GetMoviesWithFiltersAsync(filter);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movies: {ex.Message}" }
                );
            }
        }

        [HttpGet("homepage")]
        [ProducesResponseType(typeof(IEnumerable<MovieDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetMoviesForHomePage()
        {
            try
            {
                var movies = await _movieManager.GetMoviesForHomePageAsync();
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving homepage movies: {ex.Message}" }
                );
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(MovieDetailResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDetailResponse>> GetMovieById(
            int id,
            [FromQuery] MovieQueryParameters parameters
        )
        {
            try
            {
                var result = await _movieManager.GetMovieByIdAsync(id, parameters);

                if (result == null)
                {
                    return NotFound(new { message = $"Movie with ID {id} not found" });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movie: {ex.Message}" }
                );
            }
        }

        [HttpGet("search")]
        [ProducesResponseType(typeof(MovieListResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieListResponseDTO>> SearchMovies(
            [FromQuery] SearchMovieRequestDTO request
        )
        {
            try
            {
                var result = await _movieManager.SearchMoviesAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error searching movies: {ex.Message}" }
                );
            }
        }

        [HttpGet("latest")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetLatestMovies(
            [FromQuery] int? userId = null
        )
        {
            try
            {
                var movies = await _movieManager.GetLatestMoviesAsync(userId);
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving latest movies: {ex.Message}" }
                );
            }
        }

        [HttpGet("{id:int}/related")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetRelatedMovies(
            int id,
            [FromQuery] int? userId = null,
            [FromQuery] int page = 1,
            [FromQuery] int perPage = 6
        )
        {
            try
            {
                var (movies, totalCount) = await _movieManager.GetRelatedMoviesAsync(
                    id,
                    userId,
                    page,
                    perPage
                );

                if (movies == null || totalCount == 0)
                {
                    return NotFound(new { message = $"No related movies found for movie ID {id}" });
                }

                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving related movies: {ex.Message}" }
                );
            }
        }

        [HttpGet("count")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> GetMoviesCount()
        {
            try
            {
                var count = await _movieManager.GetMoviesTotalCountAsync();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movie count: {ex.Message}" }
                );
            }
        }

        #endregion

        #region Command Operations

        [HttpPost]
        [ProducesResponseType(typeof(MovieDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDTO>> CreateMovie(
            [FromBody] CreateMovieRequestDTO request
        )
        {
            try
            {
                var createdMovie = await _movieManager.CreateMovieAsync(request);

                return CreatedAtAction(
                    nameof(GetMovieById),
                    new { id = createdMovie.Id },
                    createdMovie
                );
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error creating movie: {ex.Message}" }
                );
            }
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(MovieDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDTO>> UpdateMovie(
            int id,
            [FromBody] UpdateMovieRequestDTO request
        )
        {
            try
            {
                var updatedMovie = await _movieManager.UpdateMovieAsync(id, request);

                if (updatedMovie == null)
                {
                    return NotFound(new { message = $"Movie with ID {id} not found" });
                }

                return Ok(updatedMovie);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error updating movie: {ex.Message}" }
                );
            }
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            try
            {
                var result = await _movieManager.DeleteMovieAsync(id);

                if (!result)
                {
                    return NotFound(new { message = $"Movie with ID {id} not found" });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error deleting movie: {ex.Message}" }
                );
            }
        }

        #endregion
    }
}
