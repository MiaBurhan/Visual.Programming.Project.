using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Visual.Programming.Project.Grey
{
    /// <summary>
    /// Manages order operations including database insertion and tracking.
    /// Maintains in-memory order history and provides notifications when new orders are added.
    /// </summary>
    internal class OrderManager
    {
        /// <summary>
        /// In-memory collection storing all orders. Used for quick access and UI refresh.
        /// </summary>
        public static readonly List<Order> Orders = new();

        /// <summary>
        /// Event triggered when a new order is successfully added to the system.
        /// Listeners can subscribe to this event to refresh UI or perform other actions.
        /// </summary>
        internal static event Action<Order> OrderAdded;

        /// <summary>
        /// Creates a new order, inserts it into the database, and adds it to the in-memory collection.
        /// </summary>
        /// <param name="productName">The name of the product being ordered</param>
        /// <param name="customerName">The name of the customer placing the order</param>
        /// <param name="price">The price of the order (default: 0m)</param>
        /// <param name="email">The customer's email address (default: empty string)</param>
        /// <param name="imagePath">Optional path to the product image</param>
        /// <returns>The created Order object if successful; null if an error occurred</returns>
        public static Order AddOrder(string productName, string customerName, decimal price = 0m, string email = "", string imagePath = null)
        {
            // Create new Order object with provided details
            Order order = new Order
            {
                Id = Orders.Count + 1,
                ProductName = productName,
                CustomerName = customerName,
                Quantity = 1,
                Price = price,
                Email = email,
                ImagePath = imagePath,
                CreatedAt = DateTime.Now
            };

            try
            {
                // Open database connection and insert order record
                using (SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();

                    // SQL query to insert order into database
                    string query = @"INSERT INTO Orders
            (UserEmail, ProductId, ProductName, Price, Quantity)
            VALUES
            (@UserEmail, @ProductId, @ProductName, @Price, @Quantity)";

                    // Create command and add parameters to prevent SQL injection
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserEmail", email);
                        cmd.Parameters.AddWithValue("@ProductId", order.Id);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", 1);

                        // Execute insert operation
                        cmd.ExecuteNonQuery();
                    }
                }

                // Add order to in-memory collection for quick access
                Orders.Insert(0, order);

                // Notify subscribers about the new order (UI refresh, etc.)
                try
                {
                    OrderAdded?.Invoke(order);
                }
                catch
                {
                    // Suppress errors in event handlers to ensure order is still created
                }

                // Append order to Excel export file for record keeping
                try
                {
                    Helpers.ExcelHelper.AppendOrder(
                        order.Id,
                        order.ProductName,
                        order.CustomerName,
                        order.Price,
                        order.Email,
                        order.CreatedAt);
                }
                catch
                {
                    // Suppress errors in Excel export to ensure order is still saved
                }

                return order;
            }
            catch (Exception ex)
            {
                // Show error message to user and return null to indicate failure
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}