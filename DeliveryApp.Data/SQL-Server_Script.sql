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

INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Jhon Doe', 55560678, '777 Brockton Avenue')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Von Stamp', 78966570, 'Abington MA 2351' )
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Herbert Barrett', 55561178, '30 Memorial Drive')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Claudia Hyatt', 55567844, 'Avon MA 2322')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Ann Labrecque', 55567867, '250 Hartford Avenue')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Jhon Smith', 98765400, 'Bellingham MA 2019')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Billie Lyons', 98768954, '700 Oak Street')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Landon Becerra', 98768954, '700 Oak Street')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Mitch Collum', 98768954, '700 Oak Street')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Samantha Billman', 98768954, '700 Oak Street')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Bobbie Barcus', 98768954, '66-4 Parkhurst Rd')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Alissa Smith', 98768954, 'Chelmsford MA 1824')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Rose Bush', 98768954, '591 Memorial Dr')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Gordon Miller', 11168954, '1775 Washington St')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Carla Strauss', 22368957, 'Hanover MA 2339')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Jhon Taylor', 99868928, '280 Washington Street')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Monica Wilson', 68760990, 'Lynn MA 1905')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('Andre Kotn', 78768977, '506 State Road')
INSERT INTO Customers (Name, PhoneNumber, Address) VALUES ('', 18768900, 'North Reading MA 1864')

INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD001', '20210829 10:34:09 AM', 500, 1)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD002', '20210828 08:00:00 AM', 600, 2)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD003', '20210828 12:10:00 PM', 440, 3)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD004', '20210829 10:34:09 AM', 510, 4)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD005', '20210828 09:00:00 AM', 610, 5)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD006', '20210830 12:30:00 PM', 1440, 6)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD007', '20210831 10:34:09 AM', 900, 7)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD008', '20210831 01:00:00 PM', 800, 8)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD009', '20210831 12:20:00 PM', 340, 9)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD010', '20210830 10:34:09 AM', 530, 10)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD011', '20210901 08:00:00 AM', 660, 11)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD012', '20210901 12:30:00 PM', 110, 12)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD013', '20210902 10:34:09 AM', 1500, 13)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD014', '20210903 08:00:00 AM', 600, 1)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD015', '20210901 12:30:00 PM', 140, 2)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD016', '20210901 10:20:09 PM', 550, 3)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD017', '20210902 08:20:00 AM', 670, 4)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD018', '20210902 11:40:00 PM', 190, 5)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD019', '20210904 11:40:00 PM', 550, 6)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD020', '20210904 11:40:00 PM', 900, 7)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD021', '20210904 11:40:00 PM', 1190, 8)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD022', '20210902 11:40:00 PM', 590, 9)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD023', '20210902 11:40:00 PM', 160, 10)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD024', '20210901 11:40:00 PM', 600, 11)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD025', '20210827 11:40:00 PM', 330, 12)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD026', '20210828 11:40:00 PM', 210, 13)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD027', '20210829 11:40:00 PM', 790, 1)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD028', '20210901 11:40:00 PM', 990, 2)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD029', '20210830 11:40:00 PM', 960, 14)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD031', '20210830 12:40:00 PM', 1980, 15)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD032', '20210830 01:40:00 PM', 290, 16)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD033', '20210830 02:40:00 PM', 360, 17)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD034', '20210830 11:40:00 PM', 490, 18)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD035', '20210830 11:40:00 PM', 590, 18)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD036', '20210830 03:40:00 PM', 680, 14)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD037', '20210831 11:40:00 PM', 760, 15)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD038', '20210831 04:40:00 PM', 890, 16)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD039', '20210831 11:40:00 PM', 1990, 17)
INSERT INTO Orders (OrderNumber, DueTime, TotalPrice, CustomerId) VALUES ('ORD040', '20210831 05:40:00 AM', 560, 18)

INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity, ProductDetails) VALUES (1, 1, 2, 'peperoni')
INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity, ProductDetails) VALUES (1, 3, 4, 'onion')
INSERT INTO OrdersProducts (OrderId, ProductID, ProductQuantity) VALUES (1, 4, 5)

INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 1)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 2)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 3)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 3)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 4)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 5)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 6)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 7)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 8)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 9)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 10)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 11)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 12)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 13)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 14)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 15)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 16)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 17)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 18)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 19)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 20)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 21)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 22)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 23)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 24)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 25)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 26)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 27)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 28)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 29)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 30)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 31)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 32)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 33)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 34)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 35)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 36)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 37)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Shipping', 38)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Pending', 39)
INSERT INTO Deliveries (Status, OrderId) VALUES ('Delivered', 40)
--
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

-- CREATE INDEX indexed_names ON Customers (Name);