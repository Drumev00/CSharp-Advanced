CREATE PROC usp_TransferMoney(@senderId INT, @receiverId INT, @amount DECIMAL(18,4))
AS
BEGIN TRANSACTION

	IF(EXISTS(SELECT * FROM Accounts
			WHERE Id IN(@senderId, @receiverId)))
	BEGIN
		EXEC dbo.usp_WithdrawMoney @senderId, @amount
		EXEC dbo.usp_DepositMoney @receiverId, @amount
	END
	ELSE
	BEGIN
		ROLLBACK
		RAISERROR('No such an account ID', 16, 1)
		RETURN
	END
COMMIT