using MediatR;
using test4.Application.Abstractions.Messaging;
using test4.Domain.Abstractions;
using test4.Domain.Products;

namespace test4.Application.Products.UpdateProduct;

internal sealed class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, Unit>
{
    private readonly IProductRepository _productRepository;

    public UpdateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<Unit>> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(command.ProductId);

        if (product is null)
        {
            return Result.Failure<Unit>(ProductErrors.NotFound);
        }

        product.Update(new Name(command.Name), new Description(command.Description));

        await _productRepository.UpdateAsync(product);

        return Result.Success(Unit.Value);
    }
}
