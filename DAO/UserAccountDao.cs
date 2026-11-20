using foododering.Connection;
using foododering.Model;
using MySqlConnector;
using System.Security.Cryptography;

namespace foododering.DAO
{
    public sealed class UserAccountDao
    {
        public async Task RegisterAsync(string username, string password)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                INSERT INTO users
                    (Name, Password)
                VALUES
                    (@Name, @Password);
                """;

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", username);
            command.Parameters.AddWithValue("@Password", HashPassword(password));
            await command.ExecuteNonQueryAsync();
        }

        public async Task<UserAccountModel?> AuthenticateAsync(string username, string password)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();

            const string sql = """
                SELECT UserId, Name, Password
                FROM users
                WHERE Name = @Name
                LIMIT 1;
                """;

            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", username);
            await using var reader = await command.ExecuteReaderAsync();
            if (!await reader.ReadAsync())
            {
                return null;
            }

            var storedHash = reader.GetString("Password");
            if (!VerifyPassword(password, storedHash))
            {
                return null;
            }

            return new UserAccountModel
            {
                UserId = reader.GetInt32("UserId"),
                FullName = reader.GetString("Name"),
                Username = reader.GetString("Name"),
                PasswordHash = storedHash,
                UserType = "Customer",
                AccountStatus = "Active",
                CreatedAt = DateTime.MinValue
            };
        }

        public async Task<IReadOnlyList<UserAccountModel>> GetAllAsync()
        {
            var users = new List<UserAccountModel>();
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "SELECT UserId, Name, Password FROM users ORDER BY UserId;";
            await using var command = new MySqlCommand(sql, connection);
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                users.Add(new UserAccountModel
                {
                    UserId = reader.GetInt32("UserId"),
                    FullName = reader.GetString("Name"),
                    Username = reader.GetString("Name"),
                    PasswordHash = reader.GetString("Password"),
                    UserType = "Customer",
                    AccountStatus = "Active",
                    CreatedAt = DateTime.MinValue
                });
            }

            return users;
        }

        public async Task UpdateStatusAsync(int userId, string status)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            throw new NotSupportedException("The users table contains only UserId, Name, and Password; account status is not available.");
        }

        private static string HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(16);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);
            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        private static bool VerifyPassword(string password, string storedValue)
        {
            var parts = storedValue.Split('.', 2);
            if (parts.Length != 2)
            {
                return password == storedValue;
            }

            var salt = Convert.FromBase64String(parts[0]);
            var expectedHash = Convert.FromBase64String(parts[1]);
            var actualHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, expectedHash.Length);
            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }

        public async Task DeleteAsync(int userId)
        {
            await using var connection = DatabaseConnection.CreateConnection();
            await connection.OpenAsync();
            const string sql = "DELETE FROM users WHERE UserId = @UserId;";
            await using var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@UserId", userId);
            await command.ExecuteNonQueryAsync();
        }
    }
}
