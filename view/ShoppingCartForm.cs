using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class ShoppingCartForm : Form
    {
        private readonly int customerId;
        private readonly IList<string> sharedCartItems;
        private readonly string customerName;
        private readonly CartController controller = new();
        private readonly MenuItemController menuController = new();
        private IReadOnlyList<MenuItemModel> availableMenuItems = [];

        public ShoppingCartForm() : this(0, [], "Customer")
        {
        }

        public ShoppingCartForm(IList<string> cartItems, string customerName = "Customer")
            : this(0, cartItems, customerName)
        {
        }

        public ShoppingCartForm(int customerId, IList<string> cartItems, string customerName = "Customer")
        {
            InitializeComponent();
            this.customerId = customerId;
            sharedCartItems = cartItems;
            this.customerName = customerName;
            LoadCartItems();
            Shown += ShoppingCartForm_Shown;
        }

        private async void ShoppingCartForm_Shown(object? sender, EventArgs e)
        {
            try
            {
                availableMenuItems = (await menuController.GetAllAsync())
                    .Where(item => item.IsAvailable)
                    .ToList();

                txtProduct.Items.Clear();
                txtProduct.Items.AddRange(availableMenuItems.Select(item => item.ItemName).ToArray());
                await LoadDatabaseCartAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load available menu items.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDatabaseCartAsync()
        {
            if (customerId <= 0)
            {
                return;
            }

            try
            {
                var items = await controller.GetItemsAsync(customerId);
                sharedCartItems.Clear();
                foreach (var item in items)
                {
                    for (var index = 0; index < item.Quantity; index++)
                    {
                        sharedCartItems.Add($"{item.ItemName} - {item.UnitPrice:C}");
                    }
                }

                LoadCartItems();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load the saved basket.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCartItems()
        {
            dgvBasket.Rows.Clear();

            foreach (var item in sharedCartItems)
            {
                var separatorIndex = item.LastIndexOf(" - ", StringComparison.Ordinal);
                var product = separatorIndex > 0 ? item[..separatorIndex] : item;
                var priceText = separatorIndex > 0 ? item[(separatorIndex + 3)..] : "$0.00";
                var price = ParsePrice(priceText);
                dgvBasket.Rows.Add(product, 1, price, price);
            }

            UpdateSummary();
        }

        private static decimal ParsePrice(string value)
        {
            return decimal.TryParse(value, System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture, out var price) ? price : 0m;
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduct.Text))
            {
                MessageBox.Show("Please specify a product.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduct.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out var quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive whole number.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            var menuItem = availableMenuItems.FirstOrDefault(item =>
                item.ItemName.Equals(txtProduct.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (menuItem == null)
            {
                MessageBox.Show(
                    "This product is not available in the database. Add it from the Restaurant Menu screen first.",
                    "Shopping Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtProduct.Focus();
                return;
            }

            var price = menuItem.Price;

            dgvBasket.Rows.Add(txtProduct.Text.Trim(), quantity, price, quantity * price);
            txtProduct.SelectedIndex = -1;
            txtProduct.Text = string.Empty;
            txtQuantity.Text = "1";
            txtPrice.Clear();
            UpdateSummary();
        }

        private void btnRemove_Click(object? sender, EventArgs e)
        {
            if (dgvBasket.CurrentRow == null || dgvBasket.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select an item to remove.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvBasket.Rows.Remove(dgvBasket.CurrentRow);
            UpdateSummary();
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvBasket.CurrentRow == null || dgvBasket.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select an item to edit.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvBasket.CurrentRow;
            if (!int.TryParse(txtQuantity.Text, out var quantity) || quantity <= 0
                || !decimal.TryParse(txtPrice.Text, out var price) || price < 0)
            {
                MessageBox.Show("Enter a valid quantity and price before editing.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            row.Cells[0].Value = string.IsNullOrWhiteSpace(txtProduct.Text) ? row.Cells[0].Value : txtProduct.Text.Trim();
            row.Cells[1].Value = quantity;
            row.Cells[2].Value = price;
            row.Cells[3].Value = quantity * price;
            UpdateSummary();
        }

        private void dgvBasket_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBasket.Rows.Count)
            {
                return;
            }

            var row = dgvBasket.Rows[e.RowIndex];
            txtProduct.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
            txtQuantity.Text = row.Cells[1].Value?.ToString() ?? "1";
            txtPrice.Text = row.Cells[2].Value?.ToString() ?? "0.00";
        }

        private void btnClearBasket_Click(object? sender, EventArgs e)
        {
            if (dgvBasket.Rows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Clear all items from the basket?", "Shopping Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvBasket.Rows.Clear();
                UpdateSummary();
            }
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                await SaveCartItemsAsync();
                MessageBox.Show("Basket saved successfully.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not save the basket.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnClose_Click(object? sender, EventArgs e)
        {
            try
            {
                await SaveCartItemsAsync();
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not save the basket.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPlaceOrder_Click(object? sender, EventArgs e)
        {
            try
            {
                await SaveCartItemsAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not save the basket.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sharedCartItems.Count == 0)
            {
                MessageBox.Show("Add at least one item before placing an order.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var placeOrderForm = new PlaceOrderForm(customerId, customerName, CalculateTotal(), sharedCartItems);
            if (placeOrderForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadCartItems();
            }
        }

        private decimal CalculateTotal()
        {
            var total = 0m;

            foreach (DataGridViewRow row in dgvBasket.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells[3].Value ?? 0m);
                }
            }

            return total;
        }

        private async Task SaveCartItemsAsync()
        {
            var items = new List<(string ItemName, int Quantity, decimal UnitPrice)>();
            sharedCartItems.Clear();

            foreach (DataGridViewRow row in dgvBasket.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var product = row.Cells[0].Value?.ToString() ?? string.Empty;
                var quantity = Convert.ToInt32(row.Cells[1].Value ?? 1);
                var price = Convert.ToDecimal(row.Cells[2].Value ?? 0m);

                items.Add((product, quantity, price));
                for (var index = 0; index < quantity; index++)
                {
                    sharedCartItems.Add($"{product} - {price:C}");
                }
            }

            if (customerId > 0)
            {
                await controller.ReplaceItemsAsync(customerId, items);
            }
        }

        private void UpdateSummary()
        {
            var itemCount = 0;
            var total = 0m;

            foreach (DataGridViewRow row in dgvBasket.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                itemCount += Convert.ToInt32(row.Cells[1].Value ?? 0);
                total += Convert.ToDecimal(row.Cells[3].Value ?? 0m);
            }

            lblNoItemsValue.Text = itemCount.ToString();
            lblTotalValue.Text = total.ToString("C");
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
