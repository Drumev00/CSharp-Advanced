UPDATE Employees
SET Salary += 0.12 * Salary
WHERE DepartmentID = 1 OR DepartmentID = 2 OR DepartmentID = 4 OR DepartmentID = 11