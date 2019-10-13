CREATE PROC usp_GetHoldersWithBalanceHigherThan (@balance MONEY)
AS
SELECT ac.FirstName, ac.LastName FROM Accounts a
JOIN AccountHolders ac ON ac.Id = a.AccountHolderId
GROUP BY ac.FirstName, ac.LastName
HAVING SUM(a.Balance) > @balance
ORDER BY ac.FirstName, ac.LastName