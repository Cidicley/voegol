using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Services
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IAirplaneRepository _airplaneRepository;

        public AirplaneService(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }

        public async Task<Airplane> FindAirplaneAsync(int id)
        {
            return await _airplaneRepository.FindAirplaneAsync(id);
        }

        public async Task<IEnumerable<Airplane>> GetAllAirplaneAsync()
        {
            return await _airplaneRepository.GetAllAirplaneAsync();
        }        

        public async Task<Airplane> InsertAirplaneAsync(Airplane request)
        {
            return await _airplaneRepository.InsertAirplaneAsync(request);
        }
    }
}
