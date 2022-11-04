namespace ReceiptGenerator.Domain.ValueObjects;

/// <summary>
/// Represents a deduction from the usual cost of something as a percentage.
/// </summary>
public sealed class Discount : ValueObject
{
    #region Constructors
    static Discount() 
    {
    }

    private Discount() 
    {
    }

    private Discount(decimal value)
    {
        Value = value;
    }
    #endregion

    #region Static Factory Methods
    public static Discount From(decimal value)
    {
        var discount = new Discount(value);

        // validate?

        return discount;

    }
    public static Discount FirstTime15 => new(0.15m);
    #endregion

    #region Properties
    public decimal Value { get; private set; } = 0m;
    #endregion

    #region Public Methods
    public static implicit operator decimal(Discount discount) => discount.Value;

    public static explicit operator Discount(decimal value) => From(value);

    public override string ToString() => Value.ToString("P");
    #endregion

    #region Private & Protected Methods
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    #endregion
}