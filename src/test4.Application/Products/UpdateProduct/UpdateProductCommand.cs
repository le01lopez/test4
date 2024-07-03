using MediatR;
using test4.Application.Abstractions.Messaging;

namespace test4.Application.Products.UpdateProduct;

public record UpdateProductCommand(Guid ProductId, string Name, string Description) : ICommand<Unit>;
