CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
BEGIN
	SELECT [Id], [Name], [Price], [TaxCategory]
	FROM dbo.[Product]
	WHERE Id = @Id;
END