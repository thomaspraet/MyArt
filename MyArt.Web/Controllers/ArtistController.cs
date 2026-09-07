using Microsoft.AspNetCore.Mvc;
using MyArt.Business.Services.IServices;
using MyArt.Models;

namespace MyArt.DataAccess.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<IActionResult> Index()
        {
            var artists = await _artistService.GetAllArtistsAsync();
            return View(artists);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [ActionName("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST(Artist artist)
        {
            await _artistService.CreateArtistAsync(artist);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = await _artistService.GetArtistByIdAsync(id.Value);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [ActionName("Update")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePOST(Artist artist)
        {
            await _artistService.UpdateArtistAsync(artist);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var artist = await _artistService.GetArtistByIdAsync(id.Value);
            if (artist == null)
            {
                return NotFound();
            }

            return View(artist);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePOST(int id)
        {
            await _artistService.DeleteArtistAsync(id);
            return RedirectToAction("Index");
        }
    }
}
