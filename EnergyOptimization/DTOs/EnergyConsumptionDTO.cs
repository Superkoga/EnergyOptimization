namespace EnergyOptimization.DTOs
{
    public class EnergyConsumptionDTO
    {
        public string ClientId { get; set; }
        public List<double> ConsumptionData { get; set; }
    }
}
