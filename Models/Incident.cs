using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assig1ProtoType.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }
        public string Title { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int TechnicianId { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Technician Technician { get; set; }
    }
}
