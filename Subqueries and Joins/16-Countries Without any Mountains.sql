SELECT COUNT(*) AS [Count] 
FROM  (
		SELECT c.CountryCode
		FROM Countries c
		LEFT JOIN MountainsCountries mc ON c.CountryCode = mc.CountryCode
		WHERE mc.MountainId IS NULL
	  ) AS WithoutMountains
		