-- Creating Database

USE [master]
IF EXISTS(select * from sys.databases where name='SQLDeliveryDB')
DROP DATABASE SQLDeliveryDB
GO

CREATE DATABASE [SQLDeliveryDB]
GO

-- Creating Tables

USE [SQLDeliveryDB]

CREATE TABLE Customers (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
    PhoneNumber INT NOT NULL,
    Address VARCHAR(500),
)

CREATE TABLE Products (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
    Price INT NOT NULL,
)

CREATE TABLE Categories (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
)

CREATE TABLE CategoriesProducts (
	CategoryID INT FOREIGN KEY REFERENCES Categories(ID),
    ProductID INT FOREIGN KEY REFERENCES Products(ID),
)

CREATE TABLE Orders (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    OrderNumber VARCHAR(10) NOT NULL,
	DueTime DATETIME NOT NULL,
    TotalPrice INT NOT NULL,
    CustomerId INT FOREIGN KEY REFERENCES Customers(ID),    
)

CREATE TABLE OrdersProducts (
    OrderId INT FOREIGN KEY REFERENCES Orders(ID),
    ProductID INT FOREIGN KEY REFERENCES Products(ID),
    ProductQuantity INT NOT NULL,
    ProductDetails VARCHAR(500),
)

CREATE TABLE Invoices (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    InvoiceNumber VARCHAR(10) NOT NULL,
	ExpeditionDate DATETIME NOT NULL,
    OrderId INT FOREIGN KEY REFERENCES Orders(ID),
)

CREATE TABLE Deliveries (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Status VARCHAR(100) NOT NULL,
    OrderId INT FOREIGN KEY REFERENCES Orders(ID),
)
GO

-- Inserting Data

USE [SQLDeliveryDB]

INSERT INTO Products (Name, Price) VALUES ('Pizza', 150)
INSERT INTO Products (Name, Price) VALUES ('Coke', 3)
INSERT INTO Products (Name, Price) VALUES ('Burguer Cheese', 25)
INSERT INTO Products (Name, Price) VALUES ('Hotdog', 20)
INSERT INTO Products (Name, Price) VALUES ('Salad', 15)

INSERT INTO Categories (Name) VALUES ('Fast Food')
INSERT INTO Categories (Name) VALUES ('Beverage')
INSERT INTO Categories (Name) VALUES ('Vegetarian Food')

INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 1)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (2, 2)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 3)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 4)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (3, 5)

INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Jhon Doe', 555678, 'Avenue 123')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Von Stamp', 789670, 'Route 111' )
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Herbert Barrett', 555678, 'Street 677')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Claudia Hyatt', 555678, 'St. Louis 12w')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Ann Labrecque', 555678, 'Bvd. 333')

INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('554', '20210829 10:34:09 AM', 500, 1)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('325', '20210827 08:00:00 AM', 600, 2)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('889', '20210825 12:30:00 PM', 440, 3)

INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity, ProductDetails) VALUES (1, 1, 2, 'peperoni')
INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity, ProductDetails) VALUES (1, 3, 4, 'onion')
INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity) VALUES (1, 4, 5)

INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 1)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 2)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 3)
GO

SELECT * FROM Customers
SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM CategoriesProducts
SELECT * FROM Orders
SELECT * FROM OrdersProducts
SELECT * FROM Invoices
SELECT * FROM Deliveries
GO