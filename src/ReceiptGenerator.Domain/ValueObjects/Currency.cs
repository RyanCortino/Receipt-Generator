using ReceiptGenerator.Domain.Common;
using System.Globalization;

namespace ReceiptGenerator.Domain.ValueObjects;

public class Currency : ValueObject
{
    #region Constructors
    static Currency()
    {
    }

    private Currency()
    {
    }

    private Currency(string displayName, CultureInfo displaySymbol, int numericCode, int defaultFractionDigits, int subUnit)
    {
        DisplayName = displayName;
        NumericCode = numericCode;
        DefaultFractionDigits = defaultFractionDigits;
        SubUnit = subUnit;
    }
    #endregion

    #region Static Factory Methods
    public static Currency USD => new("US Dollar", new CultureInfo("en-US"), 840, 2, 100);
    #endregion

    #region Fields & Properties
    public string DisplayName { get; private set; } = string.Empty;
    public CultureInfo Culture { get; private set; } = CultureInfo.InvariantCulture;
    public int NumericCode { get; private set; } = 0;
    public int DefaultFractionDigits { get; private set; } = 0;
    public int SubUnit { get; private set; } = 0;
    #endregion

    #region Private & Protected Methods
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return NumericCode;
        yield return DefaultFractionDigits;
        yield return SubUnit;
    }
    #endregion
}