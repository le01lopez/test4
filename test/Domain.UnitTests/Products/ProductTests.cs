using FluentAssertions;
using test4.Domain.Products;
using test4.Domain.Products.Events;

namespace Domain.UnitTests.Products;

public class ProductTests
{
    [Fact]
    public void Create_Should_CreateProduct_WhenNameIsValid()
    {
        // Arrange
        var name = new Name("Full Name");
        var description = new Description("Description");

        // Act
        var product = Product.Create(name, description);

        // Assert
        product.Should().NotBeNull();
    }

    [Fact]
    public void Create_Should_RaiseDomainEvent_WhenNameIsValid()
    {
        // Arrange
        var name = new Name("Full Name");
        var description = new Description("Description");

        // Act
        var product = Product.Create(name, description);

        // Assert
        product.Value.GetDomainEvents()
            .Should().ContainSingle()
            .Which
            .Should().BeOfType<ProductCreatedDomainEvent>();
    }
}
