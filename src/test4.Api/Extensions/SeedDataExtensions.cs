using test4.Domain.Products;
using test4.Infrastructure;

namespace test4.Api.Extensions;

public static class SeedDataExtensions
{
    public static void SeedData(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<ApplicationDbContext>();

        if (context.Products.Any())
        {
            return;
        }

        var products = new List<Product>
        {
            Product.Create(new Name("Product 1"), new Description("Description 1")).Value,
            Product.Create(new Name("Product 2"), new Description("Description 2")).Value,
            Product.Create(new Name("Product 3"), new Description("Description 3")).Value
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}
