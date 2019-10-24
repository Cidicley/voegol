using TestePratico.API.Persistence.Contexts;

namespace TestePratico.API.Persistence.Repositories
{
    public class BaseRepository
    {

        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
