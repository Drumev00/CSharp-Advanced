SELECT [Description], FORMAT(OpenDate, 'dd-MM-yyyy') AS [OpenDate] FROM Reports
WHERE EmployeeId IS NULL
ORDER BY YEAR([OpenDate]) ASC, MONTH([OpenDate]) ASC, [Description] ASC