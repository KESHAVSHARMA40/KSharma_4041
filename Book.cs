using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//week6
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace W5CodeFirst
{
    [Table("BookMaster")] //week6
    public class Book
    {
        // scalar properties
        public int BookId { get; set; }
        [Column("BookTitle")]
        [MaxLength(50)]//week6
        public string? Title { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        // navigation properties

        public ICollection<Order>? Orders { get; set; }


    }
}
