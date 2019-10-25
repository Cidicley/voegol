using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Services;
using TestePratico.API.Services;
using Xunit;

namespace TestePratico.Tests
{
    public class AirplaneTest
    {
        private readonly IAirplaneService _airplaneService;

        public AirplaneTest(IAirplaneService airplaneService)
        {
            _airplaneService = airplaneService;
        }

        [Fact]
        public async Task GetAllAirplaneAsync()
        {
            //Arranje - Cenário            


            //Act - método de teste
            IEnumerable<Airplane> retorno = await _airplaneService.GetAllAirplaneAsync();

            Assert.NotEmpty(retorno);
        }
    }
}
