SELECT e.EmployeeID, e.FirstName, e.ManagerID, mg.FirstName AS ManagerName
FROM Employees e
JOIN Employees mg ON e.ManagerID = mg.EmployeeID
WHERE e.ManagerID = 3 OR e.ManagerID = 7
ORDER BY EmployeeID
