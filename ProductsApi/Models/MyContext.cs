using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Models
{
    public class MyContext :DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductionOrder>()
            .HasOne<Product>()
            .WithMany()
            .HasForeignKey(p => p.ProductId);
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<ProductsApi.Models.ProductionOrder> ProductionOrder { get; set; }
    }
}
