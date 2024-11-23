using Microsoft.AspNetCore.Mvc;

namespace EnergyOptimization.IntegrationTests
{
    public class EnergyControllerTests : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
