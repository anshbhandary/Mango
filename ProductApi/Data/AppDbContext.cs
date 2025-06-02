using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

       public DbSet<Product> Products { get ; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                ProductName = "Mobile",
                ProductCategory = "Tech",
                ProductDescription = "Description",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                ProductName = "Car",
                ProductCategory = "Mech",
                ProductDescription = "Description",
            });

        }
    }
}
