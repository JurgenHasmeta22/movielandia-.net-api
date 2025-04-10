using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string PhotoSrc { get; set; }
        public required string PhotoSrcProd { get; set; }
        public required string TrailerSrc { get; set; }
        public int Duration { get; set; }
        public float RatingImdb { get; set; }
        public DateTime? DateAired { get; set; }
        public required string Description { get; set; }

        // Additional properties after calculating ratings
        public float? AverageRating { get; set; }
        public int TotalReviews { get; set; }
        public bool IsBookmarked { get; set; } = false;
        public bool IsReviewed { get; set; } = false;

        // For detailed view
        public int? TotalCast { get; set; }
        public int? TotalCrew { get; set; }
    }
}
