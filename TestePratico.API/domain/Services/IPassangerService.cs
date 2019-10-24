using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Services
{
    public interface IPassangerService
    {
        Task<Passanger> InsertPassangerAsync(Passanger request);

        Task<Passanger> FindPassangerAsync(int id);

        Task<IEnumerable<Passanger>> GetAllPassangerAsync();

        //Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request);

        //Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane);

        //Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane);

        //Task<PassangerToAirplane> FindPassangerToAirplanerAsync(int id);        
    }
}
