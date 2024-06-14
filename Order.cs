using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5CodeFirst
{
    public class Order
    {
        //scalar properties 
        public int OrderId { get; set; }
        public int? BookId { get; set; }

        public int? CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        // navigation properties 
        public Book? Book { get; set; }
        public Customer? Customer { get; set; }
    }
}
