using GamesStore2.Contexts;
using GamesStore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesStore2.Areas.admin.Controllers
{
    [Area("admin")]
    public class ReviewsController : Controller
    {
        private readonly GameStoreDbContext _context;


        public ReviewsController(GameStoreDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var AllReviews = _context.reviews.ToList();
            return View(AllReviews);
        }
        public IActionResult Info(int id)
        {
            var reviewsinfo = _context.reviews.Find(id);
            return View(reviewsinfo);
        }
        public IActionResult Create()
        {
            ViewBag.Games = _context.games;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Reviews reviews)
        {
            ViewBag.Games = _context.games;
            _context.reviews.Add(reviews);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            ViewBag.Games = _context.games;
            return View();
        }
        [HttpPost]
        public IActionResult Update(Reviews reviews)

        {
            if (ModelState.IsValid)
            {
                Reviews? updatedreviews = _context.reviews.Find(reviews.Id);
                if (updatedreviews == null) { return NotFound(); }
                updatedreviews.Id = reviews.Id;
                updatedreviews.Description = reviews.Description;
                updatedreviews.GameId = reviews.GameId;

                ViewBag.Games = _context.games;
                _context.reviews.Update(updatedreviews);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(reviews);
        }
        public IActionResult Delete(int Id)
        {
            Reviews? deledetreviews = _context.reviews.Find(Id);
            if (deledetreviews == null) { return NotFound(); }
            else
            {
                _context.reviews.Remove(deledetreviews);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
