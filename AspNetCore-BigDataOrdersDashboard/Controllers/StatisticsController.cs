using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
