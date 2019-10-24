using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Repositories
{
    public interface IPassangerRepository
    {
        Task<IEnumerable<Passanger>> GetAllPassangerAsync();

        Task<Passanger> InsertPassangerAsync(Passanger request);

        Task<Passanger> FindPassangerAsync(int id);

        //Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request);

        //Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane);

        //Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane);        

        //Task<PassangerToAirplane> FindPassangerToAirplanerAsync(int id);        
    }
}
