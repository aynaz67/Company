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

        public VillaController(IVillaService villaService)
        {

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

            return Ok(new { Message = "Villa is deleted successfully", VillaID = villaId });
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateUpdateVillaDto dto)
        {
            await _villaService.AddVillasAsync(dto);
            return RedirectToAction("Index");
        }

        [HttpPut]
        [Route("{villaId:int}")]
        public async Task<IActionResult> Update(int villaId, [FromBody] VillaDto dto)
        {

            if (dto == null)
            {
                return BadRequest("Invalid request.");
            }

            var villa = await _villaService.GetVillasByIdAsync(villaId);
            if (villa == null)
                return NotFound("Villa Not Found");

            await _villaService.UpdateVillasAsync(dto);

            return Ok(new { Message = "Villa updated successfully", villaId = villaId });
        }
    }
}
