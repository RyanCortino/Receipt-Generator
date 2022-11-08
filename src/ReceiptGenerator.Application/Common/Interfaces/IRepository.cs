using ReceiptGenerator.Application.Products.Queries;

namespace RecipetGenerator.Infrastructure.Data
{
    public interface IRepository<T> where T : class
    {
        Task DeleteAsync(int id);
        Task<T?> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task InsertAsync(T product);
        Task UpdateAsync(T product);
    }
}