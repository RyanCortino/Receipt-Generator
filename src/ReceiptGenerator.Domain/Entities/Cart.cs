using Microsoft.VisualBasic;

namespace ReceiptGenerator.Domain.Entities;

public class Cart : BaseEntity
{
    public string? Title { get; set; }
    public IEnumerable<LineItem> Items { get; private set; } = new List<LineItem>();
}