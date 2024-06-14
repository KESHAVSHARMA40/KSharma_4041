using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_KeshavSharma_4532854
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int quantity { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
