using Company.Application.Services;
using Company.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CompanyWeb.Controllers
{
    [Authorize]
    public class VillaController : Controller
    {
        private readonly VillaService _villaService;

        public VillaController(VillaService villaService)
        {
            _villaService = villaService;
        }

        public async Task<IActionResult> Index()
        {
            var villas = await _villaService.GetVillasAsync();
            return View(villas);

        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Prevent CSRF attacks
        public async Task<IActionResult> Create(CreateUpdateVillaDto dto)
        {
            await _villaService.AddVillasAsync(dto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int villaId)
        {
            var villa = await _villaService.GetVillasByIdAsync(villaId);
            if (villa == null)
                return NotFound();

            var villaDto = new VillaDto
            {
                Name = villa.Name,
                Description = villa.Description,
                Id = villa.Id,
            };

            return View(villaDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(VillaDto dto)
        {
            var result = await _villaService.UpdateVillasAsync(dto);
            if (result)
                return RedirectToAction("Index");

            return NotFound();
        }


        public async Task<IActionResult> Delete(int villaId)
        {
            var result = await _villaService.DeleteVillasAsync(villaId);
            if (!result)
                return NotFound();

            return RedirectToAction("Index");
        }
    }
}