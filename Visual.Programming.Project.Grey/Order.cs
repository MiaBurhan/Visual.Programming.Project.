using System;
using System.Collections.Generic;
using System.Text;

namespace Visual.Programming.Project.Grey
{
    internal class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string PriceDisplay => Price <= 0 ? "" : Price.ToString("C");
    }
 }
