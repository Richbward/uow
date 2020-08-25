using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Entities;

namespace uowAPI.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly uowContext _context;

        public CustomersRepository(uowContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
