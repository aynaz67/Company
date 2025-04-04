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

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Villa VillaEntity)
        {
            if (ModelState.IsValid)
            {
                await _villaService.AddVillasAsync(VillaEntity);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Update(int villaId)
        {
            var villa = await _villaService.GetVillasByIdAsync(villaId);
            return View(villa);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Villa VillaEntity)
        {
          var result=  await _villaService.UpdateVillasAsync(VillaEntity);
            return View();
        }   

        
        public async Task<IActionResult> Delete(int villaId)
        {
            await _villaService.DeleteVillasAsync(villaId);
            return RedirectToAction("Index");
        }


    }
}
