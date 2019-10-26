SELECT u.Username, c.[Name] FROM Users u
JOIN Reports r ON u.Id = r.UserId
JOIN Categories c ON r.CategoryId = c.Id
WHERE MONTH(r.OpenDate) = MONTH(u.Birthdate) AND DAY(r.OpenDate) = DAY(u.Birthdate)
ORDER BY u.Username, c.[Name]
