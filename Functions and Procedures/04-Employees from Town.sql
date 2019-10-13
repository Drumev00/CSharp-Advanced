CREATE PROC usp_GetEmployeesFromTown (@townName VARCHAR(50))
AS
SELECT e.FirstName, e.LastName FROM Employees e
  JOIN Addresses a ON a.AddressID = e.AddressID
  JOIN Towns t ON t.TownID = a.TownID
 WHERE @townName = t.[Name]