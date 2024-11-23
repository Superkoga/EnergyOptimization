using EnergyOptimization.DTOs;

namespace EnergyOptimization.Interfaces
{
    public interface IEnergyService
    {
        Task<string> AnalyzeConsumptionAsync(EnergyConsumptionDTO dto);
    }
}
