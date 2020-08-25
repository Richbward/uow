using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace uow.Models
{
    public class uowContext : DbContext
    {
        public uowContext(DbContextOptions<uowContext> options) 
            : base(options)
        {

        }

        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<GarageModel> Garages { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<VehicleModel> Vehicles { get; set; }
    }
}
