using ProductApi.Models;

namespace ProductApi.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Products.Any()) return;

            context.Products.AddRange(new[] {
                new Product { Name = "Laptop", Description = "Powerful laptop", Price = 1200M },
                new Product { Name = "Smartphone", Description = "Latest model", Price = 800M },
                new Product { Name = "Tablet", Description = "Lightweight tablet", Price = 400M }
            });
            context.SaveChanges();
        }
    }
}
