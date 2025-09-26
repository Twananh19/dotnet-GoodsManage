namespace GoodsManagement.WPF.Services.Interfaces
{
    public interface IInventoryService
    {
        // Method to get the current inventory for a specific product
        Inventory GetInventoryByProductId(int productId);

        // Method to add new inventory for a product
        void AddInventory(int productId, int quantity);

        // Method to update existing inventory for a product
        void UpdateInventory(int productId, int quantity);

        // Method to get a list of all inventory items
        IEnumerable<Inventory> GetAllInventories();

        // Method to check if inventory is below a certain threshold
        bool IsInventoryLow(int productId, int threshold);
    }
}