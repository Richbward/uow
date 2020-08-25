using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public class GaragesRepository : IGaragesRepository
    {
        private readonly uowContext _context;

        public GaragesRepository(uowContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Garage>> GetGaragesAsync()
        {
            return await _context.Garages.ToListAsync();
        }
    }
}
