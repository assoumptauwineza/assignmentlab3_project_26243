using foododering.Connection;
using foododering.Model;
using MySqlConnector;

namespace foododering.DAO
{
    public sealed class DeliveryDao
    {
        public async Task<IReadOnlyList<DeliveryModel>> GetAllAsync()
        {
            var deliveries = new List<DeliveryModel>();
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = """
                SELECT d.DeliveryId, d.OrderId, o.OrderNumber, d.DeliveryPersonId,
                       customer.Name AS CustomerName, deliveryPerson.Name AS DeliveryPersonName,
                       o.DeliveryAddress, d.DeliveryStatus, d.AssignedAt, d.PickedUpAt, d.DeliveredAt
                FROM deliveries d
                INNER JOIN orders o ON o.OrderId = d.OrderId
                INNER JOIN users customer ON customer.UserId = o.CustomerId
                INNER JOIN users deliveryPerson ON deliveryPerson.UserId = d.DeliveryPersonId
                ORDER BY d.DeliveryId DESC;
                """;
            await using var command = new MySqlCommand(sql, connection);
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                deliveries.Add(new DeliveryModel
                {
                    DeliveryId = reader.GetInt32("DeliveryId"),
                    OrderId = reader.GetInt32("OrderId"),
                    OrderNumber = reader.GetString("OrderNumber"),
                    DeliveryPersonId = reader.GetInt32("DeliveryPersonId"),
                    CustomerName = reader.GetString("CustomerName"),
                    DeliveryPersonName = reader.GetString("DeliveryPersonName"),
                    DeliveryAddress = reader.GetString("DeliveryAddress"),
                    DeliveryStatus = reader.GetString("DeliveryStatus"),
                    AssignedAt = reader.IsDBNull(reader.GetOrdinal("AssignedAt")) ? null : reader.GetDateTime("AssignedAt"),
                    PickedUpAt = reader.IsDBNull(reader.GetOrdinal("PickedUpAt")) ? null : reader.GetDateTime("PickedUpAt"),
                    DeliveredAt = reader.IsDBNull(reader.GetOrdinal("DeliveredAt")) ? null : reader.GetDateTime("DeliveredAt")
                });
            }

            return deliveries;
        }

        public async Task InsertAsync(int orderId, int deliveryPersonId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "INSERT INTO deliveries (OrderId, DeliveryPersonId, DeliveryStatus, AssignedAt) VALUES (@OrderId, @DeliveryPersonId, 'Assigned', CURRENT_TIMESTAMP);";
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@OrderId", orderId);
            command.Parameters.AddWithValue("@DeliveryPersonId", deliveryPersonId);
            await command.ExecuteNonQueryAsync();
        }

        public async Task UpdateStatusAsync(int deliveryId, string status)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = """
                UPDATE deliveries
                SET DeliveryStatus = @Status,
                    PickedUpAt = CASE WHEN @Status = 'PickedUp' THEN CURRENT_TIMESTAMP ELSE PickedUpAt END,
                    DeliveredAt = CASE WHEN @Status = 'Delivered' THEN CURRENT_TIMESTAMP ELSE DeliveredAt END
                WHERE DeliveryId = @DeliveryId;
                """;
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@DeliveryId", deliveryId);
            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int deliveryId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "DELETE FROM deliveries WHERE DeliveryId = @DeliveryId;";
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DeliveryId", deliveryId);
            await command.ExecuteNonQueryAsync();
        }
    }
}
