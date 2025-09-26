namespace GoodsManagement.WPF.Services.Interfaces
{
    public interface IProductService
    {
        // Adds a new product to the inventory
        void AddProduct(Product product);

        // Updates an existing product in the inventory
        void UpdateProduct(Product product);

        // Deletes a product from the inventory
        void DeleteProduct(int productId);

        // Retrieves a product by its ID
        Product GetProductById(int productId);

        // Retrieves all products in the inventory
        IEnumerable<Product> GetAllProducts();

        // Searches for products based on a search term
        IEnumerable<Product> SearchProducts(string searchTerm);
    }
}