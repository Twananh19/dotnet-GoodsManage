using System.Collections.Generic;
using System.Linq;
using GoodsManagement.WPF.Data.Repositories.Interfaces;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;

namespace GoodsManagement.WPF.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void AddProduct(Product product)
        {
            _productRepository.Add(product);
            _productRepository.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetById(id);
            if (product != null)
            {
                _productRepository.Delete(product);
                _productRepository.SaveChanges();
            }
        }

        public IEnumerable<Product> SearchProducts(string searchTerm)
        {
            return _productRepository.GetAll()
                .Where(p => p.ProductName.Contains(searchTerm))
                .ToList();
        }
    }
}