using EntityFramework.Samples.Data.Extensions;
using EntityFramework.Samples.Data.Models.ContosoPizza;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Samples.Data.Data
{
    public class ContosoPizzaContext:DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Customer?> Customers { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ContosoPizza;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });

            // Cargando datos iniciales
            modelBuilder.Seed();
        }

    }
}
