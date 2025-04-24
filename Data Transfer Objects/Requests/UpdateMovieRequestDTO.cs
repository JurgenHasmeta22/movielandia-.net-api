using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.DTOs.Requests
{
    public class UpdateMovieRequestDTO
    {
        [StringLength(200)]
        public string? Title { get; set; }

        [Url]
        public string? PhotoSrc { get; set; }

        [Url]
        public string? PhotoSrcProd { get; set; }

        [Url]
        public string? TrailerSrc { get; set; }

        [Range(1, int.MaxValue)]
        public int? Duration { get; set; }

        [Range(0, 10)]
        public float? RatingImdb { get; set; }

        public DateTime? DateAired { get; set; }

        [StringLength(2000)]
        public string? Description { get; set; }

        public List<int>? GenreIds { get; set; }
        public List<MovieCastRequest>? Cast { get; set; }
        public List<MovieCrewRequest>? Crew { get; set; }
    }
}
