# User Manual for Goods Management Application

## Table of Contents
1. Introduction
2. System Requirements
3. Installation
4. Application Overview
5. User Management
6. Product Management
7. Inventory Management
8. Troubleshooting
9. Support

## 1. Introduction
The Goods Management Application is designed to help businesses manage their inventory efficiently. This application allows users to track products, manage user accounts, and monitor inventory levels.

## 2. System Requirements
- Operating System: Windows 10 or later
- .NET Framework: 4.7.2 or later
- SQL Server: 2017 or later (Express edition is sufficient)
- Minimum 4 GB RAM
- Minimum 500 MB free disk space

## 3. Installation
1. **Download the Application**: Obtain the latest version of the Goods Management Application from the repository.
2. **Install SQL Server**: Ensure that SQL Server is installed and running on your machine. You can download SQL Server Express from the official Microsoft website.
3. **Set Up the Database**:
   - Open SQL Server Management Studio.
   - Run the SQL scripts located in the `database/Scripts` folder:
     - `CreateTables.sql` to create the necessary tables.
     - `SeedData.sql` to populate the database with initial data.
4. **Run the Application**: Open the solution file `GoodsManagement.sln` in your preferred IDE and run the application.

## 4. Application Overview
The application consists of several modules:
- **User Management**: Manage user accounts and permissions.
- **Product Management**: Add, edit, and view products.
- **Inventory Management**: Track inventory levels and transactions.

## 5. User Management
### Login
- Launch the application and enter your credentials.
- Admin users have full access, while regular users have limited access based on assigned permissions.

### Managing Users
- Navigate to the User Management section to add or edit user accounts.
- Admins can assign roles (Admin/User) to each account.

## 6. Product Management
### Adding Products
- Go to the Product Management section.
- Click on "Add Product" and fill in the required fields: Product Name, Packaging, Unit of Measurement, and Price.

### Viewing Products
- The product list displays all products with their details.
- You can search for products using the search functionality.

## 7. Inventory Management
### Viewing Inventory
- Access the Inventory Management section to view current stock levels.
- The application will alert you if stock levels fall below the defined threshold.

### Managing Transactions
- Record inbound and outbound transactions to keep track of inventory changes.
- The application calculates the stock levels automatically based on transactions.

## 8. Troubleshooting
- **Login Issues**: Ensure that your username and password are correct. If you forget your password, contact the admin for a reset.
- **Database Connection Errors**: Verify that SQL Server is running and that the connection string in the application is correctly configured.

## 9. Support
For further assistance, please contact the support team at support@goodsmanagementapp.com or refer to the technical documentation available in the `docs` folder.