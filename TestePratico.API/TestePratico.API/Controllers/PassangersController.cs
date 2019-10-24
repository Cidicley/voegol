using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangersController : ControllerBase
    {
        private readonly IPassangerService _passangerService;

        public PassangersController(IPassangerService passangerService)
        {
            _passangerService = passangerService;
        }        

        //[HttpPost]
        //public async Task<ActionResult<Passanger>> InsertPassanger(Passanger request)
        //{
        //    await _passangerService.InsertPassangerAsync(request);

        //    return CreatedAtAction(nameof(FindPassangerAsync), new { id = request.Id }, request);
        //}

        //[HttpGet("{id}")]
        //public async Task<Passanger> FindPassangerAsync(int id)
        //{
        //    return await _passangerService.FindPassangerAsync(id);
        //}

        //[HttpPost]
        //public async Task<ActionResult<PassangerToAirplane>> InsertPassangerToAirplane(PassangerToAirplane request)
        //{
        //    await _passangerService.InsertPassangerToAirplaneAsync(request);

        //    return CreatedAtAction(nameof(FindPassangerToAirplanerAsync), new { id = request.Id }, request);
        //}

        //[HttpGet("{id}")]
        //public async Task<PassangerToAirplane> FindPassangerToAirplanerAsync(int id)
        //{
        //    return await _passangerService.FindPassangerToAirplanerAsync(id);
        //}


        //[HttpGet("{idAirplane}")]
        //public async Task<PassangerToAirplane> ListAllPassangerByAirplane(int idAirplane)
        //{
        //    return await _passangerService.ListAllPassangerByAirplaneAsync(idAirplane);
        //}
    }
}
 