using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Entities
{
    [Table("Customers")]
    public class Customer
    {        
        [Key]
        public Guid Id { get; set; }

        [MaxLength(25)] 
        public string Prefix { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [MaxLength(50)] 
        public string MiddleName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(25)] 
        public string Suffix { get; set; }
        
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

        [MaxLength(50)] 
        public string BusinessPhone { get; set; }

        [MaxLength(50)] 
        public string HomePhone { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string MobilePhone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required] 
        public DateTime ClientSince { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool Active { get; set; }
    }
}
