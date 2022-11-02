using ReceiptGenerator.Domain.Common;
using ReceiptGenerator.Domain.ValueObjects;

namespace ReceiptGenerator.Domain.Entities;

public class Product
{
    public string Name { get; set; } = string.Empty;

    public TaxClassification TaxType { get; set; } = TaxClassification.General;

    public decimal Price { get; set; }

    public bool IsTaxExempt => (TaxType == TaxClassification.Medical || TaxType == TaxClassification.Food);
}