using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class RestaurantMenuForm : Form
    {
        private readonly MenuItemController controller = new();
        private IReadOnlyList<MenuItemModel> menuItems = [];
        private const int DefaultRestaurantId = 1;

        public RestaurantMenuForm()
        {
            InitializeComponent();
            picFood.Image = Properties.Resources._111;
            Shown += RestaurantMenuForm_Shown;
        }

        private async void RestaurantMenuForm_Shown(object? sender, EventArgs e)
        {
            try
            {
                await controller.EnsureRestaurantAsync();
                await LoadMenuAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not prepare the restaurant menu.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadMenuAsync()
        {
            try
            {
                menuItems = await controller.GetAllAsync();
                RefreshMenuGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load menu items from the database.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var rowIndex = dgvMenu.Rows.Add(item.MenuItemId, item.ItemName, item.Description,
                    item.Price.ToString("N0"), item.Category, item.IsAvailable ? "Available" : "Unavailable");
                dgvMenu.Rows[rowIndex].Cells[5].Style.BackColor = item.IsAvailable
                    ? Color.LightGreen
                    : Color.LightCoral;
            }
        }

        private void btnChooseImage_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*",
                Title = "Choose Food Image"
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                using var selectedImage = Image.FromFile(dialog.FileName);
                picFood.Image = new Bitmap(selectedImage);
            }
        }

        private bool TryReadFoodDetails(out string foodName, out string description, out decimal price, out string category, out bool isAvailable)
        {
            foodName = txtFoodName.Text.Trim();
            description = txtDescription.Text.Trim();
            category = cmbCategory.Text.Trim();
            price = 0m;
            isAvailable = rdoAvailable.Checked;

            if (string.IsNullOrWhiteSpace(foodName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Enter the food name and description.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Enter a valid price.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Select a category.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            return true;
        }

        private async void btnAddFood_Click(object? sender, EventArgs e)
        {
            if (!TryReadFoodDetails(out var foodName, out var description, out var price, out var category, out var isAvailable))
            {
                return;
            }

            try
            {
                await controller.EnsureRestaurantAsync();
                await controller.AddAsync(DefaultRestaurantId, foodName, description, price, category, isAvailable);
                await LoadMenuAsync();
                ClearFoodDetails();
                MessageBox.Show("Food added successfully.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not add the food item.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEditFood_Click(object? sender, EventArgs e)
        {
            var item = GetSelectedItem();
            if (item == null || !TryReadFoodDetails(out var foodName, out var description, out var price, out var category, out var isAvailable))
            {
                return;
            }

            item.ItemName = foodName;
            item.Description = description;
            item.Price = price;
            item.Category = category;
            item.IsAvailable = isAvailable;
            try
            {
                await controller.UpdateAsync(item);
                await LoadMenuAsync();
                MessageBox.Show("Food updated successfully.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not update the food item.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRemoveFood_Click(object? sender, EventArgs e)
        {
            var item = GetSelectedItem();
            if (item == null)
            {
                MessageBox.Show("Select a food item to remove.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Remove {item.ItemName} from the menu?", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    await controller.DeleteAsync(item.MenuItemId);
                    await LoadMenuAsync();
                    ClearFoodDetails();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Could not remove the food item.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnChangeStatus_Click(object? sender, EventArgs e)
        {
            var item = GetSelectedItem();
            if (item == null)
            {
                MessageBox.Show("Select a food item to change its status.", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.IsAvailable = !item.IsAvailable;
            try
            {
                await controller.UpdateAsync(item);
                rdoAvailable.Checked = item.IsAvailable;
                rdoUnavailable.Checked = !item.IsAvailable;
                await LoadMenuAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not change the food status.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            RefreshMenuGrid();
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            RefreshMenuGrid();
        }

        private void dgvMenu_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var id = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells[0].Value);
            var item = menuItems.FirstOrDefault(menuItem => menuItem.MenuItemId == id);
            if (item == null)
            {
                return;
            }

            txtFoodName.Text = item.ItemName;
            txtDescription.Text = item.Description;
            txtPrice.Text = item.Price.ToString("N0");
            cmbCategory.Text = item.Category;
            rdoAvailable.Checked = item.IsAvailable;
            rdoUnavailable.Checked = !item.IsAvailable;
        }

        private MenuItemModel? GetSelectedItem()
        {
            if (dgvMenu.CurrentRow == null)
            {
                return null;
            }

            var id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value);
            return menuItems.FirstOrDefault(item => item.MenuItemId == id);
        }

        private void ClearFoodDetails()
        {
            txtFoodName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            rdoAvailable.Checked = true;
            rdoUnavailable.Checked = false;
        }

        private void btnBackHome_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RestaurantMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
