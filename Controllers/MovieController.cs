using Microsoft.AspNetCore.Mvc;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Infrastructures.Interfaces;

namespace movielandia_.net_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieInfrastructure _movieInfrastructure;

        public MovieController(IMovieInfrastructure movieInfrastructure)
        {
            _movieInfrastructure = movieInfrastructure;
        }

        /// <summary>
        /// Get all movies with optional filtering and pagination
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetMoviesWithFilters(
            [FromQuery] MovieFilterDTO filter
        )
        {
            try
            {
                var (movies, totalCount) = await _movieInfrastructure.GetMoviesWithFiltersAsync(
                    filter
                );
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movies: {ex.Message}" }
                );
            }
        }

        /// <summary>
        /// Get movies for the home page
        /// </summary>
        [HttpGet("homepage")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetMoviesForHomePage()
        {
            try
            {
                var movies = await _movieInfrastructure.GetMoviesForHomePageAsync();
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

        /// <summary>
        /// Get a specific movie by ID with all its details
        /// </summary>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDetailDTO>> GetMovieById(
            int id,
            [FromQuery] MovieQueryParameters parameters
        )
        {
            try
            {
                var movie = await _movieInfrastructure.GetMovieByIdAsync(id, parameters);

                if (movie == null)
                {
                    return NotFound(new { message = $"Movie with ID {id} not found" });
                }

                return Ok(movie);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movie: {ex.Message}" }
                );
            }
        }

        /// <summary>
        /// Get a specific movie by title with all its details
        /// </summary>
        [HttpGet("title/{title}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDetailDTO>> GetMovieByTitle(
            string title,
            [FromQuery] MovieQueryParameters parameters
        )
        {
            try
            {
                var movie = await _movieInfrastructure.GetMovieByTitleAsync(title, parameters);

                if (movie == null)
                {
                    return NotFound(new { message = $"Movie with title '{title}' not found" });
                }

                return Ok(movie);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error retrieving movie: {ex.Message}" }
                );
            }
        }

        /// <summary>
        /// Get the latest movies
        /// </summary>
        [HttpGet("latest")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> GetLatestMovies(
            [FromQuery] int? userId = null
        )
        {
            try
            {
                var movies = await _movieInfrastructure.GetLatestMoviesAsync(userId);
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

        /// <summary>
        /// Get movies related to a specific movie
        /// </summary>
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
                var (movies, totalCount) = await _movieInfrastructure.GetRelatedMoviesAsync(
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

        /// <summary>
        /// Get the total count of movies in the database
        /// </summary>
        [HttpGet("count")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> GetMoviesCount()
        {
            try
            {
                var count = await _movieInfrastructure.GetMoviesTotalCountAsync();
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

        /// <summary>
        /// Search for movies by title
        /// </summary>
        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<MovieDTO>>> SearchMovies(
            [FromQuery] string title,
            [FromQuery] MovieFilterDTO filter
        )
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return BadRequest(new { message = "Search title is required" });
            }

            try
            {
                var (movies, totalCount) = await _movieInfrastructure.SearchMoviesByTitleAsync(
                    title,
                    filter
                );
                Response.Headers.Append("X-Total-Count", totalCount.ToString());
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new { message = $"Error searching movies: {ex.Message}" }
                );
            }
        }

        /// <summary>
        /// Create a new movie
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDTO>> CreateMovie([FromBody] MovieDTO movieDTO)
        {
            try
            {
                if (movieDTO == null)
                {
                    return BadRequest(new { message = "Movie data is required" });
                }

                var createdMovie = await _movieInfrastructure.CreateMovieAsync(movieDTO);
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

        /// <summary>
        /// Update an existing movie
        /// </summary>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MovieDTO>> UpdateMovie(int id, [FromBody] MovieDTO movieDTO)
        {
            try
            {
                if (movieDTO == null)
                {
                    return BadRequest(new { message = "Movie data is required" });
                }

                var updatedMovie = await _movieInfrastructure.UpdateMovieAsync(id, movieDTO);

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

        /// <summary>
        /// Delete a movie
        /// </summary>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            try
            {
                var result = await _movieInfrastructure.DeleteMovieAsync(id);

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
    }
}
