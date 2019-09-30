CREATE TABLE Users (
 Id INT PRIMARY KEY IDENTITY,
 Username VARCHAR(30) UNIQUE NOT NULL,
 [Password] VARCHAR(26) NOT NULL,
 ProfilePicture VARBINARY(MAX),
 CHECK(DATALENGTH(ProfilePicture) <= 921600),
 LastLoginTime DATETIME2,
 IsDeleted BIT
 )
  
 INSERT INTO Users VALUES
 ('Bahurr', 'silniparoli', NULL, NULL, 0),
 ('acc', 'pass113', NULL, NULL, 0),
 ('silnoacc', 'silniteparoli', NULL, NULL, 1),
 ('Qvkata e car', 'absolyuten car', NULL, NULL, 0),
 ('Ryze e OP', 'samo kitaicite go igraqt', NULL, NULL, 1)