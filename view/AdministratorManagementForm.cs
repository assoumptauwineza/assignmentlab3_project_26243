using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class AdministratorManagementForm : Form
    {
        private readonly AdministratorController controller = new();
        private IReadOnlyList<UserAccountModel> accounts = [];
        private IReadOnlyList<OrderModel> orders = [];

        public AdministratorManagementForm()
        {
            InitializeComponent();
            Shown += AdministratorManagementForm_Shown;
        }

        private async void AdministratorManagementForm_Shown(object? sender, EventArgs e)
        {
            await LoadDatabaseDataAsync();
        }

        private async Task LoadDatabaseDataAsync(string searchText = "")
        {
            try
            {
                accounts = await controller.GetUsersAsync();
                orders = await controller.SearchOrdersAsync(searchText);
                RefreshAccountGrid();
                RefreshOrderGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    $"Could not load information from foodorderingdb.\n\n{exception.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshAccountGrid()
        {
            dgvAccounts.Rows.Clear();
            foreach (var account in accounts)
            {
                var row = dgvAccounts.Rows.Add(
                    account.UserId,
                    account.Username,
                    "View");
            }

            if (accounts.Count > 0)
            {
                SelectAccount(accounts[0]);
            }
            else
            {
                ClearAccountDetails();
            }
        }

        private void RefreshOrderGrid()
        {
            dgvOrders.Rows.Clear();
            foreach (var order in orders)
            {
                var row = dgvOrders.Rows.Add(
                    order.OrderNumber,
                    order.CustomerId,
                    order.RestaurantId,
                    order.OrderDate.ToString("dd/MM/yyyy hh:mm tt"),
                    order.TotalAmount.ToString("0.00"),
                    order.OrderStatus);
            }
        }

        private void dgvAccounts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < accounts.Count)
            {
                SelectAccount(accounts[e.RowIndex]);
            }
        }

        private void SelectAccount(UserAccountModel account)
        {
            txtSelectedUser.Text = account.Username;

            dgvAccounts.ClearSelection();
            var index = accounts.ToList().IndexOf(account);
            if (index >= 0 && index < dgvAccounts.Rows.Count)
            {
                dgvAccounts.Rows[index].Selected = true;
                dgvAccounts.CurrentCell = dgvAccounts.Rows[index].Cells[0];
            }
        }

        private void ClearAccountDetails()
        {
            txtSelectedUser.Clear();
        }

        private UserAccountModel? GetSelectedAccount()
        {
            var index = dgvAccounts.CurrentRow?.Index ?? -1;
            return index >= 0 && index < accounts.Count ? accounts[index] : null;
        }

        private async void btnDeleteUser_Click(object? sender, EventArgs e)
        {
            var account = GetSelectedAccount();
            if (account == null)
            {
                MessageBox.Show("Select a user account first.", "Administrator Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (MessageBox.Show($"Delete user '{account.Username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                await controller.DeleteUserAsync(account.UserId);
                await LoadDatabaseDataAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not delete the user.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReviewAccount_Click(object? sender, EventArgs e)
        {
            var account = GetSelectedAccount();
            if (account == null)
            {
                MessageBox.Show("Select a user account first.", "Administrator Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"User ID: {account.UserId}\nUsername: {account.Username}\nName: {account.FullName}\nType: {account.UserType}\nEmail: {account.Email}\nStatus: {account.AccountStatus}",
                "Account Review",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private async void btnSearchOrder_Click(object? sender, EventArgs e)
        {
            await LoadDatabaseDataAsync(txtSearchOrder.Text.Trim());
        }

        private async void btnRefreshOrders_Click(object? sender, EventArgs e)
        {
            txtSearchOrder.Clear();
            await LoadDatabaseDataAsync();
        }

        private async void btnRefreshUsers_Click(object? sender, EventArgs e)
        {
            await LoadDatabaseDataAsync(txtSearchOrder.Text.Trim());
        }

        private void btnBackHome_Click(object? sender, EventArgs e)
        {
            using var homePage = new CustomerHomePage("Administrator");
            Hide();
            homePage.ShowDialog(this);
            Close();
        }

    }
}
