using foododering.Connection;
using foododering.Model;
using MySqlConnector;

namespace foododering.DAO
{
    public sealed class OrderDao
    {
        public async Task<string> CreateAsync(int customerId, int restaurantId, string deliveryAddress, decimal totalAmount, string paymentStatus)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            var orderNumber = $"ORD{DateTime.UtcNow:yyyyMMddHHmmssfff}";
            const string sql = """
                INSERT INTO orders
                    (OrderNumber, CustomerId, RestaurantId, DeliveryAddress, OrderDate, TotalAmount, OrderStatus, PaymentStatus)
                VALUES
                    (@OrderNumber, @CustomerId, @RestaurantId, @DeliveryAddress, CURRENT_TIMESTAMP, @TotalAmount, 'Pending', @PaymentStatus);
                """;

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@OrderNumber", orderNumber);
            command.Parameters.AddWithValue("@CustomerId", customerId);
            command.Parameters.AddWithValue("@RestaurantId", restaurantId);
            command.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
            command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
            await command.ExecuteNonQueryAsync();
            return orderNumber;
        }

        public async Task<IReadOnlyList<OrderModel>> GetForCustomerAsync(int customerId)
        {
            var orders = await GetAllAsync();
            return orders.Where(order => order.CustomerId == customerId).ToList();
        }

        public async Task<IReadOnlyList<OrderModel>> GetAllAsync(string searchText = "")
        {
            var orders = new List<OrderModel>();
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = """
                SELECT o.OrderId, o.OrderNumber, o.CustomerId, o.RestaurantId,
                       u.Name AS CustomerName, r.RestaurantName,
                       o.DeliveryAddress, o.OrderDate, o.TotalAmount,
                       o.OrderStatus, o.PaymentStatus
                FROM orders o
                INNER JOIN users u ON u.UserId = o.CustomerId
                INNER JOIN restaurants r ON r.RestaurantId = o.RestaurantId
                WHERE @Search = '' OR o.OrderNumber LIKE @Pattern
                   OR u.Name LIKE @Pattern OR r.RestaurantName LIKE @Pattern
                ORDER BY o.OrderDate DESC;
                """;
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Search", searchText);
            command.Parameters.AddWithValue("@Pattern", $"%{searchText}%");
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                orders.Add(new OrderModel
                {
                    OrderId = reader.GetInt32("OrderId"),
                    OrderNumber = reader.GetString("OrderNumber"),
                    CustomerId = reader.GetInt32("CustomerId"),
                    RestaurantId = reader.GetInt32("RestaurantId"),
                    CustomerName = reader.GetString("CustomerName"),
                    RestaurantName = reader.GetString("RestaurantName"),
                    DeliveryAddress = reader.GetString("DeliveryAddress"),
                    OrderDate = reader.GetDateTime("OrderDate"),
                    TotalAmount = reader.GetDecimal("TotalAmount"),
                    OrderStatus = reader.GetString("OrderStatus"),
                    PaymentStatus = reader.GetString("PaymentStatus")
                });
            }

            return orders;
        }

        public async Task UpdateStatusAsync(int orderId, string status)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "UPDATE orders SET OrderStatus = @Status WHERE OrderId = @OrderId;";
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@OrderId", orderId);
            await command.ExecuteNonQueryAsync();
        }
    }
}
