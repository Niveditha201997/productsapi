using Microsoft.EntityFrameworkCore;
using ProductEntity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Data
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<Article> article{ get; set; }
        public DbSet<Colour> colour { get; set; } 
        public DbSet<Product> product { get; set; }
        public DbSet<Size> size { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data source=VDC01LTC2013;Initial Catalog=ProductProjectDb; Integrated Security=True;");
        }

    }
}
