using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Details(int id)
        {
            var categories = context.Categories.FirstOrDefault(c => c.Id == id);
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var category = context.Categories.FirstOrDefault(c => c.Id == id);
            if (category is null)
            {
                return NotFound();
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
