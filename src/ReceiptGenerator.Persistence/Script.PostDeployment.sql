IF NOT EXISTS (SELECT 1 FROM dbo.[Product])
BEGIN
	INSERT INTO dbo.[Product] ([Name], [Price], [TaxCategory])
	VALUES 
		('book', 12.50, 'general'),
		('bar of soap', 5.00, 'general'),
		('box of cereal', 6.50, 'food'),
		('box of cereal', 7.75, 'food'),
		('magazine', 12.49, 'general'),
		('video game', 54.99, 'general'),
		('box of band-aids', 9.90, 'medical');
END