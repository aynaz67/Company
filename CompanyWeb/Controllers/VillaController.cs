using Company.Application.Services;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVillas()
        {
            var products = await _villaService.GetProductsAsync();
            return Ok(products);
        }     
    }
}
