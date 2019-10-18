CREATE TABLE Deleted_Employees(
	EmployeeId INT PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50),
	JobTitle VARCHAR(50) NOT NULL,
	DepartmentId INT,
	Salary MONEY
)

GO

CREATE TRIGGER tr_LogDeletedEmployees ON Employees AFTER DELETE
AS
	BEGIN
		DECLARE @deletedEmployeeID INT = (SELECT d.EmployeeID FROM deleted d)
		DECLARE @deletedFirstName VARCHAR(50) = (SELECT d.FirstName FROM deleted d)
		DECLARE @deletedLastName VARCHAR(50) = (SELECT d.LastName FROM deleted d)
		DECLARE @deletedMiddleName VARCHAR(50) = (SELECT d.MiddleName FROM deleted d)
		DECLARE @deletedJobTitle VARCHAR(50) = (SELECT d.JobTitle FROM deleted d)
		DECLARE @deletedDepartmentID INT = (SELECT d.DepartmentID FROM deleted d)
		DECLARE @deletedSalary MONEY = (SELECT d.Salary FROM deleted d)

	INSERT INTO Deleted_Employees
	(EmployeeId,
	FirstName,
	LastName,
	MiddleName,
	JobTitle,
	DepartmentId,
	Salary) VALUES (@deletedEmployeeID,
					@deletedFirstName,
					@deletedLastName,
					@deletedMiddleName,
					@deletedJobTitle,
					@deletedDepartmentID,
					@deletedSalary)
	END