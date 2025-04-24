using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.DTOs.Requests
{
    public class CreateMovieRequestDTO
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [Url]
        public string PhotoSrc { get; set; }

        [Required]
        [Url]
        public string PhotoSrcProd { get; set; }

        [Required]
        [Url]
        public string TrailerSrc { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Duration { get; set; }

        [Required]
        [Range(0, 10)]
        public float RatingImdb { get; set; }

        public DateTime? DateAired { get; set; }

        [Required]
        [StringLength(2000)]
        public string Description { get; set; }

        [Required]
        public List<int> GenreIds { get; set; }

        [Required]
        public List<MovieCastRequest> Cast { get; set; }

        [Required]
        public List<MovieCrewRequest> Crew { get; set; }
    }

    public class MovieCastRequest
    {
        [Required]
        public int ActorId { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }
    }

    public class MovieCrewRequest
    {
        [Required]
        public int CrewId { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }
    }
}
