SELECT c.CountryCode, COUNT(mc.MountainId) AS MountainRanges
FROM Countries c
JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
WHERE c.CountryCode = 'BG' OR c.CountryCode = 'RU' OR c.CountryCode = 'US'
GROUP BY c.CountryCode