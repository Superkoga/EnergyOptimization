using EnergyOptimization.Entities;
using EnergyOptimization.Interfaces;
using MongoDB.Driver;

namespace EnergyOptimization.Repositories
{
    public class EnergyRepository : IRepository<EnergyConsumption>
    {
        private readonly IMongoCollection<EnergyConsumption> _collection;

        public EnergyRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<EnergyConsumption>("EnergyConsumptions");
        }

        public async Task AddAsync(EnergyConsumption entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task<IEnumerable<EnergyConsumption>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<EnergyConsumption> GetByIdAsync(string id)
        {
            return await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
