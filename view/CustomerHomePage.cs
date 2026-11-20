namespace foododering
{
    public partial class CustomerHomePage : Form
    {
        private readonly string customerName;
        private readonly int customerId;
        private readonly List<string> cartItems = [];

        public CustomerHomePage() : this(0, "Test Customer")
        {
        }

        public CustomerHomePage(string customerName)
            : this(0, customerName)
        {
        }

        public CustomerHomePage(int customerId, string customerName)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.customerName = customerName;
            lblWelcome.Text = "Welcome!";
            lblHeaderWelcome.Text = $"Welcome to our food ordering system, {customerName}";
            lblStatus.Text = "Select an option to continue.";
        }

        private void btnHome_Click(object? sender, EventArgs e)
        {
            lblStatus.Text = "You are viewing the home page.";
        }

        private void btnRestaurants_Click(object? sender, EventArgs e)
        {
            using var menuForm = new RestaurantMenuForm();
            menuForm.ShowDialog(this);
            lblStatus.Text = "Restaurant menu closed.";
        }

        private void btnFoodMenu_Click(object? sender, EventArgs e)
        {
            using var menuForm = new CustomerFoodMenuForm(customerId, cartItems);
            menuForm.ShowDialog(this);
            lblCart.Text = $"Cart ({cartItems.Count})";
            lblStatus.Text = "Food menu closed.";
        }

        private void btnOrders_Click(object? sender, EventArgs e)
        {
            using var placeOrderForm = new PlaceOrderForm(customerId, customerName, CalculateCartTotal(), cartItems);

            if (placeOrderForm.ShowDialog(this) == DialogResult.OK)
            {
                lblCart.Text = $"Cart ({cartItems.Count})";
                lblStatus.Text = "Order confirmed successfully.";
            }
        }

        private void btnCart_Click(object? sender, EventArgs e)
        {
            using var shoppingCart = new ShoppingCartForm(customerId, cartItems, customerName);
            shoppingCart.ShowDialog(this);
            lblCart.Text = $"Cart ({cartItems.Count})";
            lblStatus.Text = "Shopping Cart closed.";
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnRestaurantOrders_Click(object? sender, EventArgs e)
        {
            using var orderManagementForm = new RestaurantOrderManagementForm();
            orderManagementForm.ShowDialog(this);
        }

        private void btnDeliveryManagement_Click(object? sender, EventArgs e)
        {
            using var deliveryManagementForm = new DeliveryManagementForm();
            deliveryManagementForm.ShowDialog(this);
        }

        private void AddToCart(string foodName, decimal price)
        {
            cartItems.Add($"{foodName} - {price:C}");
            lblCart.Text = $"Cart ({cartItems.Count})";
            lblStatus.Text = $"{foodName} was added to your cart.";
        }

        private decimal CalculateCartTotal()
        {
            var total = 0m;

            foreach (var item in cartItems)
            {
                var separatorIndex = item.LastIndexOf(" - ", StringComparison.Ordinal);
                if (separatorIndex > 0 && decimal.TryParse(
                    item[(separatorIndex + 3)..],
                    System.Globalization.NumberStyles.Currency,
                    System.Globalization.CultureInfo.CurrentCulture,
                    out var price))
                {
                    total += price;
                }
            }

            return total;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picHero_Click(object sender, EventArgs e)
        {

        }
    }
}
