namespace movielandia_.net_api.DTOs.Responses
{
    public class MovieListResponseDTO
    {
        public required IEnumerable<MovieDTO> Movies { get; set; }
        public required PaginationMetadata Pagination { get; set; }
    }

    public class PaginationMetadata
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
