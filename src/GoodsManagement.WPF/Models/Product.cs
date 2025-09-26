using System;

namespace GoodsManagement.WPF.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Packaging { get; set; }
        public string UnitOfMeasurement { get; set; }
        public decimal Price { get; set; }
    }
}