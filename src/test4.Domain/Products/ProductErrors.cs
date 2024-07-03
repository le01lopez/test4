using test4.Domain.Abstractions;

namespace test4.Domain.Products;

public static class ProductErrors
{
    public static Error NotFound = new(
        "Property.Found",
        "The property with the specified identifier was not found");
}
