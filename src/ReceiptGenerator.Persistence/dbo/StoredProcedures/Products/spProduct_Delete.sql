CREATE PROCEDURE [dbo].[spProduct_Delete]
	@Id int
AS
BEGIN
	DELETE
	FROM dbo.[Product]
	WHERE Id = @Id;
END