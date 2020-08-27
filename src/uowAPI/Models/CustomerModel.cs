using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }

        public string Prefix { get; set; }

        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }

        public string Suffix { get; set; }
        
        public string Street1 { get; set; }

        public string Street2 { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Zip { get; set; }

        public string BusinessPhone { get; set; }

        public string HomePhone { get; set; }
        
        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public DateTime ClientSince { get; set; }

        public bool Active { get; set; }
    }
}
