using FluentValidation;

namespace test4.Application.Products.CreateProduct;

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithErrorCode(ProductErrorCodes.CreateProduct.MissingName);

        RuleFor(c => c.Description)
            .NotEmpty().WithErrorCode(ProductErrorCodes.CreateProduct.MissingDescription);
    }
}
