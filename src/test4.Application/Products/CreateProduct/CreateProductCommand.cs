using test4.Application.Abstractions.Messaging;

namespace test4.Application.Products.CreateProduct;

public record CreateProductCommand(string Name, string Description) : ICommand<Guid>;
