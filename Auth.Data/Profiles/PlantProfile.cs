using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;

namespace Auth.Data.Profiles
{
    public class PlantProfile : Profile
    {
        public PlantProfile()
        {
            CreateMap<Plant, PlantDto>().ReverseMap();
        }
        
    }
}
