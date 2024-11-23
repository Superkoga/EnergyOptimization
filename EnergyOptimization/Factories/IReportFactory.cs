using EnergyOptimization.Entities;

namespace EnergyOptimization.Factories
{
    public interface IReportFactory
    {
        Task<string> GenerateReportAsync(EnergyConsumption consumption);
    }
}
