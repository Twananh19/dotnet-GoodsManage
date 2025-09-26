using System.Collections.ObjectModel;
using System.Windows.Input;
using GoodsManagement.WPF.Models;
using GoodsManagement.WPF.Services.Interfaces;
using GoodsManagement.WPF.Utils.Commands;

namespace GoodsManagement.WPF.ViewModels
{
    public class InventoryViewModel : BaseViewModel
    {
        private readonly IInventoryService _inventoryService;
        private ObservableCollection<Inventory> _inventoryItems;
        private Inventory _selectedInventoryItem;

        public ObservableCollection<Inventory> InventoryItems
        {
            get => _inventoryItems;
            set
            {
                _inventoryItems = value;
                OnPropertyChanged();
            }
        }

        public Inventory SelectedInventoryItem
        {
            get => _selectedInventoryItem;
            set
            {
                _selectedInventoryItem = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadInventoryCommand { get; }
        public ICommand AddInventoryCommand { get; }
        public ICommand UpdateInventoryCommand { get; }
        public ICommand DeleteInventoryCommand { get; }

        public InventoryViewModel(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
            LoadInventoryCommand = new RelayCommand(LoadInventory);
            AddInventoryCommand = new RelayCommand(AddInventory);
            UpdateInventoryCommand = new RelayCommand(UpdateInventory, CanExecuteUpdateOrDelete);
            DeleteInventoryCommand = new RelayCommand(DeleteInventory, CanExecuteUpdateOrDelete);
            InventoryItems = new ObservableCollection<Inventory>();
        }

        private void LoadInventory()
        {
            var items = _inventoryService.GetAllInventoryItems();
            InventoryItems.Clear();
            foreach (var item in items)
            {
                InventoryItems.Add(item);
            }
        }

        private void AddInventory()
        {
            // Logic to add a new inventory item
        }

        private void UpdateInventory()
        {
            // Logic to update the selected inventory item
        }

        private void DeleteInventory()
        {
            // Logic to delete the selected inventory item
        }

        private bool CanExecuteUpdateOrDelete()
        {
            return SelectedInventoryItem != null;
        }
    }
}