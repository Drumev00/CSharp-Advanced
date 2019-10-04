SELECT DepositGroup FROM (
				SELECT TOP(2)  DepositGroup, AVG(MagicWandSize) AS [Average Size]
				FROM WizzardDeposits
				GROUP BY DepositGroup
				ORDER BY [Average Size]) AS [Average Size Table]
		
