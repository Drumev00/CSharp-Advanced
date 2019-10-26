SELECT CASE
			WHEN e.FirstName IS NULL THEN 'None'
			WHEN e.LastName IS NULL THEN 'None'
		ELSE CONCAT(e.FirstName, ' ', e.LastName)
		END AS Employee,
		CASE
			WHEN d.[Name] IS NULL THEN 'None'
		ELSE d.[Name]
		END AS Department,
	   c.[Name] AS Category,
	   r.[Description],
	   FORMAT(r.OpenDate, 'dd.MM.yyy') AS OpenDate,
	   s.[Label] AS [Status],
	   CASE
			WHEN u.[Name] IS NULL THEN 'None'
		ELSE u.[Name]
		END AS [User]
FROM Reports AS r
LEFT JOIN Employees AS e ON r.EmployeeId = e.Id
LEFT JOIN Departments AS d ON e.DepartmentId = d.Id
LEFT JOIN Categories AS c ON r.CategoryId = c.Id
LEFT JOIN [Status] AS s ON r.StatusId = s.Id
LEFT JOIN Users AS u ON r.UserId = u.Id
ORDER BY e.FirstName DESC,
		 e.LastName DESC,
		 [Department],
		 [Category],
		 r.[Description],
		 r.OpenDate,
		 [Status],
		 [User]
		