using MediatR;
using ReceiptGenerator.Application.Common.Interfaces;
using ReceiptGenerator.Domain.Entities;

namespace ReceiptGenerator.Application.ShoppingCart.Commands.CreateCart;

public record CreateCartCommand : IRequest<int>
{
    public string? Title { get; init; }
}

public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, int>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateCartCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        var entity = new Cart
        {
            Title = request.Title
        };

        await _dbContext.Carts.InsertAsync(entity);

        return entity.Id;
    }
}
