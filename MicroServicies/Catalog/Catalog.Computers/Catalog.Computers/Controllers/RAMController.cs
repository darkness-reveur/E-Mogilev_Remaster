using Catalog.Computers.Infrastructure.Services.ComputerComponents.Interfacies;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Computers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RAMController : Controller
    {
        private readonly IRAMService _RAMService;

        [HttpGet]
        [Route("GetAllCars")]
        public async Task<IActionResult> GetAllRAMs()
        {
            var RAMs = await _RAMService
                .GetAllRAMsAsync();

            if (RAMs is null)
            {
                return BadRequest();
            }

            return Ok(RAMs);
        }
    }
}
