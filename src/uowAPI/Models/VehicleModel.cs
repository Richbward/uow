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
        public int Id { get; set; }

        public Guid GUID { get; set; }

        public int CustomerId { get; set; }

        public string PlateNumber { get; set; }
        
        public string State { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }
}
