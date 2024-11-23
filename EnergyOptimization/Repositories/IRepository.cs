using EnergyOptimization.Entities;

namespace EnergyOptimization.Interfaces
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
    }
}
