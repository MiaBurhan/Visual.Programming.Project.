using System;
using System.Collections.Generic;
using System.Text;

namespace Visual.Programming.Project.Grey
{
    internal class OrderManager
    {
        // In-memory order history. For production, replace with persistent storage.
        public static readonly List<Order> Orders = new();
        // Event raised when a new order is added so UI can refresh
        internal static event Action<Order> OrderAdded;

        // Add an order and return it
        public static Order AddOrder(string productName, string customerName, decimal price = 0m, string email = "", string imagePath = null)
        {
            var order = new Order
            {
                Id = Orders.Count + 1,
                ProductName = productName,
                CustomerName = customerName,
                Price = price,
                Email = email,
                ImagePath = imagePath,
                CreatedAt = DateTime.UtcNow
            };
            // insert newest order at the beginning so it appears at the top in order views
            Orders.Insert(0, order);
            // notify listeners that a new order was added
            try { OrderAdded?.Invoke(order); } catch { }
            // Persist to Excel (best-effort)
            try
            {
                Helpers.ExcelHelper.AppendOrder(order.Id, order.ProductName, order.CustomerName, order.Price, order.Email, order.CreatedAt);
            }
            catch
            {
                // ignore persistence errors to avoid breaking UI
            }

            return order;
        }
    }
}
