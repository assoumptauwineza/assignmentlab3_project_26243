using foododering.Connection;
using MySqlConnector;

namespace foododering.DAO
{
    public sealed class RestaurantDao
    {
        public async Task EnsureDefaultAsync()
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string selectSql = "SELECT RestaurantId FROM restaurants WHERE RestaurantId = @RestaurantId LIMIT 1;";
            await using var selectCommand = new MySqlCommand(selectSql, connection);
            selectCommand.Parameters.AddWithValue("@RestaurantId", 1);
            var existingId = await selectCommand.ExecuteScalarAsync();
            if (existingId != null && existingId != DBNull.Value)
            {
                return;
            }

            const string insertSql = "INSERT INTO restaurants (RestaurantId, RestaurantName) VALUES (@RestaurantId, @RestaurantName);";
            await using var insertCommand = new MySqlCommand(insertSql, connection);
            insertCommand.Parameters.AddWithValue("@RestaurantId", 1);
            insertCommand.Parameters.AddWithValue("@RestaurantName", "Food Ordering Restaurant");
            await insertCommand.ExecuteNonQueryAsync();
        }
    }
}
