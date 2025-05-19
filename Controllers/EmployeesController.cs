using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Create()
        {
            return View();
        }
    }
}
