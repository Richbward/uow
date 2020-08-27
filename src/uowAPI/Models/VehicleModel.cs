using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Models
{
    public class VehicleModel
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public string PlateNumber { get; set; }
        
        public string State { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }
}
