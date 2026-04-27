using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
