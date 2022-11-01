using ReceiptGenerator.Domain.Common;
using ReceiptGenerator.Domain.Exceptions;

namespace ReceiptGenerator.Domain.ValueObjects;

/// <summary>
/// Represents a tax category for the purposes of determine sales tax exemptions.
/// </summary>
public class TaxClassification : ValueObject
{
    #region Constructors
    static TaxClassification()
    {
    }

    private TaxClassification()
    {
    }

    private TaxClassification(string category)
    {
        Category = category;
    }
    #endregion

    #region Static Members
    public static TaxClassification From(string category)
    {
        // instantiate the requested category.
        var taxClassification = new TaxClassification { Category = category };

        // validate that the TaxClassification object is supported
        if (!SupportedTaxClassifications.Contains(taxClassification))
        {
            throw new UnsupportedTaxClassification(taxClassification);
        }

        // return the object in a valid state with the requested category.
        return taxClassification;
    }

    public static TaxClassification Food => new("food");

    public static TaxClassification Medical => new("medical");

    public static TaxClassification General => new("general");
    #endregion

    #region Fields & Properties
    public string Category { get; private set; } = string.Empty;
    #endregion

    #region Public Methods
    public static implicit operator string(TaxClassification taxClassification)
    {
        return taxClassification.ToString();
    }

    public static explicit operator TaxClassification(string category)
    {
        return From(category);
    }

    public override string ToString()
    {
        return Category;
    }
    #endregion

    #region Private & Protected Methods
    protected static IEnumerable<TaxClassification> SupportedTaxClassifications
    {
        get
        {
            yield return General;
            yield return Medical;
            yield return Food;
        }
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Category;
    }
    #endregion
}