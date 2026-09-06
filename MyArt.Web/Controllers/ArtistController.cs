using Microsoft.AspNetCore.Mvc;
using MyArt.Web.Data;
using MyArt.Web.Models;

namespace MyArt.Web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ArtistController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var artists = _context.Artists.ToList();
            return View(artists);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ActionName("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePOST(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = _context.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [ActionName("Update")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePOST(Artist artist)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = _context.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int id)
        {
            var artist = _context.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }
            _context.Artists.Remove(artist);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
