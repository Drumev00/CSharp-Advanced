CREATE PROC usp_WithdrawMoney (@accountId INT, @moneyAmount DECIMAL(18, 4))
AS
	DECLARE @currentBalance DECIMAL(18, 4) = (SELECT Balance FROM Accounts
							WHERE Id = @accountId)
	IF(@moneyAmount <= @currentBalance)
	BEGIN
		UPDATE Accounts
		SET Balance -= @moneyAmount
		WHERE Id = @accountId
	END
