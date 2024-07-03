namespace test4.Application.Products;

public static class ProductErrorCodes
{
    public static class CreateProduct
    {
        public const string MissingName = nameof(MissingName);
        public const string MissingDescription = nameof(MissingDescription);
    }
}
