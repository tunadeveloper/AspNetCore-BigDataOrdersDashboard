using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
