CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @yearlyInterestRate FLOAT, @numberOfYears INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
		DECLARE @halfPart DECIMAL(15, 4)
		DECLARE @result DECIMAL(15, 4)

		SET @halfPart = POWER(1 + @yearlyInterestRate, @numberOfYears)
		SET @result = @sum * @halfPart

		RETURN @result
END