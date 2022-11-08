using ReceiptGenerator.Domain.Entities;
using RecipetGenerator.Infrastructure.Data;

namespace ReceiptGenerator.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    IRepository<Cart> Carts { get; }

    IRepository<Product> Products { get; }
}
