using foododering.DAO;
using foododering.Model;

namespace foododering.Controller
{
    public sealed class MenuItemController
    {
        private readonly MenuItemDao menuItemDao = new();
        private readonly RestaurantDao restaurantDao = new();

        public Task EnsureRestaurantAsync() => restaurantDao.EnsureDefaultAsync();

        public Task<IReadOnlyList<MenuItemModel>> GetAllAsync() => menuItemDao.GetAllAsync();

        public Task<int> AddAsync(int restaurantId, string itemName, string description, decimal price, string category, bool isAvailable)
        {
            if (restaurantId <= 0) throw new ArgumentOutOfRangeException(nameof(restaurantId));
            if (string.IsNullOrWhiteSpace(itemName)) throw new ArgumentException("Food name is required.", nameof(itemName));
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            return menuItemDao.AddAsync(restaurantId, itemName.Trim(), description.Trim(), price, category.Trim(), isAvailable);
        }

        public Task UpdateAsync(MenuItemModel item)
        {
            ArgumentNullException.ThrowIfNull(item);
            return menuItemDao.UpdateAsync(item);
        }

        public Task DeleteAsync(int menuItemId)
        {
            if (menuItemId <= 0) throw new ArgumentOutOfRangeException(nameof(menuItemId));
            return menuItemDao.DeleteAsync(menuItemId);
        }
    }
}
