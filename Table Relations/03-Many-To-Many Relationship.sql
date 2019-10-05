CREATE DATABASE Exams

USE Exams

CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL
)

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY,
	[Name] VARCHAR(30) NOT NULL
)

INSERT INTO Students ([Name]) VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams (ExamID, [Name]) VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')

CREATE TABLE StudentsExams(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID) NOT NULL,
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID) NOT NULL,
	CONSTRAINT PK_Composite_StudentsExams_Key
	PRIMARY KEY(StudentID, ExamID)
)

INSERT INTO StudentsExams (StudentID, ExamID) VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)