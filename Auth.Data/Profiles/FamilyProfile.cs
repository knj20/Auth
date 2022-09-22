using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;

namespace Auth.Data.Profiles
{
    public  class FamilyProfile : Profile
    {
        public FamilyProfile()
        {
            CreateMap<Family, FamilyDto>().ReverseMap();
        }
    }
}
