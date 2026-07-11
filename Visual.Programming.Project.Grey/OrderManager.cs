using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

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

            // Persist to SQL Server (best-effort). Table will be created if it does not exist.
            try
            {
                using var con = new SqlConnection(Database.connectionString);
                con.Open();

                string ensureTable = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders' AND schema_id = SCHEMA_ID('dbo'))
BEGIN
    CREATE TABLE dbo.Orders (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        ProductName NVARCHAR(256) NOT NULL,
        CustomerName NVARCHAR(256) NOT NULL,
        Quantity INT NOT NULL DEFAULT 1,
     
        CreatedAt DATETIME2 NOT NULL
    );
END
";

                using (var cmdEnsure = new SqlCommand(ensureTable, con))
                {
                    cmdEnsure.ExecuteNonQuery();
                }

                string insert = @"INSERT INTO dbo.Orders (ProductName, CustomerName, Quantity, CreatedAt)
VALUES (@ProductName, @CustomerName, @Quantity, @CreatedAt);";

                using var cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@ProductName", (object)order.ProductName ?? string.Empty);
                cmd.Parameters.AddWithValue("@CustomerName", (object)order.CustomerName ?? string.Empty);
                cmd.Parameters.AddWithValue("@Quantity", 1);
                //cmd.Parameters.AddWithValue("@Price", order.Price);
                //cmd.Parameters.AddWithValue("@Email", (object)order.Email ?? string.Empty);
                //cmd.Parameters.AddWithValue("@ImagePath", (object)order.ImagePath ?? string.Empty);
                cmd.Parameters.AddWithValue("@CreatedAt", order.CreatedAt);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                // ignore DB errors to avoid breaking UI
            }

            return order;
        }
    }
}
