-- SQL script to seed initial data into the database for the Goods Management application

-- Insert initial users
INSERT INTO Users (Username, PasswordHash, Role)
VALUES 
('admin', 'hashed_password_for_admin', 'Admin'),
('user1', 'hashed_password_for_user1', 'User'),
('user2', 'hashed_password_for_user2', 'User');

-- Insert initial products
INSERT INTO Products (ProductName, Packaging, UnitOfMeasurement, Price)
VALUES 
('Product A', 'Box', 'kg', 10.00),
('Product B', 'Bottle', 'liters', 5.50),
('Product C', 'Packet', 'pieces', 2.00);

-- Insert initial inventory data
INSERT INTO Inventory (ProductId, StockQuantity, LastUpdated)
VALUES 
(1, 100, GETDATE()),
(2, 200, GETDATE()),
(3, 150, GETDATE());

-- Insert initial inbound logs
INSERT INTO InboundLogs (ProductId, Quantity, Date)
VALUES 
(1, 50, GETDATE()),
(2, 100, GETDATE());

-- Insert initial outbound logs
INSERT INTO OutboundLogs (ProductId, Quantity, Date)
VALUES 
(1, 20, GETDATE()),
(2, 30, GETDATE());