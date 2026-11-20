using foododering.Connection;
using foododering.Model;

namespace foododering.DAO
{
    public sealed class CartDao
    {
        public async Task<MenuItemModel?> GetMenuItemByNameAsync(string itemName)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                SELECT MenuItemId, RestaurantId, ItemName, Description, Price, Category, IsAvailable
                FROM menuitems
                WHERE ItemName = @ItemName AND IsAvailable = TRUE
                LIMIT 1;
                """;

            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ItemName", itemName);
            await using var reader = await command.ExecuteReaderAsync();
            if (!await reader.ReadAsync())
            {
                return null;
            }

            return new MenuItemModel
            {
                MenuItemId = reader.GetInt32("MenuItemId"),
                RestaurantId = reader.GetInt32("RestaurantId"),
                ItemName = reader.GetString("ItemName"),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? string.Empty : reader.GetString("Description"),
                Price = reader.GetDecimal("Price"),
                Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? string.Empty : reader.GetString("Category"),
                IsAvailable = reader.GetBoolean("IsAvailable")
            };
        }

        public async Task<int> GetOrCreateCartIdAsync(int customerId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string selectSql = "SELECT CartId FROM carts WHERE CustomerId = @CustomerId LIMIT 1;";
            await using (var selectCommand = new MySqlConnector.MySqlCommand(selectSql, connection))
            {
                selectCommand.Parameters.AddWithValue("@CustomerId", customerId);
                var existingId = await selectCommand.ExecuteScalarAsync();
                if (existingId != null && existingId != DBNull.Value)
                {
                    return Convert.ToInt32(existingId);
                }
            }

            const string insertSql = "INSERT INTO carts (CustomerId) VALUES (@CustomerId); SELECT LAST_INSERT_ID();";
            await using var insertCommand = new MySqlConnector.MySqlCommand(insertSql, connection);
            insertCommand.Parameters.AddWithValue("@CustomerId", customerId);
            return Convert.ToInt32(await insertCommand.ExecuteScalarAsync());
        }

        public async Task<IReadOnlyList<CartItemModel>> GetItemsAsync(int customerId)
        {
            var items = new List<CartItemModel>();
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                SELECT ci.CartItemId, ci.CartId, ci.MenuItemId, m.ItemName,
                       ci.Quantity, ci.UnitPrice
                FROM carts c
                INNER JOIN cartitems ci ON ci.CartId = c.CartId
                INNER JOIN menuitems m ON m.MenuItemId = ci.MenuItemId
                WHERE c.CustomerId = @CustomerId
                ORDER BY ci.CartItemId;
                """;

            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CustomerId", customerId);
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                items.Add(new CartItemModel
                {
                    CartItemId = reader.GetInt32("CartItemId"),
                    CartId = reader.GetInt32("CartId"),
                    MenuItemId = reader.GetInt32("MenuItemId"),
                    ItemName = reader.GetString("ItemName"),
                    Quantity = reader.GetInt32("Quantity"),
                    UnitPrice = reader.GetDecimal("UnitPrice")
                });
            }

            return items;
        }

        public async Task AddItemAsync(int customerId, int menuItemId, int quantity, decimal unitPrice)
        {
            var cartId = await GetOrCreateCartIdAsync(customerId);
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                INSERT INTO cartitems (CartId, MenuItemId, Quantity, UnitPrice)
                VALUES (@CartId, @MenuItemId, @Quantity, @UnitPrice)
                ON DUPLICATE KEY UPDATE Quantity = Quantity + @Quantity, UnitPrice = @UnitPrice;
                """;

            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CartId", cartId);
            command.Parameters.AddWithValue("@MenuItemId", menuItemId);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@UnitPrice", unitPrice);
            await command.ExecuteNonQueryAsync();
        }

        public async Task UpdateItemQuantityAsync(int cartItemId, int quantity)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "UPDATE cartitems SET Quantity = @Quantity WHERE CartItemId = @CartItemId;";
            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@CartItemId", cartItemId);
            await command.ExecuteNonQueryAsync();
        }

        public async Task RemoveItemAsync(int cartItemId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "DELETE FROM cartitems WHERE CartItemId = @CartItemId;";
            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CartItemId", cartItemId);
            await command.ExecuteNonQueryAsync();
        }

        public async Task ClearAsync(int customerId)
        {
            var cartId = await GetOrCreateCartIdAsync(customerId);
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "DELETE FROM cartitems WHERE CartId = @CartId;";
            await using var command = new MySqlConnector.MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CartId", cartId);
            await command.ExecuteNonQueryAsync();
        }
    }
}
