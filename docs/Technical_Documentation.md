# Technical Documentation for Goods Management Application

## 1. Introduction
This document provides a comprehensive overview of the technical aspects of the Goods Management Application developed using C# and WPF .NET Framework. The application aims to facilitate efficient inventory management, user management, and product management.

## 2. Architecture
The application follows the Model-View-ViewModel (MVVM) architectural pattern, which separates the user interface (View) from the business logic (ViewModel) and data (Model). This separation enhances maintainability and testability.

### 2.1 Components
- **Models**: Represent the data structure of the application.
  - User
  - Product
  - Inventory
  - Transaction
- **Views**: Define the user interface components.
  - LoginWindow
  - MainWindow
  - UserManagementView
  - ProductListView
  - ProductEditView
  - InventoryView
  - TransactionView
- **ViewModels**: Handle the logic and data binding for the Views.
  - LoginViewModel
  - MainViewModel
  - UserManagementViewModel
  - ProductManagementViewModel
  - InventoryViewModel

## 3. Database Design
The application uses SQL Server as the database management system. The database schema includes the following tables:
- **Users**: Stores user information and roles.
- **Products**: Stores product details including name, packaging, unit of measurement, and price.
- **Inventory**: Tracks the stock quantity of products.
- **InboundLogs**: Records incoming product transactions.
- **OutboundLogs**: Records outgoing product transactions.

## 4. Services
The application includes several services that encapsulate business logic:
- **UserService**: Manages user-related operations such as authentication and authorization.
- **ProductService**: Handles product-related operations including CRUD functionalities.
- **InventoryService**: Manages inventory operations and alerts.

## 5. User Interface
The user interface is designed to be intuitive and user-friendly. Key features include:
- Login functionality for user authentication.
- Management views for users and products.
- Inventory tracking and transaction management.

## 6. Testing
Unit tests are implemented for critical components of the application, ensuring reliability and correctness. The tests cover:
- UserService
- LoginViewModel

## 7. Deployment
The application can be deployed on any Windows environment with .NET Framework installed. The database scripts for creating tables and seeding initial data are provided in the `database/Scripts` directory.

## 8. Conclusion
This technical documentation outlines the structure and functionality of the Goods Management Application. The application is designed to be scalable and maintainable, providing a solid foundation for future enhancements.