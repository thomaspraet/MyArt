using Microsoft.AspNetCore.Mvc;
using MyArt.Web.Data;
using MyArt.Web.Models;

namespace MyArt.Web.Controllers
{
    public class TechnicController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TechnicController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var technics = _context.Technics.ToList();
            return View(technics);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ActionName("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePOST(Technic technic)
        {
            _context.Technics.Add(technic);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = _context.Technics.Find(id);
            if (technic == null)
            {
                return NotFound();
            }

            return View(technic);
        }

        [ActionName("Update")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePOST(Technic technic)
        {
            _context.Technics.Update(technic);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = _context.Technics.Find(id);
            if (technic == null)
            {
                return NotFound();
            }

            return View(technic);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int id)
        {
            var technic = _context.Technics.Find(id);
            if (technic == null)
            {
                return NotFound();
            }
            _context.Technics.Remove(technic);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
