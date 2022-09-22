using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;

namespace Auth.Data.Profiles
{
    internal class PlantProfile : Profile
    {
        public PlantProfile()
        {
            CreateMap<Plant, PlantDto>();
        }
        
    }
}
