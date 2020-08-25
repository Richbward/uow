using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public class VehiclesRepository : IVehiclesRepository
    {
        private readonly uow.Entities.uowContext _context;
        private readonly ILogger<TransactionsRepository> _logger;

        public VehiclesRepository(uow.Entities.uowContext context,
            ILogger<TransactionsRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }
    }
}
