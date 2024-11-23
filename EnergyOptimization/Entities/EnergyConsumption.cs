namespace EnergyOptimization.Entities
{
    public class EnergyConsumption
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public List<double> ConsumptionData { get; set; }
    }
}
