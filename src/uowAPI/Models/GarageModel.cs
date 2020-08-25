using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace uow.Models
{
    public class GarageModel
    {
        public int Id { get; set; }

        public Guid GUID { get; set; }

        public string Name { get; set; }
        
        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Url { get; set; }

        public DateTime ClientSince { get; set; }

        public bool Active { get; set; }
    }
}
