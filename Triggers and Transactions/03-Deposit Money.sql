CREATE PROC usp_DepositMoney (@accountId INT, @moneyAmount DECIMAL(18, 4))
AS
UPDATE Accounts
SET Balance += @moneyAmount
WHERE Id = @accountId