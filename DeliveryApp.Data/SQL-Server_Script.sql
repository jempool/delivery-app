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
	ID INT NOT NULL PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    PhoneNumber BIGINT NOT NULL,
    Address VARCHAR(500),
)

CREATE TABLE Products (
	ID INT NOT NULL PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
    Price INT  NOT NULL,
    Details VARCHAR(500),
)

CREATE TABLE Categories (
	ID INT NOT NULL PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
)

CREATE TABLE CategoriesProducts (
	CategoryID int FOREIGN KEY REFERENCES Categories(ID),
    ProductID int FOREIGN KEY REFERENCES Products(ID),
)

CREATE TABLE Orders (
	ID INT NOT NULL PRIMARY KEY,
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
	ID INT NOT NULL PRIMARY KEY,
    InvoiceNumber BIGINT NOT NULL,
	ExpeditionDate DATETIME NOT NULL,
    OrderId int FOREIGN KEY REFERENCES Orders(ID),
)

CREATE TABLE Deliveries (
	ID INT NOT NULL PRIMARY KEY,
	Status BIT NOT NULL,
    OrderId int FOREIGN KEY REFERENCES Orders(ID),
)
GO

-- Inserting Data

USE [SQLDeliveryDB]

INSERT INTO Products (ID, Name, Price, Details) VALUES (1, 'Pizza', 150, 'Peperoni')
INSERT INTO Products (ID, Name, Price, Details) VALUES (2, 'Coke', 3, 'Light')
INSERT INTO Products (ID, Name, Price) VALUES (3, 'Burguer Cheese', 25)
INSERT INTO Products (ID, Name, Price) VALUES (4, 'Hotdog', 20)
INSERT INTO Products (ID, Name, Price, Details) VALUES (5, 'Salad', 15, 'Small')

INSERT INTO Categories (ID, Name) VALUES (1, 'Fast Food')
INSERT INTO Categories (ID, Name) VALUES (2, 'Beverage')
INSERT INTO Categories (ID, Name) VALUES (3, 'Vegetarian Food')

INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 1)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (2, 2)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 3)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (1, 4)
INSERT INTO CategoriesProducts (CategoryID, ProductID) VALUES (3, 5)
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