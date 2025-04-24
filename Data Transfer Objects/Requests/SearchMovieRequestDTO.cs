using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.DTOs.Requests
{
    public class SearchMovieRequestDTO
    {
        [Required]
        [MinLength(2)]
        public string SearchTerm { get; set; }

        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;

        [Range(1, 100)]
        public int PerPage { get; set; } = 12;

        public string SortBy { get; set; } = "title";
        public string SortDirection { get; set; } = "asc";

        // Optional filters
        public float? MinRating { get; set; }
        public float? MaxRating { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public List<int>? GenreIds { get; set; }
    }
}
