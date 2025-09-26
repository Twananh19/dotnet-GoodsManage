using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;
using GoodsManagement.WPF.Utils.Commands;

namespace GoodsManagement.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IInventoryService _inventoryService;

        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Inventory> Inventories { get; set; }

        public ICommand LoadDataCommand { get; }
        public ICommand LogoutCommand { get; }

        public MainViewModel(IUserService userService, IProductService productService, IInventoryService inventoryService)
        {
            _userService = userService;
            _productService = productService;
            _inventoryService = inventoryService;

            Users = new ObservableCollection<User>();
            Products = new ObservableCollection<Product>();
            Inventories = new ObservableCollection<Inventory>();

            LoadDataCommand = new RelayCommand(LoadData);
            LogoutCommand = new RelayCommand(Logout);
        }

        private void LoadData()
        {
            var users = _userService.GetAllUsers();
            Users.Clear();
            foreach (var user in users)
            {
                Users.Add(user);
            }

            var products = _productService.GetAllProducts();
            Products.Clear();
            foreach (var product in products)
            {
                Products.Add(product);
            }

            var inventories = _inventoryService.GetAllInventories();
            Inventories.Clear();
            foreach (var inventory in inventories)
            {
                Inventories.Add(inventory);
            }
        }

        private void Logout()
        {
            // Logic for logging out the user
        }
    }
}