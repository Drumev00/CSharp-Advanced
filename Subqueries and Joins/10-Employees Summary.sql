SELECT TOP(50) e.EmployeeID,
CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName, 
CONCAT(mg.FirstName, ' ', mg.LastName) AS ManagerName,
d.[Name] AS DepartmentName
FROM Employees e
JOIN Employees mg ON mg.EmployeeID = e.ManagerID
JOIN Departments d ON d.DepartmentID = e.DepartmentID
ORDER BY e.EmployeeID