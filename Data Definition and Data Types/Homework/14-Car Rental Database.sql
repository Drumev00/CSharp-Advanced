CREATE DATABASE CarRental

CREATE TABLE Categories (
 Id INT PRIMARY KEY IDENTITY,
 CategoryName VARCHAR(30) NOT NULL,
 DailyRate DECIMAL(4, 2) NOT NULL,
 WeeklyRate DECIMAL(5, 2) NOT NULL,
 MonthlyRate DECIMAL(6, 2) NOT NULL,
 WeekendRate DECIMAL (5, 2) NOT NULL
)

INSERT INTO Categories VALUES
('Car', 60.00, 349.99, 1099.99, 95.00),
('Truck', 80.00, 569.99, 1399.99, 99.00),
('Motorcycle', 70.00, 409.99, 1199.99, 80.00)

CREATE TABLE Cars (
 Id INT PRIMARY KEY IDENTITY,
 PlateNumber NVARCHAR(15) NOT NULL,
 Manufacturer VARCHAR(30) NOT NULL,
 Model VARCHAR(30) NOT NULL,
 CarYear INT NOT NULL,
 CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
 Doors INT,
 Picture VARBINARY,
 Condition VARCHAR(MAX) NOT NULL,
 Available BIT
)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('ฦย 1024 ลา', 'Mitsubishi', 'Some Model', 2001, 2, 4, NULL, 'Good', 1),
('MT 6068 FB', 'Suzuki', 'Some Model', 2005, 2, 4, NULL, 'A little bit rusty', 1),
('KT 3381 ON', 'Renault', 'Some Model', 1991, 3, 2, NULL, 'Needs a service', 0)

CREATE TABLE Employees (
 Id INT PRIMARY KEY IDENTITY,
 FirstName NVARCHAR(30) NOT NULL,
 LastName NVARCHAR(30) NOT NULL,
 Title VARCHAR(30) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO Employees VALUES
('Pesho', 'Peshev', 'Mechanic', 'Doing well'),
('Ivan', 'Dragomirov', 'Engineer', 'Doing well'),
('Alexander', 'Drumev', 'Student', 'At least trying')

CREATE TABLE Customers (
 Id INT PRIMARY KEY IDENTITY,
 DriverLicenseNumber INT NOT NULL,
 FullName NVARCHAR(60) NOT NULL,
 [Address] VARCHAR(MAX),
 City VARCHAR(30) NOT NULL,
 ZIPCode INT,
 Notes VARCHAR(MAX)
)

INSERT INTO Customers VALUES
(1632899, 'Toncho Gerov', NULL, 'Varna', 021, NULL),
(1638269, 'Gosho Gerov', NULL, 'Burgas', 056, NULL),
(1224623, 'Dancho Petellov', NULL, 'Varna', 021, NULL)

CREATE TABLE RentalOrders (
 Id INT PRIMARY KEY IDENTITY,
 EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
 CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
 CarId INT FOREIGN KEY REFERENCES Cars(Id),
 TankLevel INT NOT NULL,
 KilometrageStart INT NOT NULL,
 KilometrageEnd INT NOT NULL,
 TotalKilometrage AS KilometrageEnd - KilometrageStart,
 StartDate DATE NOT NULL,
 EndDate DATE NOT NULL,
 TotalDays INT,
 RateApplied BIT,
 TaxRate INT NOT NULL,
 OrderStatus VARCHAR(30) NOT NULL,
 Notes VARCHAR(MAX)
)

INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd,
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 2, 2, 90, 3, 80, '2019-09-22', '2019-09-25', 3, 1, 20, 'In progress', NULL),
(3, 1, 3, 70, 2, 90, '2019-09-23', '2019-09-17', 4, 0, 15, 'Waiting', NULL),
(2, 3, 3, 100, 8, 350, '2019-09-23', '2019-09-30', 7, 1, 20, 'Rent', NULL)