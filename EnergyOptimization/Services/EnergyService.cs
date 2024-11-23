using EnergyOptimization.DTOs;
using EnergyOptimization.Entities;
using EnergyOptimization.Factories;
using EnergyOptimization.Interfaces;

namespace EnergyOptimization.Services
{
    public class EnergyService : IEnergyService
    {
        private readonly IRepository<EnergyConsumption> _repository;
        private readonly IReportFactory _reportFactory;

        public EnergyService(IRepository<EnergyConsumption> repository, IReportFactory reportFactory)
        {
            _repository = repository;
            _reportFactory = reportFactory;
        }

        public async Task<string> AnalyzeConsumptionAsync(EnergyConsumptionDTO dto)
        {
            var entity = new EnergyConsumption
            {
                ClientId = dto.ClientId,
                ConsumptionData = dto.ConsumptionData
            };

            await _repository.AddAsync(entity);

            var report = await _reportFactory.GenerateReportAsync(entity);
            return report;
        }
    }
}
