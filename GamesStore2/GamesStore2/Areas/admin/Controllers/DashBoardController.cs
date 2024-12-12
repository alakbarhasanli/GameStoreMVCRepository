using Microsoft.AspNetCore.Mvc;

namespace GamesStore2.Areas.admin.Controllers
{
    [Area("admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
