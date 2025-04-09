using Microsoft.AspNetCore.Mvc;

namespace Project20.Controllers
{
    public class DBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Dashboardv1()
        {
            return View();
        }
        public IActionResult Widgets()
        {
            return View();
        }
        public IActionResult Emails()
        {
            return View();
        }
    }
}
