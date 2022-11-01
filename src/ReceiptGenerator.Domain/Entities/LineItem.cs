using ReceiptGenerator.Domain.Common;

namespace ReceiptGenerator.Domain.Entities;

public class LineItem : IHasDomainEvent
{
    public Product? Product { get; set; }

    public int Quantity { get; set; }

    public decimal? LinePrice
    {
        get
        {
            if (Product == null) 
            {
                return Product?.Price * Quantity;
            }

            return Product?.Price * Quantity;
        }
    }

    private decimal? _discount;
    public decimal Discount
    {
        get => _discount ?? 0;
        set
        {
            if (value == _discount || _discount is null)
            {
                throw new NotImplementedException();
                
                // TODO: Add the following event.
                // DomainEvents.Add(new LineItemDiscountedEvent(this));
            }

            _discount = value;
        }
    }

    public IList<DomainEvent> DomainEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
