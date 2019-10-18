CREATE PROC usp_AssignProject(@emloyeeId INT, @projectId INT)
AS
BEGIN TRANSACTION

		INSERT INTO EmployeesProjects VALUES
		(@emloyeeId, @projectId)

	DECLARE @projects INT = (SELECT COUNT(ProjectID) AS [Count] FROM EmployeesProjects
							 WHERE EmployeeID = @emloyeeId
							 GROUP BY EmployeeID)

	IF (@projects > 3)
	BEGIN
		ROLLBACK
		RAISERROR('The employee has too many projects!', 16, 1)
		RETURN
	END
COMMIT