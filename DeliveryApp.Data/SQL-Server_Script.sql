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
    PhoneNumber BIGINT NOT NULL,
    Address VARCHAR(500),
)

CREATE TABLE Products (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
    Price INT NOT NULL,
    Details VARCHAR(500),
)

CREATE TABLE Categories (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
)

CREATE TABLE CategoriesProducts (
	CategoryID int FOREIGN KEY REFERENCES Categories(ID),
    ProductID int FOREIGN KEY REFERENCES Products(ID),
)

CREATE TABLE Orders (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    OrderNumber BIGINT NOT NULL,
	DueTime DATETIME NOT NULL,
    TotalPrice BIGINT NOT NULL,
    CustomerId int FOREIGN KEY REFERENCES Customers(ID),    
)

CREATE TABLE OrdersProducts (
    OrderId int FOREIGN KEY REFERENCES Orders(ID),
    ProductID int FOREIGN KEY REFERENCES Products(ID)
)

CREATE TABLE Invoices (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    InvoiceNumber BIGINT NOT NULL,
	ExpeditionDate DATETIME NOT NULL,
    Details VARCHAR(500),
    OrderId int FOREIGN KEY REFERENCES Orders(ID),
)

CREATE TABLE Deliveries (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Status VARCHAR(100) NOT NULL,
    OrderId int FOREIGN KEY REFERENCES Orders(ID),
)
GO

-- Inserting Data

USE [SQLDeliveryDB]

INSERT INTO Products (Name, Price, Details) VALUES ('Pizza', 150, 'Peperoni')
INSERT INTO Products (Name, Price, Details) VALUES ('Coke', 3, 'Light')
INSERT INTO Products (Name, Price) VALUES ('Burguer Cheese', 25)
INSERT INTO Products (Name, Price) VALUES ('Hotdog', 20)
INSERT INTO Products (Name, Price, Details) VALUES ('Salad', 15, 'Small')

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

INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES (12, '20210829 10:34:09 AM', 500, 1)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES (13, '20210827 08:00:00 AM', 600, 2)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES (14, '20210825 12:30:00 PM', 440, 3)

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