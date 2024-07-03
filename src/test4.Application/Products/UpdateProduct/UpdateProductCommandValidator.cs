using FluentValidation;

namespace test4.Application.Products.UpdateProduct;

internal sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithErrorCode(ProductErrorCodes.CreateProduct.MissingName);

        RuleFor(c => c.Description)
            .NotEmpty().WithErrorCode(ProductErrorCodes.CreateProduct.MissingDescription);
    }
}
