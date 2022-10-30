using ReceiptGenerator.Domain.Exceptions;
using System;

namespace ReceiptGenerator.Domain.ValueObjects;

public sealed class Discount
{
    #region Static Members
    static Discount() { }
    public static Discount FirstTime15 => new("FIRSTTIME15", 15M);
    #endregion

    #region Constructors
    private Discount() { }
    
    private Discount(string code, decimal value)
    {
        Code = code;
        Value = value;
    }
    #endregion

    #region Properties
    public string Code { get; private set; } = string.Empty;

    public decimal Value { get; private set; } = 0;
    #endregion

    #region Interface
    public decimal CalculateDiscount(decimal input)
    {
        return Math.Round(input * (Value / 100), 2, MidpointRounding.ToEven);        
    }
    #endregion

    #region Methods
    private static IEnumerable<Discount> SupportedCoupons
    {
        get
        {
            yield return FirstTime15;
        }
    } 
    #endregion
}