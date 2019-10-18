CREATE TABLE NotificationEmails(
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT FOREIGN KEY REFERENCES Accounts(Id) NOT NULL,
	[Subject] VARCHAR(100) NOT NULL,
	Body VARCHAR(MAX) NOT NULL
)

GO

CREATE TRIGGER tr_BalanceChangeNotification ON Logs AFTER INSERT
AS
	DECLARE @recipient INT = (SELECT i.AccountId FROM inserted i)
	DECLARE @subject VARCHAR(100) = CONCAT('Balance change for account: ', @recipient)
	DECLARE @oldSum DECIMAL(18, 2) = (SELECT i.OldSum FROM inserted i)
	DECLARE @newSum DECIMAL(18, 2) = (SELECT i.NewSum FROM inserted i)
	DECLARE @body VARCHAR(MAX) = CONCAT('On ', FORMAT(GETDATE(), 'MMM dd yyyy hh:mm tt'), ' your balance was changed from ', @oldSum, ' to ', @newSum, '.')

INSERT INTO NotificationEmails VALUES
(@recipient, @subject, @body)