using test4.Domain.Abstractions;

namespace test4.Domain.Products;

public interface IProductRepository : IAsyncRepository<Product>
{
}
