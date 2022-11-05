CREATE PROCEDURE [dbo].[spProduct_Insert]
	@Name nvarchar(50),
	@Price decimal(18, 2),
	@TaxCategory nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.[Product] ([Name], [Price], [TaxCategory])
	values (@Name, @Price, @TaxCategory);
END