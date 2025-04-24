using System.ComponentModel.DataAnnotations;
using movielandia_.net_api.Enums;

namespace movielandia_.net_api.DTOs
{
    public class MovieFilterDTO
    {
        public string SortBy { get; set; } = "title";
        public string AscOrDesc { get; set; } = "asc";

        [Range(1, 100)]
        public int PerPage { get; set; } = 12;

        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;

        public string? Title { get; set; }

        public object? FilterValue { get; set; }
        public string? FilterNameString { get; set; }
        public FilterOperator? FilterOperatorString { get; set; }

        // User identification
        public int? UserId { get; set; }
    }

    public class MovieQueryParameters
    {
        // For movie detail view
        public int? ReviewsPage { get; set; } = 1;
        public string ReviewsAscOrDesc { get; set; } = "desc";
        public string ReviewsSortBy { get; set; } = "createdAt";
        public int? UpvotesPage { get; set; } = 1;
        public int? DownvotesPage { get; set; } = 1;
        public int? CastPage { get; set; } = 1;
        public int? CrewPage { get; set; } = 1;

        // User identification
        public int? UserId { get; set; }
    }

    public class RelatedMoviesRequest
    {
        [Required]
        public int MovieId { get; set; }

        public int? UserId { get; set; }

        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;

        [Range(1, 100)]
        public int PerPage { get; set; } = 6;
    }
}
