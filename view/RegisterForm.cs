namespace foododering
{
    public partial class RegisterForm : Form
    {
        private readonly foododering.Controller.AdministratorController controller = new();
        public string RegisteredUsername => txtusername.Text.Trim();
        public string RegisteredPassword => txtpassword.Text;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnregister_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegisteredUsername))
            {
                MessageBox.Show("Please enter a username.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(RegisteredPassword))
            {
                MessageBox.Show("Please enter a password.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }

            if (RegisteredPassword.Length < 6)
            {
                MessageBox.Show("The password must contain at least 6 characters.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.SelectAll();
                txtpassword.Focus();
                return;
            }

            if (RegisteredPassword != txtconfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtconfirmPassword.SelectAll();
                txtconfirmPassword.Focus();
                return;
            }

            if (RegisteredUsername.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("That username is reserved. Please choose another one.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.SelectAll();
                txtusername.Focus();
                return;
            }

            try
            {
                await controller.RegisterAsync(RegisteredUsername, RegisteredPassword);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlConnector.MySqlException exception) when (exception.Number == 1062)
            {
                MessageBox.Show("That username or email already exists.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Registration failed.\n\n{exception.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
