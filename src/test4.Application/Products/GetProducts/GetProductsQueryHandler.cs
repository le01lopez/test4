using test4.Application.Abstractions.Messaging;
using test4.Domain.Abstractions;
using test4.Domain.Products;

namespace test4.Application.Products.GetProducts;

internal sealed class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, List<ProductResponse>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Result<List<ProductResponse>>> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var products = await _productRepository.ListAllAsync();

        return products.Select(product => new ProductResponse
        {
            Id = product.Id,
            Name = product.Name.Value,
            Description = product.Description.Value
        }).ToList();
    }
}
