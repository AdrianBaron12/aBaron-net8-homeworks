CREATE DATABASE AddressHW

USE AddressHW;

CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

--1
INSERT INTO Addresses (StreetName, StreetNumber, City) VALUES
    ('123 Main St', 1, 'City A'),
    ('456 Elm St', 2, 'City B'),
    ('789 Oak St', 3, 'City C'),
    ('101 Pine St', 4, 'City A'),
    ('202 Maple St', 5, 'City B');

INSERT INTO Customers (Name, Age, AddressId) VALUES
    ('Name1', 25, 1),
    ('Name2', 30, 2),
    ('Name3', 18, 3),
    ('Name4', 40, 4),
    ('Name5', 28, 5);


INSERT INTO Orders (Details, CustomerId) VALUES
    ('Order 1 Details', 1),
    ('Order 2 Details', 2),
    ('Order 3 Details', 3),
    ('Order 4 Details', 4),
    ('Order 5 Details', 5);


INSERT INTO Products (Name) VALUES
    ('Product A'),
    ('Product B'),
    ('Product C'),
    ('Product D'),
    ('Product E');


INSERT INTO Orders_Products (OrderId, ProductId) VALUES
    (1, 1),
    (1, 2),
    (2, 3),
    (3, 4),
    (4, 5);

    --2 

    SELECT * FROM Customers WHERE Age > 15;

    --3

    SELECT COUNT(*) AS TotalAddresses FROM Addresses;

    --4

    UPDATE Products SET Name = 'New Product' WHERE Id > 2;

    --5

    ALTER TABLE Customers ADD Email VARCHAR(100);

    --6

    UPDATE Customers SET Email = 'example1@sql.com' WHERE Id <= 3;
    UPDATE Customers SET Email = 'example2@sql.com' WHERE Id > 3;

    --7

    SELECT Customers.Id, Customers.Name, Customers.Age, Orders.Details
    FROM Customers
    JOIN Orders ON Customers.Id = Orders.CustomerId;

--8

    SELECT Customers.Id, Customers.Name, Customers.Age, Orders.Details
    FROM Customers
    JOIN Orders ON Customers.Id = Orders.CustomerId
    JOIN Addresses ON Customers.AddressId = Addresses.Id;