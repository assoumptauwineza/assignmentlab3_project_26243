using MySqlConnector;

namespace foododering.Connection
{
    public static class DatabaseConnection
    {
        public const string ConnectionString =
            "Server=127.0.0.1;Port=3306;Database=foodorderingdb;User ID=root;Password=;";

        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection(out string message)
        {
            using var connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                message = "Database connected successfully!";
                return true;
            }
            catch (MySqlException exception)
            {
                message = $"Database error: {exception.Message}";
                return false;
            }
        }
    }
}
