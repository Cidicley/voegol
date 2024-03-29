﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.API.domain.Models;
using TestePratico.API.domain.Repositories;
using TestePratico.API.Persistence.Contexts;

namespace TestePratico.API.Persistence.Repositories
{
    public class PassangerRepository : BaseRepository, IPassangerRepository
    {
        #region Contrutor
        public PassangerRepository(AppDbContext context) : base(context)
        {
        } 
        #endregion

        public async Task<Passanger> FindPassangerAsync(int id)
        {
            return await _context.Passangers.FindAsync(id);
        }

        public async Task<Passanger> InsertPassangerAsync(Passanger request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            await _context.Passangers.AddAsync(request);

            await _context.SaveChangesAsync();

            return request;
        }

        public async Task<IEnumerable<Passanger>> GetAllPassangerAsync()
        {
            return await _context.Passangers.ToListAsync();
        }

        //public async Task<PassangerToAirplane> ChangePassangerAsync(int id, int IdAirplane)
        //{
        //    PassangerToAirplane passangerToAirplane = new PassangerToAirplane();
        //    passangerToAirplane.IdAirplane = IdAirplane;

        //    _context.Entry(passangerToAirplane).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        throw;
        //    }

        //    return passangerToAirplane;

        //}        

        //public async Task<PassangerToAirplane> FindPassangerToAirplanerAsync(int id)
        //{
        //    return await _context.PassangersToAirplane.FindAsync(id);
        //}        

        //public async Task<PassangerToAirplane> InsertPassangerToAirplaneAsync(PassangerToAirplane request)
        //{
        //    if (request == null)
        //    {
        //        throw new ArgumentNullException("request");
        //    }

        //    await _context.PassangersToAirplane.AddAsync(request);

        //    await _context.SaveChangesAsync();

        //    return request;
        //}

        //public async Task<PassangerToAirplane> ListAllPassangerByAirplaneAsync(int idAirplane)
        //{
        //    return await _context.PassangersToAirplane.FindAsync(idAirplane); 
        //}        
    }
}
