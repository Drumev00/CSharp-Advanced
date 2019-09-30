CREATE DATABASE Hotel

CREATE TABLE Employees (
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(30) NOT NULL,
 LastName NVARCHAR(30) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Employees VALUES
('Kolyo', 'Iliev', NULL),
('Ivailo', 'Iliev', 'Doing well'),
('Alexander', 'Drumev', 'Newbie')

CREATE TABLE Customers (
 AccountNumber INT NOT NULL,
 FirstName NVARCHAR(30) NOT NULL,
 LastName NVARCHAR(30) NOT NULL,
 PhoneNumber VARCHAR(15),
 EmergencyName VARCHAR(30),
 EmergencyNumber INT NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Customers VALUES
(444, 'Philip', 'Johnson', NULL, NULL, 12, NULL),
(124, 'William', 'Peterson', 555086, NULL, 32, NULL),
(611, 'Michael', 'Mitev', 0896532755, NULL, 12, NULL)

CREATE TABLE RoomStatus (
 RoomStatus VARCHAR(20) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO RoomStatus VALUES
('In use', 'Free in 2 days!'),
('Empty', 'Free'),
('Empty', 'Free')

CREATE TABLE RoomTypes (
 RoomType VARCHAR(20) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO RoomTypes VALUES
('Double room', NULL),
('Single room', NULL),
('Apartment', '6 beds')

CREATE TABLE BedTypes (
 BedType VARCHAR(20) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO BedTypes VALUES
('Water bed', NULL),
('Hard mattress', NULL),
('Simple mattress', NULL)

CREATE TABLE Rooms (
 RoomNumber SMALLINT NOT NULL,
 RoomType VARCHAR(20) NOT NULL,
 BedType VARCHAR(20) NOT NULL,
 Rate DECIMAL(2, 1),
 RoomStatus VARCHAR(20) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Rooms VALUES
(301, 'Double room', 'Water bed', 4.1, 'In use', NULL),
(302, 'Single', 'Hard mattress', 3.8, 'Empty', NULL),
(303, 'Apartment', 'Simple mattress', 5.3, 'Empty', NULL)

CREATE TABLE Payments (
 Id INT PRIMARY KEY IDENTITY,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
 PaymentDate DATE NOT NULL,
 AccountNumber INT NOT NULL,
 FirstDateOccupied DATE NOT NULL,
 LastDateOccupied DATE NOT NULL,
 TotalDays INT,
 AmountCharged INT NOT NULL,
 TaxRate DECIMAL(5, 2) NOT NULL,
 TaxAmount INT,
 PaymentTotal AS AmountCharged + TaxRate,
 Notes VARCHAR(MAX)
)

INSERT INTO Payments VALUES
(3, '2019-06-15', 721, '2019-06-15', '2019-06-18', 3, 120, 50, 0, NULL),
(2, '2019-04-01', 122, '2019-04-01', '2019-04-05', 4, 160, 80, 0, NULL),
(1, '2019-01-11', 669, '2019-01-11', '2019-01-18', 7, 220, 150, 0, NULL)

CREATE TABLE Occupancies (
 Id INT PRIMARY KEY IDENTITY,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
 DateOccupied DATE NOT NULL,
 AccountNumber INT NOT NULL,
 RoomNumber SMALLINT NOT NULL,
 RateApplied BIT NOT NULL,
 PhoneCharge BIT NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Occupancies VALUES
(3, '2019-06-15', 721, 301, 1, 1, NULL),
(2, '2019-04-01', 122, 302, 1, 0, NULL),
(1, '2019-01-11', 669, 303, 0, 1, NULL)