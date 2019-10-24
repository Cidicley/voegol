using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Services;

namespace TestePratico.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var categorias = await _categoriaService.ListAsync();
            return categorias;
        }
    }
}