using Microsoft.Data.SqlClient;

namespace Visual.Programming.Project.Grey
{
    internal class DatabaseConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Server=DESKTOP-N0GG48L;
                  Database=ShopHub;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            return new SqlConnection(connectionString);
        }
    }
}