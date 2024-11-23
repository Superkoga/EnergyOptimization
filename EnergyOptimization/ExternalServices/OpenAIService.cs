using EnergyOptimization.Entities;

namespace EnergyOptimization.ExternalServices
{
    public class OpenAIService : IOpenAIService
    {
        public async Task<string> GenerateEfficiencyReportAsync(EnergyConsumption consumption)
        {
            // Lógica para interação com Azure OpenAI
            return $"Relatório gerado para o cliente {consumption.ClientId}.";
        }
    }
}
