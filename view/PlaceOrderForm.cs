using foododering.Controller;

namespace foododering
{
    public partial class PlaceOrderForm : Form
    {
        private readonly int customerId;
        private readonly IList<string> sharedCartItems;
        private readonly decimal totalAmount;
        private readonly AdministratorController controller = new();
        private readonly CartController cartController = new();

        public PlaceOrderForm() : this(0, "Customer", 0m, [])
        {
        }

        public PlaceOrderForm(string customerName, decimal totalAmount, IList<string> cartItems)
            : this(0, customerName, totalAmount, cartItems)
        {
        }

        public PlaceOrderForm(int customerId, string customerName, decimal totalAmount, IList<string> cartItems)
        {
            InitializeComponent();
            this.customerId = customerId;
            sharedCartItems = cartItems;
            txtCustomerName.Text = customerName;
            this.totalAmount = totalAmount;
            lblTotalAmount.Text = totalAmount.ToString("N0") + " RWF";
        }

        private void btnBackToCart_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnConfirmOrder_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter a phone number.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text))
            {
                MessageBox.Show("Please enter a delivery address.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeliveryAddress.Focus();
                return;
            }

            if (cmbPaymentMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentMethod.Focus();
                return;
            }

            if (customerId <= 0)
            {
                MessageBox.Show("Please log in with a customer account before placing an order.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var orderNumber = await controller.CreateOrderAsync(
                    customerId,
                    1,
                    txtDeliveryAddress.Text.Trim(),
                    totalAmount,
                    cmbPaymentMethod.SelectedItem?.ToString() ?? "Pending");

                await cartController.ClearAsync(customerId);
                sharedCartItems.Clear();
                using var trackingForm = new OrderTrackingForm(orderNumber, totalAmount, customerId);
                trackingForm.ShowDialog(this);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not place the order.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
