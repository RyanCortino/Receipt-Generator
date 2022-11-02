using ReceiptGenerator.Domain.Common;
using ReceiptGenerator.Domain.ValueObjects;

namespace ReceiptGenerator.Domain.Entities;

public class LineItem : IHasDomainEvent
{
    public Product? Product { get; set; }

    public Discount? Discount { get; set; }

    public int Quantity { get; set; }

    public Money LinePrice
    {
        get
        {
            if (Product is null)
                return Money.From(0);

            if (Discount is not null)
                return Money.From(Discount * (Product.Price * Quantity));

            return Money.From(Product.Price * Quantity);
        }
    }

    public IList<DomainEvent> DomainEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
