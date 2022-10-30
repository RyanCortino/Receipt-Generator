using ReceiptGenerator.Domain.Enums;
using ReceiptGenerator.Domain.Exceptions;

namespace ReceiptGenerator.Domain.ValueObjects;

public sealed class Item
{
    static Item() { }
    private Item() { }

    private Item(string name, ItemType type, decimal price)
    {
        Name = name;
        Type = type;
        Price = price;
    }

    public static Item Book => new ("book", ItemType.General, 12.50M);
    public static Item Magazine => new ("magazine", ItemType.General, 12.49M);
    public static Item BarOfSoap => new ("bar of soap", ItemType.General, 5M);
    public static Item BoxOfBandAids => new ("box of band-aids", ItemType.Medical, 9.90M);
    public static Item BoxOfCereal => new ("box of cereal", ItemType.Food, 6.5M);
    public static Item BoxOfExpensiveCereal => new ("box of cereal", ItemType.Food, 7.75M); 
    public static Item VideoGame => new ("video game", ItemType.General, 54.99M);

    public string Name { get; private set; } = string.Empty;
    public ItemType Type { get; private set; } = ItemType.General;
    public decimal Price { get; private set; } = decimal.Zero;

    public bool IsTaxExempt => (Type == ItemType.Medical || Type == ItemType.Food);
}
