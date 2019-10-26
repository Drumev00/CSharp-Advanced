SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
	   COUNT(r.UserId) AS UsersCount FROM Employees e
LEFT JOIN Reports r ON e.Id = r.EmployeeId
GROUP BY e.FirstName, e.LastName
ORDER BY UsersCount DESC, FullName