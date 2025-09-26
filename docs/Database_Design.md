# Database Design Documentation for Goods Management Application

## Overview
This document outlines the database design for the Goods Management application. The application is built using C# and WPF .NET Framework, and it utilizes SQL Server as the database management system. The design focuses on managing users, products, inventory, and transactions effectively.

## Entity Relationship Diagram (ERD)
The following entities are defined in the database:

1. **User**
   - Represents the users of the application, including Admin and regular users.

2. **Product**
   - Represents the products managed within the application.

3. **Inventory**
   - Represents the current stock levels of products.

4. **Transaction**
   - Represents the inbound and outbound transactions of products.

## Database Tables

### 1. Users Table
- **Table Name**: Users
- **Columns**:
  - `UserId` (PK, int): Unique identifier for each user.
  - `Username` (string, unique): The username of the user.
  - `PasswordHash` (string): Hashed password for authentication.
  - `Role` (string): Role of the user ('Admin' or 'User').

### 2. Products Table
- **Table Name**: Products
- **Columns**:
  - `ProductId` (PK, int): Unique identifier for each product.
  - `ProductName` (string): Name of the product.
  - `Packaging` (string): Packaging type (e.g., box, carton).
  - `UnitOfMeasurement` (string): The smallest unit of measurement (e.g., kg, liter).
  - `Price` (decimal): Price of the product.

### 3. Inventory Table
- **Table Name**: Inventory
- **Columns**:
  - `InventoryId` (PK, int): Unique identifier for each inventory record.
  - `ProductId` (FK, int): Foreign key referencing the Products table.
  - `StockQuantity` (int): Current stock quantity of the product.
  - `LastUpdated` (datetime): Timestamp of the last update to the inventory.

### 4. InboundLogs Table
- **Table Name**: InboundLogs
- **Columns**:
  - `LogId` (PK, int): Unique identifier for each inbound log.
  - `ProductId` (FK, int): Foreign key referencing the Products table.
  - `Quantity` (int): Quantity of products received.
  - `Date` (datetime): Date of the inbound transaction.

### 5. OutboundLogs Table
- **Table Name**: OutboundLogs
- **Columns**:
  - `LogId` (PK, int): Unique identifier for each outbound log.
  - `ProductId` (FK, int): Foreign key referencing the Products table.
  - `Quantity` (int): Quantity of products dispatched.
  - `Date` (datetime): Date of the outbound transaction.

## Relationships
- **Users** can have multiple roles but are primarily categorized as Admin or User.
- **Products** are linked to **Inventory** through the `ProductId`.
- **InboundLogs** and **OutboundLogs** reference **Products** to track stock movements.

## Conclusion
This database design provides a structured approach to managing users, products, inventory, and transactions within the Goods Management application. The relationships between the tables ensure data integrity and facilitate efficient data retrieval for application functionalities.