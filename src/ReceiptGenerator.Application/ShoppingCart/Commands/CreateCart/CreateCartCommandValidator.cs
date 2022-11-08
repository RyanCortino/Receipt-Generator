using FluentValidation;
using ReceiptGenerator.Application.Common.Interfaces;

namespace ReceiptGenerator.Application.ShoppingCart.Commands.CreateCart;

public class CreateCartCommandValidator : AbstractValidator<CreateCartCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCartCommandValidator(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;

        RuleFor(v => v.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(50).WithMessage("Title must not exceed 50 characters.")
            .MustAsync(BeUniqueTitle).WithMessage("The requested title already exists.");
    }

    public async Task<bool> BeUniqueTitle(string title, CancellationToken cancellationToken)
    {
        var carts = await _dbContext.Carts.GetAllAsync();
        return carts.First(s => s.Title == title) != null;
    }
}
