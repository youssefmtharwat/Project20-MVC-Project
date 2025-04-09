using Microsoft.AspNetCore.Mvc;

namespace Project20.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
