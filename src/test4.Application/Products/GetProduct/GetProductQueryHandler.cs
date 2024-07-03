using test4.Application.Abstractions.Messaging;
using test4.Domain.Abstractions;
using test4.Domain.Products;

namespace test4.Application.Products.GetProduct;

internal sealed class GetProductQueryHandler : IQueryHandler<GetProductQuery, ProductResponse>
{
    private readonly IProductRepository _productRepository;

    public GetProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<ProductResponse>> Handle(GetProductQuery query, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(query.ProductId);

        if (product is null)
        {
            return Result.Failure<ProductResponse>(ProductErrors.NotFound);
        }

        return new ProductResponse
        {
            Id = product.Id,
            Name = product.Name.Value,
            Description = product.Description.Value
        };
    }
}
