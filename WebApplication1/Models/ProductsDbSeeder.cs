using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any flowers.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Televizor",
                    Description = "Pentru Vizualizare",
                    Category = "Electronice",
                    Price = 5.00
                },
                new Product
                {
                    Name = "Frigider",
                    Description = "Pentru Racire",
                    Category = "Frigorifice",
                    Price = 15.00
                }
            );
            context.SaveChanges();
        }
    }
}
