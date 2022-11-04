using Microsoft.EntityFrameworkCore;
using ReceiptGenerator.Domain.Entities;

namespace ReceiptGenerator.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Cart> Carts { get; }

    DbSet<Product> Products { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}
