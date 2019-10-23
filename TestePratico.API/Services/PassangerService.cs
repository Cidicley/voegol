using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Services
{
    public class PassangerService : IPassangerService
    {
        private readonly IPassangerRepository _passangerRepository;

        public PassangerService(IPassangerRepository passangerRepository)
        {
            _passangerRepository = passangerRepository;
        }

        public async Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane)
        {
            return await _passangerRepository.ChangePassangerAsync(id, IdAirplane);
        }

        public async Task<Passanger> InsertPassangerAsync(Passanger request)
        {
            return await _passangerRepository.InsertPassangerAsync(request);
        }

        public async Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request)
        {
            return await _passangerRepository.InsertPassangerToAirplaneAsync(request);
        }

        public async Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane)
        {
            return await _passangerRepository.ListAllPassangerByAirplaneAsync(idAirplane);
        }
    }
}
