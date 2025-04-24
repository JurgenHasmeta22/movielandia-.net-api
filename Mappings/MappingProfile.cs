using AutoMapper;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.DTOs.Requests;
using movielandia_.net_api.DTOs.Responses;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDTO>()
                .ForMember(dest => dest.TotalReviews, opt => opt.MapFrom(src => src.Reviews.Count))
                .ForMember(dest => dest.TotalCast, opt => opt.MapFrom(src => src.Cast.Count))
                .ForMember(dest => dest.TotalCrew, opt => opt.MapFrom(src => src.Crew.Count))
                .ForMember(dest => dest.AverageRating, opt => opt.Ignore())
                .ForMember(dest => dest.IsBookmarked, opt => opt.Ignore())
                .ForMember(dest => dest.IsReviewed, opt => opt.Ignore());

            CreateMap<Movie, MovieDetailDTO>().IncludeBase<Movie, MovieDTO>();

            CreateMap<MovieGenre, MovieGenreDTO>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Genre != null ? src.Genre.Name : string.Empty)
                );

            CreateMap<CastMovie, MovieCastDTO>()
                .ForMember(
                    dest => dest.Fullname,
                    opt => opt.MapFrom(src => src.Actor != null ? src.Actor.Fullname : string.Empty)
                )
                .ForMember(
                    dest => dest.PhotoSrc,
                    opt => opt.MapFrom(src => src.Actor != null ? src.Actor.PhotoSrc : string.Empty)
                );

            CreateMap<CrewMovie, MovieCrewDTO>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.Crew.Fullname))
                .ForMember(dest => dest.PhotoSrc, opt => opt.MapFrom(src => src.Crew.PhotoSrc));

            CreateMap<MovieReview, MovieReviewDTO>()
                .ForMember(
                    dest => dest.UserName,
                    opt => opt.MapFrom(src => src.User != null ? src.User.UserName : string.Empty)
                )
                .ForMember(dest => dest.UpvotesCount, opt => opt.MapFrom(src => src.Upvotes.Count))
                .ForMember(
                    dest => dest.DownvotesCount,
                    opt => opt.MapFrom(src => src.Downvotes.Count)
                )
                .ForMember(dest => dest.IsUpvoted, opt => opt.Ignore())
                .ForMember(dest => dest.IsDownvoted, opt => opt.Ignore());

            CreateMap<CreateMovieRequestDTO, Movie>()
                .ForMember(dest => dest.Cast, opt => opt.Ignore())
                .ForMember(dest => dest.Crew, opt => opt.Ignore())
                .ForMember(dest => dest.Genres, opt => opt.Ignore());

            CreateMap<UpdateMovieRequestDTO, Movie>()
                .ForMember(dest => dest.Cast, opt => opt.Ignore())
                .ForMember(dest => dest.Crew, opt => opt.Ignore())
                .ForMember(dest => dest.Genres, opt => opt.Ignore())
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // Response mappings
            CreateMap<
                (IEnumerable<MovieDTO> Movies, PaginationMetadata Pagination),
                MovieListResponseDTO
            >()
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Movies))
                .ForMember(dest => dest.Pagination, opt => opt.MapFrom(src => src.Pagination));
        }
    }
}
