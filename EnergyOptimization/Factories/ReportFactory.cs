using EnergyOptimization.Entities;
using EnergyOptimization.ExternalServices;

namespace EnergyOptimization.Factories
{
    public class ReportFactory : IReportFactory
    {
        private readonly IOpenAIService _openAIService;

        public ReportFactory(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        public async Task<string> GenerateReportAsync(EnergyConsumption consumption)
        {
            return await _openAIService.GenerateEfficiencyReportAsync(consumption);
        }
    }
}
