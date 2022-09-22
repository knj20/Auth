using Auth.Data.DbContexts;
using Auth.Data.Enteties;
using Auth.Data.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auth.Data.Repositories.PlantRepository
{
    public class PlantRepository : IPlantRepository
    {
        private readonly AuthDbContext _dbContext;
        private readonly IMapper _mapper;

        public PlantRepository(AuthDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;

        }
        public async Task<List<PlantDto>> GetAll()
        {
            var plants = await _dbContext.Plants.Include(c => c.Family).ToListAsync();
            return _mapper.Map<List<Plant>, List<PlantDto>>(plants);
        }
        public Task<int> Add(PlantDto plant)
        {
            var plantEntity = _mapper.Map<PlantDto, Plant>(plant);
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
