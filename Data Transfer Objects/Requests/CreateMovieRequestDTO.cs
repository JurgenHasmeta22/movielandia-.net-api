using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.DTOs.Requests
{
    public class CreateMovieRequestDTO
    {
        [Required]
        [StringLength(200)]
        public required string Title { get; set; }

        [Required]
        [Url]
        public required string PhotoSrc { get; set; }

        [Required]
        [Url]
        public required string PhotoSrcProd { get; set; }

        [Required]
        [Url]
        public required string TrailerSrc { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public required int Duration { get; set; }

        [Required]
        [Range(0, 10)]
        public required float RatingImdb { get; set; }

        public DateTime? DateAired { get; set; }

        [Required]
        [StringLength(2000)]
        public required string Description { get; set; }

        [Required]
        public required List<int> GenreIds { get; set; }

        [Required]
        public required List<MovieCastRequest> Cast { get; set; }

        [Required]
        public required List<MovieCrewRequest> Crew { get; set; }
    }

    public class MovieCastRequest
    {
        [Required]
        public int ActorId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Role { get; set; }
    }

    public class MovieCrewRequest
    {
        [Required]
        public int CrewId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Role { get; set; }
    }
}
