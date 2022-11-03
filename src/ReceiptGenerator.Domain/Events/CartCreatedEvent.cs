namespace ReceiptGenerator.Domain.Events;

public class CartCreatedEvent : BaseEvent
{
    public CartCreatedEvent(Cart cart)
    {
        Cart = cart;
    }

    public Cart Cart { get; }
}
