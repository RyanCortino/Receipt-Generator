using ReceiptGenerator.Application.Products.Queries;
using ReceiptGenerator.Domain.Common.Interfaces;

namespace RecipetGenerator.Infrastructure.Data;

public class Products : IRepository<ProductModel>
{
    private readonly ISqlDataAccess _db;

    public Products(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<ProductModel?> Get(int id)
    {
        var results = await _db.LoadData<ProductModel, dynamic>(
            storedProcedure: "dbo.spProduct_Get",
            new { Id = id });

        return results.FirstOrDefault();
    }

    public Task<IEnumerable<ProductModel>> GetAll() =>
        _db.LoadData<ProductModel, dynamic>(storedProcedure: "dbo.spProduct_GetAll", new { });

    public Task Insert(ProductModel product) =>
        _db.SaveData(storedProcedure: "dbo.spProduct_Insert", new { product.Name, product.Price, product.TaxCategory });

    public Task Update(ProductModel product) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Update", product);

    public Task Delete(int id) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Delete", new { Id = id });
}