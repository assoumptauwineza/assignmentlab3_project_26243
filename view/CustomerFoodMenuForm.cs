using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class CustomerFoodMenuForm : Form
    {
        private readonly int customerId;
        private readonly IList<string> sharedCartItems;
        private readonly MenuItemController menuController = new();
        private readonly CartController cartController = new();
        private IReadOnlyList<MenuItemModel> menuItems = [];

        public CustomerFoodMenuForm(int customerId, IList<string> sharedCartItems)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.sharedCartItems = sharedCartItems;
            Shown += CustomerFoodMenuForm_Shown;
        }

        private async void CustomerFoodMenuForm_Shown(object? sender, EventArgs e)
        {
            await LoadMenuAsync();
        }

        private async Task LoadMenuAsync()
        {
            try
            {
                await menuController.EnsureRestaurantAsync();
                menuItems = (await menuController.GetAllAsync())
                    .Where(item => item.IsAvailable)
                    .ToList();
                RefreshMenuGrid();
                lblStatus.Text = menuItems.Count == 0
                    ? "No available food items have been added yet."
                    : $"{menuItems.Count} available food item(s).";
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load the food menu.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMenuGrid()
        {
            dgvMenu.Rows.Clear();
            var searchText = txtSearch.Text.Trim();

            foreach (var item in menuItems.Where(item => string.IsNullOrWhiteSpace(searchText)
                || item.ItemName.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                || item.Category.Contains(searchText, StringComparison.OrdinalIgnoreCase)))
            {
                dgvMenu.Rows.Add(item.MenuItemId, item.ItemName, item.Description,
                    item.Price.ToString("N0"), item.Category, "Available");
            }
        }

        private async void btnAddToCart_Click(object? sender, EventArgs e)
        {
            var item = GetSelectedItem();
            if (item == null)
            {
                MessageBox.Show("Select a food item first.", "Food Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantity = Convert.ToInt32(numQuantity.Value);
            try
            {
                if (customerId > 0)
                {
                    await cartController.AddItemAsync(customerId, item.MenuItemId, quantity, item.Price);
                }

                for (var index = 0; index < quantity; index++)
                {
                    sharedCartItems.Add($"{item.ItemName} - {item.Price:C}");
                }

                lblStatus.Text = $"{item.ItemName} added to your cart.";
                MessageBox.Show("Food added to cart successfully.", "Food Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not add the food to your cart.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MenuItemModel? GetSelectedItem()
        {
            if (dgvMenu.CurrentRow == null || dgvMenu.CurrentRow.IsNewRow)
            {
                return null;
            }

            var menuItemId = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            return menuItems.FirstOrDefault(item => item.MenuItemId == menuItemId);
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            RefreshMenuGrid();
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            _ = LoadMenuAsync();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
