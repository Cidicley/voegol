using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> ListAsync();
    }
}
