namespace ReceiptGenerator.Domain.ValueObjects;

/// <summary>
/// Refers to a quantity that represents a means of payment in an accepted currency.
/// </summary>
public class Money : ValueObject
{
    #region Constructors
    static Money()
    {
    }

    private Money()
    {
    }

    private Money(decimal value, Currency currency)
    {
        Value = value;
        Currency = currency;
    }
    #endregion

    #region Static Factory Methods
    public static Money From(decimal value)
    {
        var money = new Money(value, Currency.USD);

        // validate?

        return money;
    }
    #endregion

    #region Fields & Properties
    public decimal Value { get; private set; } = 0m;
    public Currency Currency { get; private set; } = Currency.USD;
    #endregion

    #region Public Methods
    public static implicit operator decimal(Money money) => money.Value;

    public static explicit operator Money(decimal value) => From(value);

    public override string ToString() => Value.ToString("C", Currency.Culture);
    #endregion

    #region Private & Protected Methods
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    #endregion
}
