using GamesStore2.Contexts;
using GamesStore2.Models;
using GamesStore2.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace GamesStore2.Areas.admin.Controllers
{
    [Area("admin")]
    public class GamesController : Controller
    {
        private readonly GameStoreDbContext _context;
        private readonly IWebHostEnvironment _enviroment;

        public GamesController(GameStoreDbContext context,IWebHostEnvironment environment)
        {
            _context = context;
            _enviroment = environment;
        }
        public IActionResult Index()
        {
            var AllGames = _context.games.ToList();
            return View(AllGames);
        }
        public IActionResult Info(int id)
        {
            var gamesinfo=_context.games.Find(id);
            return View(gamesinfo);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Games games)
        {
            if (games.GamesPhoto != null)
            {

                if (games.GamesPhoto.Checktype() && games.GamesPhoto.CheckSize(5)) 
                {
                    
                    string fileName = games.GamesPhoto.UploadImage(_enviroment.WebRootPath, @"/Uploads/GamesPhoto/");

                    
                    games.GameImageUrl = @"/Uploads/GamesPhoto/" + fileName;
                }
                else
                {
                   
                    ModelState.AddModelError("GamesPhoto", "Size or Type doesnt true");
                    return View(games);
                }
            }
         
            _context.games.Add(games);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Update(Games games)

        {
            if (ModelState.IsValid)
            {
                Games? updatedGames = _context.games.Find(games.Id);
                if (games == null) { return NotFound(); }
                updatedGames.Id=games.Id;
                updatedGames.Name=games.Name;
                updatedGames.Description=games.Description;
                updatedGames.Price=games.Price;
                updatedGames.GameId = games.GameId;
                updatedGames.GameImageUrl = games.GameImageUrl;
                if (games.GamesPhoto != null)
                {
                   
                    if (games.GamesPhoto.Checktype() && games.GamesPhoto.CheckSize(5))
                    {
                        
                        string fileName = games.GamesPhoto.UploadImage(_enviroment.WebRootPath, @"/Uploads/GamesPhoto/");
                        updatedGames.GameImageUrl = @"/Uploads/GamesPhoto/" + fileName;
                    }
                    else
                    {
                        ModelState.AddModelError("GamesPhoto", "Size or Type is not correct.");
                        return View(games);  
                    }
                    
                    _context.games.Update(updatedGames);
                _context.SaveChanges();
                return RedirectToAction("Index");
                }

            }
            return View(games);
        }
        public IActionResult Delete(int Id)
        {
            Games? deletedgames = _context.games.Find(Id);
            if (deletedgames == null) { return NotFound(); }
            else
            {
                _context.games.Remove(deletedgames);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
