using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.Persistence.Contexts;

namespace TestePratico.API.Persistence.Repositories
{
    public class AirplaneRepository : BaseRepository, IAirplaneRepository
    {
        public AirplaneRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Airplane> FindAirplaneAsync(int id)
        {
            return await _context.Airplanes.FindAsync(id);
        }

        public async Task<IEnumerable<Airplane>> GetAllAirplaneAsync()
        {
            return await _context.Airplanes.ToListAsync();
        }

        /// <summary>
        /// Insere Airplane
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>        
        async Task<Airplane> IAirplaneRepository.InsertAirplaneAsync(Airplane request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            await _context.Airplanes.AddAsync(request);

            await _context.SaveChangesAsync();

            return request;
        }
    }
}
