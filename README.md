# Goods Management Application

## Overview
The Goods Management Application is a WPF-based application developed using C# and .NET Framework. The application aims to provide a comprehensive solution for managing inventory, tracking product details, and handling user accounts efficiently. It is designed to streamline the process of goods management, ensuring that users can easily access and manipulate data related to products and inventory.

## Features
- **User Management**: Admins can create, edit, and delete user accounts, as well as assign roles and permissions.
- **Product Management**: Users can add new products, edit existing product details, and view a list of all products.
- **Inventory Management**: The application allows users to track inventory levels, log inbound and outbound transactions, and receive alerts for low stock.
- **Reporting**: Users can generate reports comparing theoretical and actual usage of products, along with recommendations for future purchases.

## Technologies Used
- **Programming Language**: C#
- **Framework**: WPF (.NET Framework)
- **Database**: SQL Server
- **Architecture**: MVVM (Model-View-ViewModel)

## Project Structure
```
GoodsManagement
├── src
│   ├── GoodsManagement.WPF
│   │   ├── App.xaml
│   │   ├── App.xaml.cs
│   │   ├── Views
│   │   │   ├── LoginWindow.xaml
│   │   │   ├── MainWindow.xaml
│   │   │   ├── UserManagement
│   │   │   │   └── UserManagementView.xaml
│   │   │   ├── ProductManagement
│   │   │   │   ├── ProductListView.xaml
│   │   │   │   └── ProductEditView.xaml
│   │   │   └── Inventory
│   │   │       ├── InventoryView.xaml
│   │   │       └── TransactionView.xaml
│   │   ├── ViewModels
│   │   │   ├── Base
│   │   │   │   └── BaseViewModel.cs
│   │   │   ├── LoginViewModel.cs
│   │   │   ├── MainViewModel.cs
│   │   │   ├── UserManagementViewModel.cs
│   │   │   ├── ProductManagementViewModel.cs
│   │   │   └── InventoryViewModel.cs
│   │   ├── Models
│   │   │   ├── User.cs
│   │   │   ├── Product.cs
│   │   │   ├── Inventory.cs
│   │   │   └── Transaction.cs
│   │   ├── Services
│   │   │   ├── Interfaces
│   │   │   │   ├── IUserService.cs
│   │   │   │   ├── IProductService.cs
│   │   │   │   └── IInventoryService.cs
│   │   │   ├── UserService.cs
│   │   │   ├── ProductService.cs
│   │   │   └── InventoryService.cs
│   │   ├── Data
│   │   │   ├── ApplicationDbContext.cs
│   │   │   └── Repositories
│   │   │       ├── Interfaces
│   │   │       │   ├── IUserRepository.cs
│   │   │       │   ├── IProductRepository.cs
│   │   │       │   └── IInventoryRepository.cs
│   │   │       ├── UserRepository.cs
│   │   │       ├── ProductRepository.cs
│   │   │       └── InventoryRepository.cs
│   │   ├── Utils
│   │   │   ├── Commands
│   │   │   │   └── RelayCommand.cs
│   │   │   ├── Converters
│   │   │   │   └── BoolToVisibilityConverter.cs
│   │   │   └── Helpers
│   │   │       ├── PasswordHelper.cs
│   │   │       └── DialogHelper.cs
│   │   └── Resources
│   │       ├── Styles
│   │       │   └── AppStyles.xaml
│   │       └── Images
├── database
│   └── Scripts
│       ├── CreateTables.sql
│       └── SeedData.sql
├── docs
│   ├── Database_Design.md
│   ├── User_Manual.md
│   └── Technical_Documentation.md
├── tests
│   └── GoodsManagement.Tests
│       ├── Services
│       │   └── UserServiceTests.cs
│       └── ViewModels
│           └── LoginViewModelTests.cs
├── GoodsManagement.sln
└── README.md
```

## Setup Instructions
1. **Install Visual Studio**: Ensure you have Visual Studio installed with the .NET desktop development workload.
2. **Clone the Repository**: Clone this repository to your local machine.
3. **Open the Solution**: Open the `GoodsManagement.sln` file in Visual Studio.
4. **Restore NuGet Packages**: Right-click on the solution in Solution Explorer and select "Restore NuGet Packages".
5. **Configure Database**: Set up SQL Server and run the scripts in `database/Scripts/CreateTables.sql` to create the necessary tables. Optionally, run `SeedData.sql` to populate initial data.
6. **Run the Application**: Set the `GoodsManagement.WPF` project as the startup project and run the application.

## Contribution
Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.