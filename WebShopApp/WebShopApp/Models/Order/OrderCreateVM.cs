﻿using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Order
{
    public class OrderCreateVM
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int QuantityInStock { get; set; }
        public string? Picture { get; set; }

        [Range(1,100)]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
