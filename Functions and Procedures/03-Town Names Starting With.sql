CREATE PROC usp_GetTownsStartingWith (@townStart VARCHAR(10))
AS
SELECT [Name] FROM Towns
WHERE [Name] LIKE @townStart + '%'