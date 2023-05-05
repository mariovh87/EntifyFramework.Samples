IF not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MostHighlyRatedBooks]') AND type = 'V')
begin
	execute('CREATE VIEW [dbo].[MostHighlyRatedBooks]
	as
		SELECT TOP (30)  b.BookId, b.Title,a.Name,A.LastName,AVG(Convert(decimal(2,1), ISNULL(r.Stars,0))) as Stars
		FROM dbo.Books b left JOIN
		dbo.BookRatings r on b.BookId = r.BookId
		inner join dbo.Authors a on b.AuthorID = a.AuthorId
		group by b.BookId, b.Title, a.Name, a.LastName
		order by Stars desc')
end
go

IF not EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MostProlificAuthors]') AND type = 'IF')
begin
	execute('CREATE FUNCTION dbo.MostProlificAuthors(@rows int)
	RETURNS TABLE
	as
	RETURN
	(
		SELECT TOP (@rows) a.Name, a.LastName, COUNT(b.BookId) as Books
		FROM dbo.Authors a inner join dbo.Books b on a.AuthorId = b.AuthorID
		group by a.Name, a.LastName
		order by Books desc
	)')
end
go
