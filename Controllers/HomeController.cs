using Microsoft.AspNetCore.Mvc;
using Project20.Models;
using System.Diagnostics;

namespace Project20.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        

        
        
    }
}
