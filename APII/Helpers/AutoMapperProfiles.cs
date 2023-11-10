using APII.DTOs;
using APII.Entities;
using APII.Extensions;
using AutoMapper;

namespace APII.Helpers
{
public class AutoMapperProfiles: Profile
{
public AutoMapperProfiles()
{
    
CreateMap<AppUser, MemberDto>()
.ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom
(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
.ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
CreateMap<Photo, PhotoDto>();
CreateMap<MemberUpdateDto, AppUser>();
CreateMap<RegisterDto, AppUser>();

}
}
}
