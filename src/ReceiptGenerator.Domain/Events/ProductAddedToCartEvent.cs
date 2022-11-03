namespace ReceiptGenerator.Domain.Events;

public class ProductAddedToCartEvent
{
    public ProductAddedToCartEvent(Cart cart, Product product)
    {
        Cart = cart;
        Product = product;
    }

    public Cart Cart { get; }

    public Product Product { get; }
}