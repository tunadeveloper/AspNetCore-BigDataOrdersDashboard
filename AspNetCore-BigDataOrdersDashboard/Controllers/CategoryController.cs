using AspNetCore_BigDataOrdersDashboard.Context;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_BigDataOrdersDashboard.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BigDataOrdersDbContext _context;

        public CategoryController(BigDataOrdersDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }
    }
}
