using foododering.DAO;

namespace foododering
{
    public partial class OrderTrackingForm : Form
    {
        private readonly string currentOrderId;
        private readonly decimal currentOrderTotal;
        private readonly int customerId;
        private readonly OrderDao orderDao = new();
        private readonly List<OrderHistoryItem> orderHistory = [];

        private static readonly string[] OrderStatuses =
        [
            "Pending",
            "Accepted",
            "Preparing",
            "Ready for Pickup",
            "Out for Delivery",
            "Delivered",
            "Cancelled"
        ];

        public OrderTrackingForm() : this("#12345", 11000m, 0)
        {
        }

        public OrderTrackingForm(string orderId, decimal totalAmount)
            : this(orderId, totalAmount, 0)
        {
        }

        public OrderTrackingForm(string orderId, decimal totalAmount, int customerId)
        {
            InitializeComponent();
            currentOrderId = orderId;
            currentOrderTotal = totalAmount;
            this.customerId = customerId;
            txtOrderId.Text = orderId;
            Shown += async (_, _) => await LoadOrderHistoryAsync();
        }

        private async Task LoadOrderHistoryAsync()
        {
            orderHistory.Clear();
            var orders = customerId > 0
                ? await orderDao.GetForCustomerAsync(customerId)
                : [];

            foreach (var order in orders)
            {
                orderHistory.Add(new OrderHistoryItem(
                    order.OrderNumber,
                    order.OrderDate.ToString("dd/MM/yyyy"),
                    order.TotalAmount,
                    order.OrderStatus,
                    "Database order"));
            }

            if (orderHistory.Count == 0 && customerId <= 0)
            {
                orderHistory.Add(new OrderHistoryItem(currentOrderId, DateTime.Today.ToString("dd/MM/yyyy"), currentOrderTotal, "Pending", "Current order"));
            }

            dgvOrderHistory.Rows.Clear();
            foreach (var order in orderHistory)
            {
                dgvOrderHistory.Rows.Add(order.OrderId, order.Date, $"{order.Total:N0} RWF", order.Status);
            }

            ShowCurrentOrderStatus();
        }

        private void ShowCurrentOrderStatus()
        {
            var currentOrder = orderHistory.FirstOrDefault(order => order.OrderId.Equals(currentOrderId, StringComparison.OrdinalIgnoreCase));
            var status = currentOrder?.Status ?? "Pending";
            lblOrderStatus.Text = status;
            lblStatusMessage.Text = GetStatusMessage(status);
            lblOrderStatus.BackColor = GetStatusColor(status);
            lblOrderStatus.ForeColor = Color.White;

            lstStatusHistory.Items.Clear();
            lstStatusHistory.Items.Add("Order status changes");
            foreach (var orderStatus in OrderStatuses)
            {
                lstStatusHistory.Items.Add(orderStatus == status ? $"✓ {orderStatus}" : $"  {orderStatus}");
            }
        }

        private void btnTrack_Click(object? sender, EventArgs e)
        {
            var enteredOrderId = txtOrderId.Text.Trim();
            var order = orderHistory.FirstOrDefault(item => item.OrderId.Equals(enteredOrderId, StringComparison.OrdinalIgnoreCase));

            if (order == null)
            {
                lblOrderStatus.Text = "Not Found";
                lblOrderStatus.BackColor = Color.Firebrick;
                lblStatusMessage.Text = "No order was found with that ID.";
                lstStatusHistory.Items.Clear();
                lstStatusHistory.Items.Add("Enter a valid order ID from the history list.");
                return;
            }

            lblOrderStatus.Text = order.Status;
            lblOrderStatus.BackColor = GetStatusColor(order.Status);
            lblOrderStatus.ForeColor = Color.White;
            lblStatusMessage.Text = GetStatusMessage(order.Status);
            ShowStatusHistory(order.Status);
        }

        private void ShowStatusHistory(string currentStatus)
        {
            lstStatusHistory.Items.Clear();
            lstStatusHistory.Items.Add("Order status changes");

            var currentIndex = Array.IndexOf(OrderStatuses, currentStatus);
            if (currentIndex < 0)
            {
                lstStatusHistory.Items.Add($"✓ {currentStatus}");
                return;
            }

            for (var index = 0; index <= currentIndex; index++)
            {
                lstStatusHistory.Items.Add($"✓ {OrderStatuses[index]}");
            }
        }

        private void btnViewDetails_Click(object? sender, EventArgs e)
        {
            if (dgvOrderHistory.CurrentRow == null)
            {
                MessageBox.Show("Select an order to view its details.", "Order History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var orderId = dgvOrderHistory.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            var order = orderHistory.FirstOrDefault(item => item.OrderId == orderId);
            if (order == null)
            {
                return;
            }

            MessageBox.Show($"Order ID: {order.OrderId}{Environment.NewLine}Date: {order.Date}{Environment.NewLine}Total: {order.Total:N0} RWF{Environment.NewLine}Status: {order.Status}{Environment.NewLine}Details: {order.Details}",
                "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvOrderHistory_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnViewDetails_Click(sender, EventArgs.Empty);
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
                "Delivered" or "Completed" => Color.SeaGreen,
                "Cancelled" => Color.Firebrick,
                "Pending" => Color.DarkGoldenrod,
                _ => Color.FromArgb(25, 180, 45)
            };
        }

        private static string GetStatusMessage(string status)
        {
            return status switch
            {
                "Pending" => "Your order is waiting for confirmation.",
                "Accepted" => "The restaurant accepted your order.",
                "Preparing" => "Your food is being prepared.",
                "Ready for Pickup" => "Your order is ready for pickup.",
                "Out for Delivery" => "Your order will arrive soon!",
                "Delivered" or "Completed" => "Your order was delivered successfully.",
                "Cancelled" => "This order was cancelled.",
                _ => "Order status updated."
            };
        }

        private sealed record OrderHistoryItem(string OrderId, string Date, decimal Total, string Status, string Details);
    }
}
