using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Repositories
{
    public interface IAirplaneRepository
    {
        Task<IEnumerable<Airplane>> GetAllAirplaneAsync();        

        /// <summary>
        /// Insere Airplane
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Airplane> InsertAirplaneAsync(Airplane request);

        Task<Airplane> FindAirplaneAsync(int id);        
    }
}
