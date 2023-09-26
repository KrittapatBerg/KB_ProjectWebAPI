using AutoMapper;
using KB_WebAPI.DTO;
using KB_WebAPI.Models;

namespace KB_WebAPI.Helper
{
    public class MappingProfiles : Profile 
    {
        public MappingProfiles()
        {
            CreateMap<csAttraction, AttractionDto>();
            CreateMap<csAddress, AddressDto>();
            CreateMap<csUser, UserDto>();
            CreateMap<csReview, ReviewDto>(); 
            CreateMap<csRating, RatingDto>(); 
        }
    }
}
