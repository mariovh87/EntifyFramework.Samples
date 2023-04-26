using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Samples.Data.Models.ContosoPizza;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Samples.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                    new() { CustomerId = 1, FirstName = "Carson", LastName = "Alexander", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 2, FirstName = "Meredith", LastName = "Alonso", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 3, FirstName = "Arturo", LastName = "Anand", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 4, FirstName = "Gytis", LastName = "Barzdukas", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 5, FirstName = "Yan", LastName = "Li", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 6, FirstName = "Peggy", LastName = "Justice", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 7, FirstName = "Laura", LastName = "Norman", Address = "1234 Main St", Phone = "555-555-5555" },
                    new() { CustomerId = 8, FirstName = "Nino", LastName = "Olivetto", Address = "1234 Main St", Phone = "555-555-5555" });

            modelBuilder.Entity<Product>()
                .HasData(
                    new() { ProductId = 1, Name = "Pizza Margherita", Price = 10.00m },
                    new() { ProductId = 2, Name = "Pizza Marinara", Price = 10.00m },
                    new() { ProductId = 3, Name = "Pizza Quattro Stagioni", Price = 10.00m },
                    new() { ProductId = 4, Name = "Pizza Quattro Formaggi", Price = 10.00m },
                    new() { ProductId = 5, Name = "Pizza Capricciosa", Price = 10.00m },
                    new() { ProductId = 6, Name = "Pizza Funghi", Price = 12.00m },
                    new() { ProductId = 7, Name = "Pizza Prosciutto", Price = 12.00m });
        }
    }
}
