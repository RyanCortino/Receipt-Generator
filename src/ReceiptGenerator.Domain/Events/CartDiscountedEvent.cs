namespace ReceiptGenerator.Domain.Events;

public class CartDiscountedEvent : BaseEvent
{
    public CartDiscountedEvent(Cart cart, Discount discount)
    {
        Cart = cart;
        Discount = discount;
    }

    public Cart Cart { get; }

    public Discount Discount { get; }
}