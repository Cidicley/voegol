using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Services
{
    public interface IAirplaneService
    {
        Task<IEnumerable<Airplane>> GetAllAirplaneAsync();

        Task<Airplane> FindAirplaneAsync(int id);

        /// <summary>
        /// Insere Airplane
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Airplane> InsertAirplaneAsync(Airplane request);        
    }
}
