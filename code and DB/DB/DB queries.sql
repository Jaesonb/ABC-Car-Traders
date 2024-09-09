-- Create Users table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    UserType NVARCHAR(10) CHECK (UserType IN ('admin', 'customer')) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100)
);
GO

-- Create Cars table
CREATE TABLE Cars (
    CarID INT IDENTITY(1,1) PRIMARY KEY,
    CarName NVARCHAR(100) NOT NULL,
    Brand NVARCHAR(50),
    ModelYear INT,
    Price DECIMAL(10, 2)
);
GO

-- Create CarParts table
CREATE TABLE CarParts (
    PartID INT IDENTITY(1,1) PRIMARY KEY,
    PartName NVARCHAR(100) NOT NULL,
    CarID INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (CarID) REFERENCES Cars(CarID)
);
GO

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10, 2),
    Status NVARCHAR(10) CHECK (Status IN ('Pending', 'Completed', 'Cancelled')) DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- Create OrderDetails table
CREATE TABLE OrderDetails (
    OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT,
    CarID INT,
    PartID INT,
    Quantity INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (CarID) REFERENCES Cars(CarID),
    FOREIGN KEY (PartID) REFERENCES CarParts(PartID)
);
GO


SELECT * FROM [ABC Car Traders].[dbo].[Users]

SELECT * FROM [ABC Car Traders].[dbo].[Cars]


UPDATE dbo.Users
SET UserType = 'admin'
WHERE Username = 'admin';

UPDATE dbo.Users
SET UserType = 'customer'
WHERE Username = 'customer';

