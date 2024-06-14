using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5CodeFirst
{
    public class Customer
    { 
        // scalar properties
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set;}
    
       // navigation properties
       public ICollection<Order>? Orders { get; set; }
    }
}
