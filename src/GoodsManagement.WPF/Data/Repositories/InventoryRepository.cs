using System.Collections.Generic;
using System.Linq;
using GoodsManagement.WPF.Data;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Data.Repositories.Interfaces;

namespace GoodsManagement.WPF.Data.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly ApplicationDbContext _context;

        public InventoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Inventory> GetAllInventories()
        {
            return _context.Inventories.ToList();
        }

        public Inventory GetInventoryById(int id)
        {
            return _context.Inventories.FirstOrDefault(i => i.InventoryId == id);
        }

        public void AddInventory(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
        }

        public void UpdateInventory(Inventory inventory)
        {
            _context.Inventories.Update(inventory);
            _context.SaveChanges();
        }

        public void DeleteInventory(int id)
        {
            var inventory = GetInventoryById(id);
            if (inventory != null)
            {
                _context.Inventories.Remove(inventory);
                _context.SaveChanges();
            }
        }
    }
}