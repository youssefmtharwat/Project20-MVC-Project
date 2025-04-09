using Microsoft.AspNetCore.Mvc;

namespace Project20.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
