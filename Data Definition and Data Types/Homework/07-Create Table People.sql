CREATE TABLE People (
 Id INT PRIMARY KEY IDENTITY,
 [Name] NVARCHAR(200) NOT NULL,
 Picture IMAGE,
 Height DECIMAL (3, 2),
 [Weight] DECIMAL (5, 2),
 Gender CHAR(1) NOT NULL,
 Birthdate DATE NOT NULL,
 Biography NVARCHAR(MAX)
)

INSERT INTO People
VALUES
('Pesho Peshev', NULL, 1.97, 98.40, 'm', '1999-01-25', NULL),
('Ivailo Evaelo', NULL, 1.76, 91.27, 'm', '2000-02-19', NULL),
('Elizabeth TR', NULL, 1.60, 51.00, 'f', '2000-10-30', NULL),
('Gabi G', NULL, 1.65, 49.35, 'f', '2000-02-18', NULL),
('Miro Salatata', NULL, 1.85, 92.70, 'm', '1999-12-20', NULL)