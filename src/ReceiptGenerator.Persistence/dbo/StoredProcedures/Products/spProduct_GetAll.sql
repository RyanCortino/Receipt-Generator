CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
BEGIN
	SELECT [Id], [Name], [Price], [TaxCategory]
	FROM dbo.[Product];
END