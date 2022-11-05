using ReceiptGenerator.Application.Products.Queries;
using ReceiptGenerator.Domain.Common.Interfaces;

namespace RecipetGenerator.Infrastructure.Data;

public class Products : IProductRepo
{
    private readonly ISqlDataAccess _db;

    public Products(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<ProductDto?> GetProduct(int id)
    {
        var results = await _db.LoadData<ProductDto, dynamic>(
            storedProcedure: "dbo.spProduct_Get",
            new { Id = id });

        return results.FirstOrDefault();
    }

    public Task<IEnumerable<ProductDto>> GetProducts() =>
        _db.LoadData<ProductDto, dynamic>(storedProcedure: "dbo.spProduct_GetAll", new { });

    public Task InsertProduct(ProductDto product) =>
        _db.SaveData(storedProcedure: "dbo.spProduct_Insert", new { product.Name, product.Price, product.TaxCategory });

    public Task UpdateProduct(ProductDto product) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Update", product);

    public Task DeleteProduct(int id) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Delete", new { Id = id });
}