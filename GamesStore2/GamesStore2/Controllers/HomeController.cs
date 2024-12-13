using Microsoft.AspNetCore.Mvc;

namespace GamesStore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }
    }
}
