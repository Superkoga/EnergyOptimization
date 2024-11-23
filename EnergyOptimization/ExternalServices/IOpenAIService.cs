using EnergyOptimization.Entities;

namespace EnergyOptimization.ExternalServices
{
    public interface IOpenAIService
    {
        Task<string> GenerateEfficiencyReportAsync(EnergyConsumption consumption);
    }
}
