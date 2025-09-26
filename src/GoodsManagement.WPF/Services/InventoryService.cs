using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Data.Repositories.Interfaces;

namespace GoodsManagement.WPF.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<List<Inventory>> GetAllInventoriesAsync()
        {
            return await _inventoryRepository.GetAllAsync();
        }

        public async Task<Inventory> GetInventoryByIdAsync(int id)
        {
            return await _inventoryRepository.GetByIdAsync(id);
        }

        public async Task AddInventoryAsync(Inventory inventory)
        {
            await _inventoryRepository.AddAsync(inventory);
        }

        public async Task UpdateInventoryAsync(Inventory inventory)
        {
            await _inventoryRepository.UpdateAsync(inventory);
        }

        public async Task DeleteInventoryAsync(int id)
        {
            await _inventoryRepository.DeleteAsync(id);
        }

        public async Task<List<Inventory>> GetLowStockInventoriesAsync(int threshold)
        {
            return await _inventoryRepository.GetLowStockInventoriesAsync(threshold);
        }
    }
}