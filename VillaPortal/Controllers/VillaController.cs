using Company.Application.DTOs;
using Company.Application.Interface;
using Company.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace VillaPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly IVillaService _villaService;
        
        public VillaController( IVillaService villaService) { 
        
            _villaService = villaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var villas = await _villaService.GetVillasAsync();
            if (villas == null)
            {
                return NotFound("Village not found");
            }
            return Ok(villas);
        }

        [HttpPatch]
        [Route("{villaId:int}")]
        public async Task<IActionResult> Delete([FromRoute] int villaId)
        {
            var result = await _villaService.DeleteVillasAsync(villaId);
            if (!result)
                return NotFound("Villa not found");

            return Ok(new { Message = "Villa is deleted successfully", VillaID = villaId});
        }


        [HttpPost]
        
        public async Task<IActionResult> Create(CreateUpdateVillaDto dto)
        {
            await _villaService.AddVillasAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
