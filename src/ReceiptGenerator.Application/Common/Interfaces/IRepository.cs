using ReceiptGenerator.Application.Products.Queries;

namespace RecipetGenerator.Infrastructure.Data
{
    public interface IRepository<T> where T : class
    {
        Task Delete(int id);
        Task<T?> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Insert(T product);
        Task Update(T product);
    }
}