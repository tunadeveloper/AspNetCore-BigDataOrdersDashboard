using AspNetCore_BigDataOrdersDashboard.Context;
using AspNetCore_BigDataOrdersDashboard.Entities;
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

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _context.Categories.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var values = _context.Categories.Find(id);
            _context.Categories.Remove(values);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
