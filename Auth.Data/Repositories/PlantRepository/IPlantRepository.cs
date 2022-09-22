using Auth.Data.Models;
using System;
using System.Threading.Tasks;

namespace Auth.Data.Repositories.PlantRepository
{
    internal interface IPlantRepository
    {
        Task<int> Add(PlantDto plant);
        PlantDto Get(Guid plantId);
        Task<int> GetPlantTotal(Guid plantId);
    }
}
