CREATE DATABASE SoftUni

CREATE TABLE Towns (
 Id INT PRIMARY KEY IDENTITY,
 [Name] VARCHAR(30) NOT NULL
)

INSERT INTO Towns VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

CREATE TABLE Addresses (
 Id INT PRIMARY KEY IDENTITY,
 AddressText VARCHAR(100),
 TownId INT FOREIGN KEY REFERENCES Towns(Id),
)

INSERT INTO Addresses VALUES
('some address', 1)

CREATE TABLE Departments (
 Id INT PRIMARY KEY IDENTITY,
 [Name] VARCHAR(30) NOT NULL
)

--Engineering, Sales, Marketing, Software Development, Quality Assurance
INSERT INTO Departments VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

CREATE TABLE Employees (
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(30) NOT NULL,
 MiddleName NVARCHAR(30),
 LastName NVARCHAR(30) NOT NULL,
 JobTitle VARCHAR(50) NOT NULL,
 DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
 HireDate DATE NOT NULL,
 Salary DECIMAL(6, 2) NOT NULL,
 AddressId INT FOREIGN KEY REFERENCES Addresses(Id)
)

INSERT INTO Employees VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00, 1),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00, 1),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25, 1),
('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00, 1),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88, 1)