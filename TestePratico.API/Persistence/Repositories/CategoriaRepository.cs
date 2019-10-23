using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.Persistence.Contexts;

namespace TestePratico.API.Persistence.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
        }

        public async Task<Categoria> FindByAsync(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public void Remove(Categoria categoria)
        {
            _context.Categorias.Remove(categoria);
        }

        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}
