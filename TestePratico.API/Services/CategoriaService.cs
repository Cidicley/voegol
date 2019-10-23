using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Task<IEnumerable<Categoria>> ListAsync()
        {
            return _categoriaRepository.ListAsync();
        }


    }
}
