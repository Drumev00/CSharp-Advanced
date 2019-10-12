SELECT MIN(AverageSalaries.SalariesByDepartment) AS MinAverageSalary
FROM (
		SELECT AVG(Salary) AS SalariesByDepartment
	    FROM Employees e
        GROUP BY e.DepartmentID
	 ) AS AverageSalaries