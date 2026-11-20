namespace foododering
{
    partial class AdministratorManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            groupAccounts = new GroupBox();
            dgvAccounts = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colAccountAction = new DataGridViewButtonColumn();
            lblSelectedUser = new Label();
            txtSelectedUser = new TextBox();
            btnDeleteUser = new Button();
            btnRefreshUsers = new Button();
            groupOrders = new GroupBox();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colCustomerId = new DataGridViewTextBoxColumn();
            colRestaurantId = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colOrderStatus = new DataGridViewTextBoxColumn();
            lblSearchOrder = new Label();
            txtSearchOrder = new TextBox();
            btnSearchOrder = new Button();
            btnRefreshOrders = new Button();
            btnBackHome = new Button();
            panelHeader.SuspendLayout();
            groupAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            groupOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Size = new Size(1150, 82);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitle.Location = new Point(32, 19);
            lblTitle.Text = "Administrator Management";
            // 
            // groupAccounts
            // 
            groupAccounts.Controls.Add(dgvAccounts);
            groupAccounts.Controls.Add(lblSelectedUser);
            groupAccounts.Controls.Add(txtSelectedUser);
            groupAccounts.Controls.Add(btnDeleteUser);
            groupAccounts.Controls.Add(btnRefreshUsers);
            groupAccounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupAccounts.Location = new Point(22, 105);
            groupAccounts.Size = new Size(1106, 290);
            groupAccounts.Text = "1. User Account Management";
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.ColumnHeadersHeight = 46;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAccounts.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colAccountAction });
            dgvAccounts.Location = new Point(19, 50);
            dgvAccounts.MultiSelect = false;
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowHeadersVisible = false;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(1068, 150);
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "User ID";
            colUserId.Name = "colUserId";
            colUserId.FillWeight = 35F;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "Username";
            colUsername.Name = "colUsername";
            colUsername.FillWeight = 55F;
            // 
            // colAccountAction
            // 
            colAccountAction.HeaderText = "Action";
            colAccountAction.Name = "colAccountAction";
            colAccountAction.Text = "View";
            colAccountAction.UseColumnTextForButtonValue = true;
            colAccountAction.FillWeight = 35F;
            // 
            // lblSelectedUser
            // 
            lblSelectedUser.AutoSize = true;
            lblSelectedUser.Location = new Point(22, 225);
            lblSelectedUser.Text = "Select User:";
            // 
            // txtSelectedUser
            // 
            txtSelectedUser.Location = new Point(180, 218);
            txtSelectedUser.ReadOnly = true;
            txtSelectedUser.Size = new Size(350, 29);
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(560, 214);
            btnDeleteUser.Size = new Size(155, 40);
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnRefreshUsers
            // 
            btnRefreshUsers.Location = new Point(735, 214);
            btnRefreshUsers.Size = new Size(155, 40);
            btnRefreshUsers.Text = "Refresh";
            btnRefreshUsers.Click += btnRefreshUsers_Click;
            // 
            // groupOrders
            // 
            groupOrders.Controls.Add(dgvOrders);
            groupOrders.Controls.Add(lblSearchOrder);
            groupOrders.Controls.Add(txtSearchOrder);
            groupOrders.Controls.Add(btnSearchOrder);
            groupOrders.Controls.Add(btnRefreshOrders);
            groupOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupOrders.Location = new Point(22, 425);
            groupOrders.Size = new Size(1106, 230);
            groupOrders.Text = "2. Order Records";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeight = 46;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colCustomerId, colRestaurantId, colOrderDate, colTotalAmount, colOrderStatus });
            dgvOrders.Location = new Point(19, 50);
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.Size = new Size(1068, 115);
            // 
            // colOrderId
            // 
            colOrderId.HeaderText = "Order ID"; colOrderId.Name = "colOrderId";
            // 
            // colCustomerId
            // 
            colCustomerId.HeaderText = "Customer ID"; colCustomerId.Name = "colCustomerId";
            // 
            // colRestaurantId
            // 
            colRestaurantId.HeaderText = "Restaurant ID"; colRestaurantId.Name = "colRestaurantId";
            // 
            // colOrderDate
            // 
            colOrderDate.HeaderText = "Order Date"; colOrderDate.Name = "colOrderDate";
            // 
            // colTotalAmount
            // 
            colTotalAmount.HeaderText = "Total Amount"; colTotalAmount.Name = "colTotalAmount";
            // 
            // colOrderStatus
            // 
            colOrderStatus.HeaderText = "Order Status"; colOrderStatus.Name = "colOrderStatus";
            // 
            // lblSearchOrder
            // 
            lblSearchOrder.AutoSize = true;
            lblSearchOrder.Location = new Point(22, 185);
            lblSearchOrder.Text = "Search Order:";
            // 
            // txtSearchOrder
            // 
            txtSearchOrder.Location = new Point(195, 178);
            txtSearchOrder.Size = new Size(350, 29);
            // 
            // btnSearchOrder
            // 
            btnSearchOrder.Location = new Point(575, 174);
            btnSearchOrder.Size = new Size(155, 40);
            btnSearchOrder.Text = "Search";
            btnSearchOrder.Click += btnSearchOrder_Click;
            // 
            // btnRefreshOrders
            // 
            btnRefreshOrders.Location = new Point(750, 174);
            btnRefreshOrders.Size = new Size(155, 40);
            btnRefreshOrders.Text = "Refresh";
            btnRefreshOrders.Click += btnRefreshOrders_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(880, 680);
            btnBackHome.Size = new Size(248, 45);
            btnBackHome.Text = "Back to Home";
            btnBackHome.Click += btnBackHome_Click;
            // 
            // AdministratorManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 750);
            Controls.Add(btnBackHome);
            Controls.Add(groupOrders);
            Controls.Add(groupAccounts);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdministratorManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administrator Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupAccounts.ResumeLayout(false);
            groupAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            groupOrders.ResumeLayout(false);
            groupOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private GroupBox groupAccounts;
        private DataGridView dgvAccounts;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewButtonColumn colAccountAction;
        private Label lblSelectedUser;
        private TextBox txtSelectedUser;
        private Button btnDeleteUser;
        private Button btnRefreshUsers;
        private GroupBox groupOrders;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colCustomerId;
        private DataGridViewTextBoxColumn colRestaurantId;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colOrderStatus;
        private Label lblSearchOrder;
        private TextBox txtSearchOrder;
        private Button btnSearchOrder;
        private Button btnRefreshOrders;
        private Button btnBackHome;
    }
}
