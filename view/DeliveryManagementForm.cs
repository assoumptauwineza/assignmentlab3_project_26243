using foododering.Controller;
using foododering.Model;

namespace foododering
{
    public partial class DeliveryManagementForm : Form
    {
        private readonly List<DeliveryRecord> deliveries = [];
        private readonly DeliveryController deliveryController = new();
        private readonly AdministratorController administratorController = new();

        public DeliveryManagementForm()
        {
            InitializeComponent();
            Shown += async (_, _) => await LoadDatabaseDataAsync();
        }

        private async Task LoadDatabaseDataAsync()
        {
            try
            {
                deliveries.Clear();
                var databaseDeliveries = await deliveryController.GetDeliveriesAsync();
                deliveries.AddRange(databaseDeliveries.Select(delivery => new DeliveryRecord(
                    delivery.DeliveryId,
                    delivery.OrderId.ToString(),
                    delivery.CustomerName,
                    delivery.DeliveryAddress,
                    delivery.DeliveryPersonName,
                    delivery.DeliveryStatus,
                    delivery.AssignedAt?.ToString("dd/MM/yyyy hh:mm tt") ?? string.Empty)));

                await LoadReadyOrdersAsync();
                RefreshDeliveryGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not load deliveries from the database.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSampleDeliveries()
        {
        }

        private async Task LoadReadyOrdersAsync()
        {
            cmbReadyOrder.Items.Clear();
            var orders = await administratorController.SearchOrdersAsync();
            foreach (var order in orders.Where(order => order.OrderStatus is not ("Delivered" or "Cancelled")))
            {
                cmbReadyOrder.Items.Add($"{order.OrderId} - {order.OrderNumber}");
            }

            cmbDeliveryPerson.Items.Clear();
            var users = await administratorController.GetUsersAsync();
            foreach (var user in users)
            {
                cmbDeliveryPerson.Items.Add($"{user.UserId} - {user.Username}");
            }
            if (cmbReadyOrder.Items.Count > 0)
            {
                cmbReadyOrder.SelectedIndex = 0;
                cmbDeliveryPerson.SelectedIndex = 0;
            }
        }

        private void RefreshDeliveryGrid()
        {
            dgvAssignedDeliveries.Rows.Clear();
            foreach (var delivery in deliveries)
            {
                var rowIndex = dgvAssignedDeliveries.Rows.Add(delivery.OrderId, delivery.CustomerName,
                    delivery.DeliveryPerson, delivery.Status, delivery.AssignedTime, "View");
                dgvAssignedDeliveries.Rows[rowIndex].Cells[3].Style.BackColor = GetStatusColor(delivery.Status);
            }
        }

        private async void btnAssignDelivery_Click(object? sender, EventArgs e)
        {
            if (cmbReadyOrder.SelectedItem == null || cmbDeliveryPerson.SelectedItem == null)
            {
                MessageBox.Show("Select an order and delivery person.", "Delivery Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrder = cmbReadyOrder.SelectedItem.ToString() ?? string.Empty;
            if (!int.TryParse(selectedOrder.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0], out var orderId)
                || !int.TryParse((cmbDeliveryPerson.SelectedItem.ToString() ?? string.Empty).Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0], out var deliveryPersonId))
            {
                MessageBox.Show("The selected order or delivery person is invalid.", "Delivery Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await deliveryController.AssignAsync(orderId, deliveryPersonId);
                await LoadDatabaseDataAsync();
                MessageBox.Show("Delivery inserted successfully.", "Delivery Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not assign the delivery.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAssignedDeliveries_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= deliveries.Count)
            {
                return;
            }

            var delivery = deliveries[e.RowIndex];
            ShowDeliveryDetails(delivery);
        }

        private async void btnUpdateStatus_Click(object? sender, EventArgs e)
        {
            var delivery = GetSelectedDelivery();
            if (delivery == null)
            {
                MessageBox.Show("Select an assigned delivery first.", "Delivery Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var status = rdoDelivered.Checked ? "Delivered" : "PickedUp";
                await deliveryController.UpdateStatusAsync(delivery.DeliveryId, status);
                await LoadDatabaseDataAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not update the delivery.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeleteDelivery_Click(object? sender, EventArgs e)
        {
            var delivery = GetSelectedDelivery();
            if (delivery == null)
            {
                MessageBox.Show("Select an assigned delivery first.", "Delivery Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Delete delivery {delivery.OrderId}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                await deliveryController.DeleteAsync(delivery.DeliveryId);
                await LoadDatabaseDataAsync();
                ClearDeliveryDetails();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not delete the delivery.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            RefreshDeliveryGrid();
            if (deliveries.Count > 0)
            {
                ShowDeliveryDetails(deliveries[0]);
            }
        }

        private DeliveryRecord? GetSelectedDelivery()
        {
            if (dgvAssignedDeliveries.CurrentRow == null || dgvAssignedDeliveries.CurrentRow.Index >= deliveries.Count)
            {
                return null;
            }

            return deliveries[dgvAssignedDeliveries.CurrentRow.Index];
        }

        private void ShowDeliveryDetails(DeliveryRecord delivery)
        {
            txtSelectedOrderId.Text = delivery.OrderId;
            txtSelectedCustomer.Text = delivery.CustomerName;
            txtSelectedAddress.Text = delivery.Address;
            lblSelectedStatus.Text = delivery.Status == "PickedUp" ? "Picked Up" : delivery.Status;
            rdoPickedUp.Checked = delivery.Status == "PickedUp";
            rdoDelivered.Checked = delivery.Status == "Delivered";
        }

        private void ClearDeliveryDetails()
        {
            txtSelectedOrderId.Clear();
            txtSelectedCustomer.Clear();
            txtSelectedAddress.Clear();
            lblSelectedStatus.Text = "No selection";
            lblSelectedStatus.BackColor = Color.Gainsboro;
            rdoPickedUp.Checked = false;
            rdoDelivered.Checked = false;
        }

        private void SelectDelivery(DeliveryRecord delivery)
        {
            var index = deliveries.IndexOf(delivery);
            if (index >= 0 && index < dgvAssignedDeliveries.Rows.Count)
            {
                dgvAssignedDeliveries.ClearSelection();
                dgvAssignedDeliveries.Rows[index].Selected = true;
                dgvAssignedDeliveries.CurrentCell = dgvAssignedDeliveries.Rows[index].Cells[0];
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
                "PickedUp" or "Picked Up" => Color.LightGoldenrodYellow,
                "Delivered" => Color.LightGreen,
                _ => Color.Gainsboro
            };
        }

        private sealed class DeliveryRecord
        {
            public DeliveryRecord(int deliveryId, string orderId, string customerName, string address, string deliveryPerson, string status, string assignedTime)
            {
                DeliveryId = deliveryId;
                OrderId = orderId;
                CustomerName = customerName;
                Address = address;
                DeliveryPerson = deliveryPerson;
                Status = status;
                AssignedTime = assignedTime;
            }

            public string OrderId { get; }
            public int DeliveryId { get; }
            public string CustomerName { get; }
            public string Address { get; }
            public string DeliveryPerson { get; set; }
            public string Status { get; set; }
            public string AssignedTime { get; set; }
        }
    }
}
