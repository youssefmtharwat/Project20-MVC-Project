using Microsoft.AspNetCore.Mvc;

namespace Project20.Controllers
{
    public class ComingSoonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
