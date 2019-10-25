using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Services;

namespace TestePratico.ConsoleApp
{
    class Program
    {
        private static readonly IAirplaneService _airplaneService;

        //public Program(IAirplaneService airplaneService)
        //{
        //    _airplaneService = airplaneService;
        //}

        private static async Task GetAllAirplaneAsync()
        {
            //Arranje - Cenário
            var boing = new Airplane { Id = 1000, Nome = "Avião teste" };

            //Act - método de teste
            IEnumerable<Airplane> retorno = await _airplaneService.GetAllAirplaneAsync();


            Console.WriteLine("teste");
        }

        static void Main()
        {
            GetAllAirplaneAsync();

        }
    }
}
