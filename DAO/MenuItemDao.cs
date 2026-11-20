using foododering.Connection;
using foododering.Model;
using MySqlConnector;

namespace foododering.DAO
{
    public sealed class MenuItemDao
    {
        public async Task<IReadOnlyList<MenuItemModel>> GetAllAsync()
        {
            var items = new List<MenuItemModel>();
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                SELECT MenuItemId, RestaurantId, ItemName, Description, Price, Category, IsAvailable
                FROM menuitems
                ORDER BY MenuItemId;
                """;

            await using var command = new MySqlCommand(sql, connection);
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                items.Add(new MenuItemModel
                {
                    MenuItemId = reader.GetInt32("MenuItemId"),
                    RestaurantId = reader.GetInt32("RestaurantId"),
                    ItemName = reader.GetString("ItemName"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? string.Empty : reader.GetString("Description"),
                    Price = reader.GetDecimal("Price"),
                    Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? string.Empty : reader.GetString("Category"),
                    IsAvailable = reader.GetBoolean("IsAvailable")
                });
            }

            return items;
        }

        public async Task<int> AddAsync(int restaurantId, string itemName, string description, decimal price, string category, bool isAvailable)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                INSERT INTO menuitems (RestaurantId, ItemName, Description, Price, Category, IsAvailable)
                VALUES (@RestaurantId, @ItemName, @Description, @Price, @Category, @IsAvailable);
                SELECT LAST_INSERT_ID();
                """;

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@RestaurantId", restaurantId);
            command.Parameters.AddWithValue("@ItemName", itemName);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@IsAvailable", isAvailable);
            return Convert.ToInt32(await command.ExecuteScalarAsync());
        }

        public async Task UpdateAsync(MenuItemModel item)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                UPDATE menuitems
                SET ItemName = @ItemName,
                    Description = @Description,
                    Price = @Price,
                    Category = @Category,
                    IsAvailable = @IsAvailable
                WHERE MenuItemId = @MenuItemId;
                """;

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MenuItemId", item.MenuItemId);
            command.Parameters.AddWithValue("@ItemName", item.ItemName);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Parameters.AddWithValue("@Price", item.Price);
            command.Parameters.AddWithValue("@Category", item.Category);
            command.Parameters.AddWithValue("@IsAvailable", item.IsAvailable);
            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int menuItemId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "DELETE FROM menuitems WHERE MenuItemId = @MenuItemId;";
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MenuItemId", menuItemId);
            await command.ExecuteNonQueryAsync();
        }
    }
}
