using MediatR;
using test4.Application.Abstractions.Messaging;
using test4.Domain.Abstractions;
using test4.Domain.Products;

namespace test4.Application.Products.DeleteProduct;

internal sealed class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, Unit>
{
    private readonly IProductRepository _productRepository;

    public DeleteProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<Unit>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.ProductId);

        if (product is null)
        {
            return Result.Failure<Unit>(ProductErrors.NotFound);
        }

        await _productRepository.DeleteAsync(product);

        return Result.Success(Unit.Value);
    }
}
