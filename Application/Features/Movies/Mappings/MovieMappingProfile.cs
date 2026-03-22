using AutoMapper;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;
using movielandia_.net_api.Domain.Entities;

namespace movielandia_.net_api.Application.Features.Movies.Mappings;

public sealed class MovieMappingProfile : Profile
{
    public MovieMappingProfile()
    {
        CreateMap<Movie, MovieDto>()
            .ForMember(d => d.AverageRating, o => o.Ignore())
            .ForMember(d => d.IsBookmarked, o => o.Ignore())
            .ForMember(d => d.IsReviewed, o => o.Ignore());

        CreateMap<Movie, MovieDetailDto>().IncludeBase<Movie, MovieDto>();

        CreateMap<MovieGenre, MovieGenreDto>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Genre != null ? s.Genre.Name : string.Empty));

        CreateMap<CastMovie, MovieCastDto>()
            .ForMember(d => d.Fullname, o => o.MapFrom(s => s.Actor != null ? s.Actor.Fullname : string.Empty))
            .ForMember(d => d.PhotoSrc, o => o.MapFrom(s => s.Actor != null ? s.Actor.PhotoSrc : string.Empty));

        CreateMap<CrewMovie, MovieCrewDto>()
            .ForMember(d => d.Fullname, o => o.MapFrom(s => s.Crew != null ? s.Crew.Fullname : string.Empty))
            .ForMember(d => d.PhotoSrc, o => o.MapFrom(s => s.Crew != null ? s.Crew.PhotoSrc : string.Empty));

        CreateMap<MovieReview, MovieReviewDto>()
            .ForMember(d => d.UserName, o => o.MapFrom(s => s.User != null ? s.User.UserName : string.Empty))
            .ForMember(d => d.UpvotesCount, o => o.MapFrom(s => s.Upvotes != null ? s.Upvotes.Count : 0))
            .ForMember(d => d.DownvotesCount, o => o.MapFrom(s => s.Downvotes != null ? s.Downvotes.Count : 0))
            .ForMember(d => d.IsUpvoted, o => o.Ignore())
            .ForMember(d => d.IsDownvoted, o => o.Ignore());

        CreateMap<CreateMovieRequest, Movie>()
            .ForMember(d => d.Cast, o => o.Ignore())
            .ForMember(d => d.Crew, o => o.Ignore())
            .ForMember(d => d.Genres, o => o.Ignore());

        CreateMap<UpdateMovieRequest, Movie>()
            .ForMember(d => d.Cast, o => o.Ignore())
            .ForMember(d => d.Crew, o => o.Ignore())
            .ForMember(d => d.Genres, o => o.Ignore())
            .ForAllMembers(o => o.Condition((src, dest, srcMember) => srcMember != null));
    }
}
