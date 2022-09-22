using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auth.Data.Repositories.PlantRepository
{
    public interface IPlantRepository
    {
        Task<int> Add(PlantDto plant);
        PlantDto Get(Guid plantId);
        Task<int> GetPlantTotal(Guid plantId);
        Task<List<PlantDto>> GetAll();
    }
}
