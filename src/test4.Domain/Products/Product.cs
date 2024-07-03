using test4.Domain.Abstractions;
using test4.Domain.Products.Events;

namespace test4.Domain.Products;

public sealed class Product : Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }

    private Product()
    {
    }

    private Product(
        Guid id,
        Name name,
        Description description) : base(id)
    {
        Name = name;
        Description = description;
    }
    
    public static Result<Product> Create(
        Name name,
        Description description)
    {
        var product = new Product(Guid.NewGuid(), name, description);
        
        product.RaiseDomainEvent(new ProductCreatedDomainEvent(product.Id));
        
        return Result.Success(product);
    }
    
    public void Update(
        Name name,
        Description description)
    {
        Name = name;
        Description = description;
    }
}
