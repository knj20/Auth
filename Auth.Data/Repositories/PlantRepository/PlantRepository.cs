using Auth.Data.DbContexts;
using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Auth.Data.Repositories.PlantRepository
{
    internal class PlantRepository : IPlantRepository
    {
        private readonly AuthDbContext _dbContext;
        private readonly IMapper _mapper;

        public PlantRepository(AuthDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public Task<int> Add(PlantDto plant)
        {
            var plantEntity = _mapper.Map<Plant>(plant);
            _dbContext.Plants.Add(plantEntity);
            return _dbContext.SaveChangesAsync();
        }

        public PlantDto Get(Guid plantId)
        {
            var plantEntity = _dbContext.Plants.FindAsync(plantId);
            var plantModel = _mapper.Map<PlantDto>(plantEntity);
            return plantModel;
        }

        public Task<int> GetPlantTotal(Guid plantId)
        {
            return _dbContext.Plants.CountAsync(p => p.Id == plantId);
        }
    }
}
