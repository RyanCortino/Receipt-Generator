namespace ReceiptGenerator.Domain.Entities;

public class Product : BaseEntity
{
    public int CartId { get; set; }

    public string Name { get; set; } = string.Empty;

    public TaxClassification TaxType { get; set; } = TaxClassification.General;

    public Money Price { get; set; } = Money.From(0m);

    public bool IsTaxExempt => (TaxType == TaxClassification.Medical || TaxType == TaxClassification.Food);
}