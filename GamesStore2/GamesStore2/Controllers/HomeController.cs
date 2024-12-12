using Microsoft.AspNetCore.Mvc;

namespace GamesStore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
