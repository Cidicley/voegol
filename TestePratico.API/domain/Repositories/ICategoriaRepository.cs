using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;

namespace TestePratico.API.domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListAsync();

        Task AddAsync(Categoria categoria);

        Task<Categoria> FindByAsync(int id);

        void Update(Categoria categoria);

        void Remove(Categoria categoria);
    }
}
