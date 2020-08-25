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
        public int Id { get; set; }

        public Guid GUID { get; set; }

        public int GarageId { get; set; }
        public int VehicleId { get; set; }        
        public DateTime Entered { get; set; }
        public DateTime Exited { get; set; }
        public decimal Discount { get; set; }
        public decimal Charge { get; set; }
    }
}
