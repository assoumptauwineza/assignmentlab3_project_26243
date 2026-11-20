using foododering.DAO;
using foododering.Model;

namespace foododering.Controller
{
    public sealed class CartController
    {
        private readonly CartDao cartDao = new();

        public Task<IReadOnlyList<CartItemModel>> GetItemsAsync(int customerId)
        {
            return cartDao.GetItemsAsync(customerId);
        }

        public async Task AddItemByNameAsync(int customerId, string itemName, int quantity, decimal unitPrice)
        {
            var menuItem = await cartDao.GetMenuItemByNameAsync(itemName);
            if (menuItem == null)
            {
                throw new InvalidOperationException($"The available menu item '{itemName}' was not found.");
            }

            await AddItemAsync(customerId, menuItem.MenuItemId, quantity, unitPrice > 0 ? unitPrice : menuItem.Price);
        }

        public Task AddItemAsync(int customerId, int menuItemId, int quantity, decimal unitPrice)
        {
            if (customerId <= 0) throw new ArgumentOutOfRangeException(nameof(customerId));
            if (menuItemId <= 0) throw new ArgumentOutOfRangeException(nameof(menuItemId));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (unitPrice < 0) throw new ArgumentOutOfRangeException(nameof(unitPrice));
            return cartDao.AddItemAsync(customerId, menuItemId, quantity, unitPrice);
        }

        public Task UpdateItemQuantityAsync(int cartItemId, int quantity)
        {
            if (cartItemId <= 0) throw new ArgumentOutOfRangeException(nameof(cartItemId));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            return cartDao.UpdateItemQuantityAsync(cartItemId, quantity);
        }

        public Task RemoveItemAsync(int cartItemId)
        {
            if (cartItemId <= 0) throw new ArgumentOutOfRangeException(nameof(cartItemId));
            return cartDao.RemoveItemAsync(cartItemId);
        }

        public Task ClearAsync(int customerId) => cartDao.ClearAsync(customerId);

        public async Task ReplaceItemsAsync(int customerId, IEnumerable<(string ItemName, int Quantity, decimal UnitPrice)> items)
        {
            await cartDao.ClearAsync(customerId);

            foreach (var item in items)
            {
                await AddItemByNameAsync(customerId, item.ItemName, item.Quantity, item.UnitPrice);
            }
        }
    }
}
