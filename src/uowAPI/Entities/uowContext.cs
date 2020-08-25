using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace uow.Entities
{
    public class uowContext : DbContext
    {
        public uowContext(DbContextOptions<uowContext> options) 
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
