using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Entities
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid GUID { get; set; }

        [ForeignKey("Garage")] 
        public int GarageId { get; set; }

        [ForeignKey("Vehicle")] 
        public int VehicleId { get; set; }
        
        // Doing this just for testing
        [Required]
        public DateTime Entered
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }

        private DateTime? dateCreated = null;



        public DateTime Exited { get; set; }
        [Column(TypeName = "decimal(5, 2)")] 
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(5, 2)")] 
        public decimal Charge { get; set; }
    }
}
