using ReceiptGenerator.Application.Products.Queries;

namespace RecipetGenerator.Infrastructure.Data
{
    public interface IProductRepo
    {
        Task DeleteProduct(int id);
        Task<ProductDto?> GetProduct(int id);
        Task<IEnumerable<ProductDto>> GetProducts();
        Task InsertProduct(ProductDto product);
        Task UpdateProduct(ProductDto product);
    }
}