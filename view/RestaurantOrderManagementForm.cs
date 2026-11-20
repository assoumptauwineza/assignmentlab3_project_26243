using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class RestaurantOrderManagementForm : Form
    {
        private readonly List<OrderRecord> orders = [];
        private readonly AdministratorController controller = new();
        private readonly string[] statuses = ["Pending", "Accepted", "Preparing", "Ready for Pickup", "Out for Delivery", "Delivered", "Cancelled"];

        public RestaurantOrderManagementForm()
        {
            InitializeComponent();
            Shown += async (_, _) => await LoadOrdersAsync();
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                orders.Clear();
                var databaseOrders = await controller.SearchOrdersAsync();
                orders.AddRange(databaseOrders.Select(order => new OrderRecord(
                    order.OrderId,
                    order.OrderNumber,
                    order.CustomerName,
                    order.TotalAmount,
                    order.OrderDate.ToString("hh:mm tt"),
                    order.OrderStatus)));
                RefreshOrders();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load orders from the database.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSampleOrders()
        {
        }

        private void RefreshOrders()
        {
            dgvOrders.Rows.Clear();
            foreach (var order in orders)
            {
                var rowIndex = dgvOrders.Rows.Add(order.OrderId, order.CustomerName,
                    $"{order.TotalAmount:N0} RWF", order.OrderTime, order.Status, "Accept", "Reject");
                dgvOrders.Rows[rowIndex].Cells[4].Style.BackColor = GetStatusColor(order.Status);
                dgvOrders.Rows[rowIndex].Cells[4].Style.ForeColor = Color.Black;
            }

            if (orders.Count > 0 && dgvOrders.CurrentRow == null)
            {
                dgvOrders.Rows[0].Selected = true;
                ShowOrderDetails(orders[0]);
            }
        }

        private void dgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order != null)
            {
                ShowOrderDetails(order);
            }
        }

        private async void dgvOrders_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 5)
            {
                return;
            }

            var order = orders[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                await UpdateOrderStatusAsync(order, "Accepted");
            }
            else if (e.ColumnIndex == 6)
            {
                await UpdateOrderStatusAsync(order, "Cancelled");
            }
        }

        private OrderRecord? GetSelectedOrder()
        {
            if (dgvOrders.CurrentRow == null || dgvOrders.CurrentRow.Index >= orders.Count)
            {
                return null;
            }

            return orders[dgvOrders.CurrentRow.Index];
        }

        private void ShowOrderDetails(OrderRecord order)
        {
            txtOrderId.Text = order.OrderId;
            txtCustomerName.Text = order.CustomerName;
            txtTotalAmount.Text = $"{order.TotalAmount:N0} RWF";
            txtOrderTime.Text = order.OrderTime;
            cmbDetailStatus.SelectedItem = order.Status;
            dgvItems.Rows.Clear();

            foreach (var item in order.Items)
            {
                dgvItems.Rows.Add(item.Name, item.Quantity, item.Price.ToString("N0"));
            }
        }

        private async void btnUpdateDetailStatus_Click(object? sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order == null || cmbDetailStatus.SelectedItem is not string status)
            {
                return;
            }

            await UpdateOrderStatusAsync(order, status);
        }

        private async void btnMarkReady_Click(object? sender, EventArgs e)
        {
            var order = GetSelectedOrder();
            if (order != null)
            {
                var selectedStatus = cmbActionStatus.SelectedItem as string;
                await UpdateOrderStatusAsync(order, string.IsNullOrWhiteSpace(selectedStatus) ? "Ready for Pickup" : selectedStatus);
            }
        }

        private async Task UpdateOrderStatusAsync(OrderRecord order, string status)
        {
            try
            {
                await controller.SetOrderStatusAsync(order.DatabaseId, status);
                order.Status = status;
                RefreshOrders();
                SelectOrder(order);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not update the order.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectOrder(OrderRecord order)
        {
            var rowIndex = orders.IndexOf(order);
            if (rowIndex >= 0 && rowIndex < dgvOrders.Rows.Count)
            {
                dgvOrders.ClearSelection();
                dgvOrders.Rows[rowIndex].Selected = true;
                dgvOrders.CurrentCell = dgvOrders.Rows[rowIndex].Cells[0];
                ShowOrderDetails(order);
            }
        }

        private void btnBackHome_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private static Color GetStatusColor(string status)
        {
            return status switch
            {
                "Pending" => Color.Khaki,
                "Accepted" => Color.LightGreen,
                "Preparing" => Color.LightBlue,
                "Ready for Pickup" => Color.LightGreen,
                "Out for Delivery" => Color.LightGreen,
                "Delivered" => Color.LightGreen,
                "Cancelled" => Color.LightCoral,
                _ => Color.White
            };
        }

        private sealed class OrderRecord
        {
            public OrderRecord(int databaseId, string orderId, string customerName, decimal totalAmount, string orderTime, string status)
            {
                DatabaseId = databaseId;
                OrderId = orderId;
                CustomerName = customerName;
                TotalAmount = totalAmount;
                OrderTime = orderTime;
                Status = status;
                Items = [];
            }

            public int DatabaseId { get; }
            public string OrderId { get; }
            public string CustomerName { get; }
            public decimal TotalAmount { get; }
            public string OrderTime { get; }
            public string Status { get; set; }
            public List<(string Name, int Quantity, decimal Price)> Items { get; }
        }

        private void lblHeaderTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
