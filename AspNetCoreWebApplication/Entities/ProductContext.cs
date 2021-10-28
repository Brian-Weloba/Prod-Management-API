using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Dtos;

namespace ProductManagementAPI.Entities
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products {get; set;}
        public DbSet<ProductCategory> ProductCategory {get; set;}
        public DbSet<ProductAttributes> ProductAttributes {get; set;}

    }
}