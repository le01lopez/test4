using test4.Application.Abstractions.Messaging;
using test4.Domain.Abstractions;
using test4.Domain.Products;

namespace test4.Application.Products.CreateProduct;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<Guid>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var result = Product.Create(new Name(command.Name), new Description(command.Description));

        if (result.IsFailure)
        {
            return Result.Failure<Guid>(result.Error);
        }

        await _productRepository.AddAsync(result.Value);

        return result.Value.Id;
    }
}
