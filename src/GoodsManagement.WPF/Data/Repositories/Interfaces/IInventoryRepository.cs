namespace GoodsManagement.WPF.Data.Repositories.Interfaces
{
    public interface IInventoryRepository
    {
        // Method to get all inventory items
        IEnumerable<Inventory> GetAllInventoryItems();

        // Method to get an inventory item by its ID
        Inventory GetInventoryItemById(int id);

        // Method to add a new inventory item
        void AddInventoryItem(Inventory inventory);

        // Method to update an existing inventory item
        void UpdateInventoryItem(Inventory inventory);

        // Method to delete an inventory item
        void DeleteInventoryItem(int id);

        // Method to get the current stock quantity of a product
        int GetStockQuantity(int productId);

        // Method to update stock quantity after a transaction
        void UpdateStockQuantity(int productId, int quantity);
    }
}