using Microsoft.AspNetCore.Mvc;
using EnergyOptimization.DTOs;
using EnergyOptimization.Services;
using EnergyOptimization.Interfaces;

namespace EnergyOptimization.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnergyController : ControllerBase
    {
        private readonly IEnergyService _energyService;

        public EnergyController(IEnergyService energyService)
        {
            _energyService = energyService;
        }

        [HttpPost("analyze")]
        public async Task<IActionResult> AnalyzeEnergyConsumption([FromBody] EnergyConsumptionDTO consumption)
        {
            var report = await _energyService.AnalyzeConsumptionAsync(consumption);
            return Ok(report);
        }
    }
}
