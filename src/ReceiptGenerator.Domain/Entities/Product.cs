using ReceiptGenerator.Domain.Common;
using ReceiptGenerator.Domain.ValueObjects;

namespace ReceiptGenerator.Domain.Entities;

public class Product
{
    public string Name { get; set; }

    public TaxClassification TaxType { get; set; }

    public decimal Price { get; set; }

    public bool IsTaxExempt => (TaxType == TaxClassification.Medical || TaxType == TaxClassification.Food);
}