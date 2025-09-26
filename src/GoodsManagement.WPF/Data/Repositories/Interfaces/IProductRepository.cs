namespace GoodsManagement.WPF.Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        // Get all products
        IEnumerable<Product> GetAllProducts();

        // Get a product by its ID
        Product GetProductById(int productId);

        // Add a new product
        void AddProduct(Product product);

        // Update an existing product
        void UpdateProduct(Product product);

        // Delete a product by its ID
        void DeleteProduct(int productId);

        // Search products by name
        IEnumerable<Product> SearchProducts(string productName);
    }
}