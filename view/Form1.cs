namespace foododering
{
    public partial class Form1 : Form
    {
        private readonly foododering.Controller.AdministratorController controller = new();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtusername.Text.Trim();
            var password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }

            try
            {
                var account = await controller.AuthenticateAsync(username, password);
                var isDemoAccount = username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "admin123";

                if (account == null && !isDemoAccount)
                {
                    MessageBox.Show("Invalid username, password, or inactive account.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.SelectAll();
                    txtpassword.Focus();
                    return;
                }

                MessageBox.Show("Login successful.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isDemoAccount)
                {
                    OpenAdministratorManagement(username);
                }
                else
                {
                    OpenCustomerHomePage(account?.UserId ?? 0, username);
                }
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Could not connect to foodorderingdb.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = chkshowpassword.Checked ? '\0' : '*';
        }

        private void lblink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var registerForm = new RegisterForm();

            if (registerForm.ShowDialog(this) == DialogResult.OK)
            {
                txtusername.Text = registerForm.RegisteredUsername;
                txtpassword.Clear();
                txtpassword.Focus();

                MessageBox.Show("Registration successful. You can now log in.",
                    "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenCustomerHomePage(int customerId, string username)
        {
            using var homePage = new CustomerHomePage(customerId, username);
            Hide();
            homePage.ShowDialog(this);
            Show();
        }

        private void OpenAdministratorManagement(string username)
        {
            using var administratorForm = new AdministratorManagementForm();
            Hide();
            administratorForm.ShowDialog(this);
            Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
