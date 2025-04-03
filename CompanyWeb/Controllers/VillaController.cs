using Company.Application.Services;
using Company.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWeb.Controllers
{
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVillasById(int id)
        {
            var villa = await _villaService.GetVillasByIdAsync(id);
            return Ok(villa);
        }

        [HttpPost]
        public async Task<IActionResult> AddVillas(Villa VillaEntity)
        {
            await _villaService.AddVillasAsync(VillaEntity);
            return View();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVillas(Villa VillaEntity)
        {
            await _villaService.UpdateVillasAsync(VillaEntity);
            return View();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillas(int id)
        {
            await _villaService.DeleteVillasAsync(id);
            return View();
        }


    }
}
