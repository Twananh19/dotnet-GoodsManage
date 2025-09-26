using System.Collections.ObjectModel;
using System.Windows.Input;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;
using GoodsManagement.WPF.Utils.Commands;

namespace GoodsManagement.WPF.ViewModels
{
    public class ProductManagementViewModel : BaseViewModel
    {
        private readonly IProductService _productService;
        private ObservableCollection<Product> _products;
        private Product _selectedProduct;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddProductCommand { get; }
        public ICommand EditProductCommand { get; }
        public ICommand DeleteProductCommand { get; }

        public ProductManagementViewModel(IProductService productService)
        {
            _productService = productService;
            Products = new ObservableCollection<Product>(_productService.GetAllProducts());

            AddProductCommand = new RelayCommand(AddProduct);
            EditProductCommand = new RelayCommand(EditProduct, CanEditOrDeleteProduct);
            DeleteProductCommand = new RelayCommand(DeleteProduct, CanEditOrDeleteProduct);
        }

        private void AddProduct()
        {
            // Logic to add a new product
        }

        private void EditProduct()
        {
            // Logic to edit the selected product
        }

        private void DeleteProduct()
        {
            // Logic to delete the selected product
        }

        private bool CanEditOrDeleteProduct()
        {
            return SelectedProduct != null;
        }
    }
}