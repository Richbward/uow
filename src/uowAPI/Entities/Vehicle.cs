using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Entities
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Customer")] 
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [MaxLength(20)]
        public string PlateNumber { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)] 
        public string Make { get; set; }

        [MaxLength(50)] 
        public string Model { get; set; }
    }
}
