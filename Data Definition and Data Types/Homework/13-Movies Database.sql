CREATE DATABASE Movies

CREATE TABLE Directors (
 Id INT PRIMARY KEY IDENTITY,
 DirectorName VARCHAR(50) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Directors VALUES
('Davind Lynch', 'Twisted mind'),
('Some director', NULL),
('Miro', NULL),
('Cool director', NULL),
('director0', NULL)

CREATE TABLE Genres (
 Id INT PRIMARY KEY IDENTITY,
 GenreName VARCHAR(30) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Genres VALUES
('Horror', 'almost favorite'),
('Plot Twist', 'awesome'),
('Thriller', 'cool'),
('Sci-Fi', 'beyond cool'),
('Criminal', 'great')


CREATE TABLE Categories (
 Id INT PRIMARY KEY IDENTITY,
 CategoryName VARCHAR(30) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Categories VALUES
('Emotional', NULL),
('Some category', NULL),
('idk what', NULL),
('category of movie', NULL),
('Is', NULL)

CREATE TABLE Movies (
 Id INT PRIMARY KEY IDENTITY,
 Title NVARCHAR(50) NOT NULL,
 DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
 CopyrightYear INT,
 [Length] TIME NOT NULL,
 GenreId INT FOREIGN KEY REFERENCES Genres(Id),
 CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
 Rating DECIMAL(2, 1),
 Notes VARCHAR(MAX)
)

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes) VALUES
('Some movie', 1, 1991, '2:04:33', 3, 3,  6, 'Awesome movie!!'),
('Just movie', 4, 1984, '1:54:35', 2, 3,  4.6, 'Great movie!!'),
('Eraserhead', 1, 1976, '1:44:32', 2, 4,  1.3, 'Strange movie'),
('Mooovie', 5, 2014, '2:12:33', 5, 2,  3.9, 'Awesome movie!!'),
('Another movie', 3, 2004, '1:25:13', 2, 5,  5.2, 'Just movie!!')