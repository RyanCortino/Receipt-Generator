using ReceiptGenerator.Domain.Common;

namespace ReceiptGenerator.Domain.ValueObjects;

/// <summary>
/// This value object represents 
/// </summary>
public class Price : ValueObject
{
    #region Constructors
    static Price()
    {
    }

    private Price()
    {
    }

    private Price(decimal value)
    {
        Value = value;
    }
    #endregion

    #region Static Members

    #endregion

    #region Fields & Properties
    public decimal Value { get; private set; } = 0m;
    #endregion

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
