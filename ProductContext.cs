using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_KeshavSharma_4532854
{
    public class ProductContext : DbContext
    { 
            public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=ProductCF;
            Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
