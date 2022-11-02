using ReceiptGenerator.Domain.Common.Interfaces;
using ReceiptGenerator.Domain.ValueObjects;
using System.Text;

namespace ReceiptGenerator.ConsoleUi.Services;

public class CartService // : ICartService
{
    //private IList<LineItem> _lineItems = new List<LineItem>();
    //private Discount? _discount = null;

    //public decimal TotalDiscount => CalculateDiscountTotals() ;

    //public decimal TotalSalesTax => CalculateSalesTaxTotals() ;

    //public decimal Total => Math.Round(CalculateTotal() + TotalSalesTax, 2, MidpointRounding.ToEven);


    //public void AddLine(Item item, int amount)
    //{
    //    _lineItems.Add(new LineItem(item, amount));
    //}

    //public void ApplyFirstTime15Discount()
    //{
    //    _discount = Discount.FirstTime15;

    //    foreach (var line in _lineItems)
    //    {
    //        line.ApplyDiscountToLine(_discount);
    //    }
    //}

    //public override string ToString()
    //{
    //    var sb = new StringBuilder();
    //    foreach (var line in _lineItems)
    //    {
    //        sb.AppendLine($"{line.ToString()}");
    //    }
    //    sb.AppendLine($"Discount: ${TotalDiscount:#,##0.00}");
    //    sb.AppendLine($"Sales Tax: ${TotalSalesTax:#,##0.00}");
    //    sb.AppendLine($"Total: ${Total:#,##0.00}");

    //    return sb.ToString();
    //}

    //private decimal CalculateDiscountTotals()
    //{
    //    if (_discount is null)
    //        return 0;

    //    decimal discountedAmount = 0;

    //    foreach (var line in _lineItems)
    //    {
    //        for (int i = 0; i < line.Quantity; i++)
    //        {
    //            discountedAmount += _discount.CalculateDiscount(line.Item.Price);
    //        }
    //    }

    //    return Math.Round(discountedAmount, 2, MidpointRounding.ToEven);
    //}

    //private decimal CalculateSalesTaxTotals()
    //{
    //    decimal salesTaxAmount = 0;

    //    foreach (var line in _lineItems)
    //    {
    //        if (line.Item.IsTaxExempt)
    //            continue;

    //        salesTaxAmount += line.LineTotal * 0.07M;
    //    }

    //    return Math.Round(salesTaxAmount, 2, MidpointRounding.ToEven);
    //}

    //private decimal CalculateTotal()
    //{
    //    decimal total = 0;

    //    foreach (var line in _lineItems)
    //    {
    //        total += line.LineTotal;
    //    }

    //    return total;
    //}

    //public void ClearCart()
    //{
    //    _lineItems = new List<LineItem>();
    //    _discount = null;
    //}

    //private class LineItem
    //{
    //    public Item Item { get; private set; }

    //    public int Quantity { get; private set; }

    //    public decimal LineTotal { get; private set; } = 0;

    //    public LineItem(Item item, int quantity)
    //    {
    //        Item = item;
    //        Quantity = quantity;

    //        LineTotal = Math.Round(Item.Price * Quantity, 2, MidpointRounding.ToEven);
    //    }

    //    public override string ToString()
    //    {
    //        return $" {Quantity} {Item.Name} ${LineTotal:#,##0.00}";
    //    }

    //    public void ApplyDiscountToLine(Discount discount)
    //    {
    //        LineTotal = Math.Round(LineTotal - discount.CalculateDiscount(LineTotal), 2, MidpointRounding.ToEven);
    //    }
    //}
}