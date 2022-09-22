using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;

namespace Auth.Data.Profiles
{
    internal class FamilyProfile : Profile
    {
        public FamilyProfile()
        {
            CreateMap<Family, FamilyDto>();
        }
    }
}
