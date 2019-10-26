CREATE PROC usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
BEGIN
	DECLARE @employeeDepartment INT = (SELECT TOP(1) DepartmentId FROM Employees
									   WHERE Id = @EmployeeId)

	DECLARE @reportCategory INT = (SELECT TOP(1) CategoryId FROM Reports
								   WHERE Id = @ReportId)

	DECLARE @categoryDepartment INT = (SELECT TOP(1) DepartmentId FROM Categories
									   WHERE Id = @reportCategory)

	DECLARE @userId INT = (SELECT UserId FROM Reports
						   WHERE Id = @ReportId)

	DECLARE @openDate DATETIME2 = (SELECT OpenDate FROM Reports
								   WHERE Id = @ReportId)
	IF (@employeeDepartment = @categoryDepartment)
	BEGIN
		INSERT INTO Reports (CategoryId, StatusId, OpenDate, [Description], UserId,  EmployeeId) VALUES
		(@reportCategory, 2, @openDate, ' ', @userId, @EmployeeId)
	END
	ELSE
	BEGIN
		RAISERROR('Employee doesn''t belong to the appropriate department!', 16, 1)
	END
END