CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id int,
	@Name nvarchar(50), 
	@Price decimal(18, 2),
	@TaxCategory nvarchar(50)
AS
BEGIN
	UPDATE dbo.[Product]
	SET 
		[Name] = @Name,
		[Price] = @Price,
		[TaxCategory] = @TaxCategory
	WHERE Id = @Id;
END