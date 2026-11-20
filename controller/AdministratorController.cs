using foododering.DAO;
using foododering.Model;

namespace foododering.Controller
{
    public sealed class AdministratorController
    {
        private readonly UserAccountDao userAccountDao = new();
        private readonly OrderDao orderDao = new();

        public Task<IReadOnlyList<UserAccountModel>> GetUsersAsync() => userAccountDao.GetAllAsync();
        public Task SetUserStatusAsync(int userId, string status) => userAccountDao.UpdateStatusAsync(userId, status);
        public Task DeleteUserAsync(int userId) => userAccountDao.DeleteAsync(userId);
        public Task RegisterAsync(string username, string password) => userAccountDao.RegisterAsync(username, password);
        public Task<UserAccountModel?> AuthenticateAsync(string username, string password) => userAccountDao.AuthenticateAsync(username, password);
        public Task<IReadOnlyList<OrderModel>> SearchOrdersAsync(string searchText = "") => orderDao.GetAllAsync(searchText);
        public Task SetOrderStatusAsync(int orderId, string status) => orderDao.UpdateStatusAsync(orderId, status);
        public Task<string> CreateOrderAsync(int customerId, int restaurantId, string deliveryAddress, decimal totalAmount, string paymentStatus)
            => orderDao.CreateAsync(customerId, restaurantId, deliveryAddress, totalAmount, paymentStatus);
        public Task<IReadOnlyList<OrderModel>> GetCustomerOrdersAsync(int customerId) => orderDao.GetForCustomerAsync(customerId);
    }
}
