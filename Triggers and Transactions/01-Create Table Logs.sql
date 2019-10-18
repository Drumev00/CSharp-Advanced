CREATE TABLE Logs(
	LogId INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id) NOT NULL,
	OldSum MONEY NOT NULL,
	NewSum MONEY NOT NULL
)

GO
CREATE TRIGGER tr_Logger ON Accounts FOR UPDATE
AS
BEGIN

	DECLARE @newSum DECIMAL(15,2) = (SELECT i.Balance FROM inserted AS i)
	DECLARE @oldSum DECIMAL(15,2) = (SELECT d.Balance FROM deleted AS d)
	DECLARE @accountId INT = (SELECT i.Id FROM inserted AS i)

	INSERT INTO Logs (AccountId, OldSum, NewSum) VALUES
	(@accountId, @oldSum, @newSum)

END