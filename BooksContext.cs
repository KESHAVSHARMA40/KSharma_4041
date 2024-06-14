using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5CodeFirst
{
    public class BooksContext : DbContext
    {
        // entity sets 
        // which are defined in the form of DbSet<> properties

        public DbSet<Book>? Books { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        public DbSet<Order>? Orders { get; set; }



        // database connection information 
        // which is defined in the form of connection string 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;
                                        Database=BooksCF;
                                        Trusted_Connection=True;MultipleActiveResultSets=true;");

        }
    }
}
