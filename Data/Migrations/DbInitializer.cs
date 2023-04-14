using EntityFramework.Samples.Data.Data;
using EntityFramework.Samples.Data.Models.ContosoPizza;

namespace EntityFramework.Samples.Data.Migrations
{
    public static class DbInitializer
    {
        public static void Initialize(ContosoPizzaContext context)
        {
            context.Database.EnsureCreated();
      
            if (context.Customers.Any())
            {
                return; // DB has been seeded
            }
 
            var customers = new Customer[]
            {
                new() {FirstName = "Carson", LastName = "Alexander", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Meredith", LastName = "Alonso", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Arturo", LastName = "Anand", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Gytis", LastName = "Barzdukas", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Yan", LastName = "Li", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Peggy", LastName = "Justice", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Laura", LastName = "Norman", Address = "1234 Main St", Phone = "555-555-5555"},
                new() {FirstName = "Nino", LastName = "Olivetto", Address = "1234 Main St", Phone = "555-555-5555"}
            };
            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
            }
   
  
            var products = new Product[]
            {
                new() {Name = "Pizza Margherita", Price = 10.00m},
                new() {Name = "Pizza Marinara", Price = 10.00m},
                new() {Name = "Pizza Quattro Stagioni", Price = 10.00m},
                new() {Name = "Pizza Quattro Formaggi", Price = 10.00m},
                new() {Name = "Pizza Capricciosa", Price = 10.00m},
                new() {Name = "Pizza Funghi", Price = 12.00m},
                new () {Name = "Pizza Prosciutto", Price = 12.00m}
            };
            foreach (var product in products)   
            {
                context.Products.Add(product);
            }


            context.SaveChanges();
        }
    }
}
