using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Entities
{
    [Table("Garages")]
    public class Garage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Street1 { get; set; }

        [MaxLength(50)]
        public string Street2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [MaxLength(12)]
        public string Zip { get; set; }

        [Required]
        [MaxLength(100)]
        public string Contact { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }

        [Required]
        public DateTime ClientSince { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool Active { get; set; }
    }
}
