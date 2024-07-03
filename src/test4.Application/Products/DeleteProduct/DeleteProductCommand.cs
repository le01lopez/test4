using MediatR;
using test4.Application.Abstractions.Messaging;

namespace test4.Application.Products.DeleteProduct;

public record DeleteProductCommand(Guid ProductId) : ICommand<Unit>;
