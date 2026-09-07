using Microsoft.AspNetCore.Mvc;
using MyArt.Business.Services.IServices;
using MyArt.Models;

namespace MyArt.DataAccess.Controllers
{
    public class TechnicController : Controller
    {
        private readonly ITechnicService _technicService;
        public TechnicController(ITechnicService technicService)
        {
            _technicService = technicService;
        }

        public async Task<IActionResult> Index()
        {
            var technics = await _technicService.GetAllTechnicsAsync();
            return View(technics);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [ActionName("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST(Technic technic)
        {
            await _technicService.CreateTechnicAsync(technic);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = await _technicService.GetTechnicByIdAsync(id.Value);
            if (technic == null)
            {
                return NotFound();
            }

            return View(technic);
        }

        [ActionName("Update")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePOST(Technic technic)
        {
            await _technicService.UpdateTechnicAsync(technic);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var technic = await _technicService.GetTechnicByIdAsync(id.Value);
            if (technic == null)
            {
                return NotFound();
            }

            return View(technic);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _technicService.DeleteTechnicAsync(id);
            return RedirectToAction("Index");
        }
    }
}
