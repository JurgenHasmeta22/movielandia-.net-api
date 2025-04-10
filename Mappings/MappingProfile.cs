using AutoMapper;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models.Domain;

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
                
            CreateMap<Movie, MovieDetailDTO>()
                .IncludeBase<Movie, MovieDTO>();
                
            CreateMap<MovieGenre, MovieGenreDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));
                
            CreateMap<CastMovie, MovieCastDTO>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.Actor.Fullname))
                .ForMember(dest => dest.PhotoSrc, opt => opt.MapFrom(src => src.Actor.PhotoSrc));
                
            CreateMap<CrewMovie, MovieCrewDTO>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => src.Crew.Fullname))
                .ForMember(dest => dest.PhotoSrc, opt => opt.MapFrom(src => src.Crew.PhotoSrc));
                
            CreateMap<MovieReview, MovieReviewDTO>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.UpvotesCount, opt => opt.MapFrom(src => src.Upvotes.Count))
                .ForMember(dest => dest.DownvotesCount, opt => opt.MapFrom(src => src.Downvotes.Count))
                .ForMember(dest => dest.IsUpvoted, opt => opt.Ignore())
                .ForMember(dest => dest.IsDownvoted, opt => opt.Ignore());
        }
    }
}