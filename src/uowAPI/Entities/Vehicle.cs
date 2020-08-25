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
        public int Id { get; set; }

        [Required]
        public Guid GUID { get; set; }

        [ForeignKey("Customer")] 
        public int CustomerId { get; set; }

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
