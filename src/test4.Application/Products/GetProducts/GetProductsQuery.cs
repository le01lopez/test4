using test4.Application.Abstractions.Messaging;

namespace test4.Application.Products.GetProducts;

public sealed record GetProductsQuery: IQuery<List<ProductResponse>>;
