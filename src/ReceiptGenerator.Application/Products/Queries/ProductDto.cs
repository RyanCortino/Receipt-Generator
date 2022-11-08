using ReceiptGenerator.Domain.Entities;

namespace ReceiptGenerator.Application.Products.Queries;

public class ProductModel // : IMapFrom<Product>
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? TaxCategory { get; set; }
}
