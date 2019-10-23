using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Services
{
    public interface IPassangerService
    {
        Task<Passanger> InsertPassangerAsync(Passanger request);

        Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request);

        Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane);

        Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane);

        Task<Passanger> FindPassangerAsync(int id);

        Task<PassangerToAirplane> FindPassangerToAirplanerAsync(int id);        
    }
}
