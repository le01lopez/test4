namespace test4.Application.Products;

public sealed class ProductResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; } = default!;
    public string Description { get; init; } = default!;
}
