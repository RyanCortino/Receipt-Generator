using MediatR;
using ReceiptGenerator.Application.Common.Interfaces;
using ReceiptGenerator.Domain.Entities;
using ReceiptGenerator.Domain.Events;
using ReceiptGenerator.Domain.ValueObjects;

namespace ReceiptGenerator.Application.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public int CartId { get; init; }
    
    public string? ProductName { get; init; }

    public TaxClassification? TaxType { get; init; }
    
    public Money? Price{ get; init; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product()
        {
            CartId = request.CartId,
            Name = request.ProductName,
            TaxType = request.TaxType,
            Price = request.Price
        };

        entity.AddDomainEvent(new ProductCreatedEvent(entity));

        _context.Products.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}