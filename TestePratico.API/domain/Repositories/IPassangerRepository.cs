using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Repositories
{
    public interface IPassangerRepository
    {
        Task<Passanger> InsertPassangerAsync(Passanger request);

        Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request);

        Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane);

        Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane);
    }
}
