using System.Data.SqlClient;

namespace AgroDoc
{
    public static class DbHelper
    {
        // Configured for your SQL Server instance: Suffix\SQLEXPRESS
        public static string ConnectionString = @"Server=DESKTOP-GVBF3HT\SQLEXPRESS;Database=AgroDocDb;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}