using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneService _airplaneService;

        public AirplaneController(IAirplaneService airplaneService)
        {
            _airplaneService = airplaneService;
        }

        [HttpGet]
        public async Task<IEnumerable<Airplane>> GetAllAirplane()
        {
            return await _airplaneService.GetAllAirplaneAsync();
        }

        [HttpGet("{id}")]
        public async Task<Airplane> FindAirplaneAsync(int id)
        {
            return await _airplaneService.FindAirplaneAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Airplane>> InsertAirplaneAsync(Airplane request)
        {            
            await _airplaneService.InsertAirplaneAsync(request);

            return CreatedAtAction(nameof(FindAirplaneAsync), new { id = request.Id }, request);
        }
    }
}