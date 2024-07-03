using test4.Application.Abstractions.Messaging;

namespace test4.Application.Products.GetProduct;

public sealed record GetProductQuery(Guid ProductId): IQuery<ProductResponse>;
