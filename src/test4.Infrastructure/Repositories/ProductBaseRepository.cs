using test4.Domain.Products;

namespace test4.Infrastructure.Repositories;

internal sealed class ProductBaseRepository : BaseRepository<Product>, IProductRepository
{
    public ProductBaseRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}
