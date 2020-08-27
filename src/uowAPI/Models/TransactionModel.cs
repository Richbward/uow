using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Models
{
    public class TransactionModel
    {
        public Guid Id { get; set; }

        public Guid GarageId { get; set; }
        public Guid VehicleId { get; set; }        
        public DateTime Entered { get; set; }
        public DateTime Exited { get; set; }
        public decimal Discount { get; set; }
        public decimal Charge { get; set; }
    }
}
