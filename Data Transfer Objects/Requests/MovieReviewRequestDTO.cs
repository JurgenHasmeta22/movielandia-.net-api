using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.DTOs.Requests
{
    public class MovieReviewRequest
    {
        [Required]
        [StringLength(2000)]
        public string Content { get; set; }

        [Range(0, 10)]
        public float? Rating { get; set; }

        [Required]
        public int MovieId { get; set; }

        // Optional fields for review update
        public bool? IsUpvote { get; set; }
        public bool? IsDownvote { get; set; }
    }
}
