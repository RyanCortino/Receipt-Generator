using FluentValidation;
using System.Collections.Specialized;

namespace ReceiptGenerator.Application.Products.Commands.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(v => v.ProductName)
            .NotEmpty().WithMessage("Product Name is required.");

        RuleFor(v => v.TaxType)
            .NotNull().WithMessage("TaxType is required.");

        RuleFor(v => v.Price)
            .NotNull().WithMessage("Price is required.");
    }
}
