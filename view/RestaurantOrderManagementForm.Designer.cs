namespace foododering
{
    partial class RestaurantOrderManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            groupOrders = new GroupBox();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colOrderTime = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAccept = new DataGridViewButtonColumn();
            colReject = new DataGridViewButtonColumn();
            groupDetails = new GroupBox();
            btnUpdateDetailStatus = new Button();
            cmbDetailStatus = new ComboBox();
            lblDetailStatus = new Label();
            dgvItems = new DataGridView();
            colItemName = new DataGridViewTextBoxColumn();
            colItemQuantity = new DataGridViewTextBoxColumn();
            colItemPrice = new DataGridViewTextBoxColumn();
            lblItemsCaption = new Label();
            txtOrderTime = new TextBox();
            lblTimeCaption = new Label();
            txtTotalAmount = new TextBox();
            lblTotalCaption = new Label();
            txtCustomerName = new TextBox();
            lblCustomerCaption = new Label();
            txtOrderId = new TextBox();
            lblOrderIdCaption = new Label();
            groupActions = new GroupBox();
            btnMarkReady = new Button();
            cmbActionStatus = new ComboBox();
            lblActionStatus = new Label();
            btnBackHome = new Button();
            panelHeader.SuspendLayout();
            groupOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 52, 91);
            panelHeader.Controls.Add(lblHeaderSubtitle);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblHeaderSubtitle.ForeColor = Color.White;
            lblHeaderSubtitle.Location = new Point(35, 57);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(166, 19);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Manage orders efficiently";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(32, 15);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(455, 41);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Restaurant Order Management";
            lblHeaderTitle.Click += lblHeaderTitle_Click;
            // 
            // groupOrders
            // 
            groupOrders.Controls.Add(dgvOrders);
            groupOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupOrders.Location = new Point(12, 105);
            groupOrders.Name = "groupOrders";
            groupOrders.Size = new Size(560, 360);
            groupOrders.TabIndex = 1;
            groupOrders.TabStop = false;
            groupOrders.Text = "New Orders";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colCustomerName, colTotalAmount, colOrderTime, colStatus, colAccept, colReject });
            dgvOrders.Location = new Point(7, 30);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(546, 318);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // colOrderId
            // 
            colOrderId.FillWeight = 65F;
            colOrderId.HeaderText = "Order ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.FillWeight = 110F;
            colCustomerName.HeaderText = "Customer";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.FillWeight = 90F;
            colTotalAmount.HeaderText = "Total";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colOrderTime
            // 
            colOrderTime.FillWeight = 75F;
            colOrderTime.HeaderText = "Time";
            colOrderTime.Name = "colOrderTime";
            colOrderTime.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colAccept
            // 
            colAccept.FillWeight = 70F;
            colAccept.HeaderText = "";
            colAccept.Name = "colAccept";
            colAccept.ReadOnly = true;
            colAccept.Text = "Accept";
            colAccept.UseColumnTextForButtonValue = true;
            // 
            // colReject
            // 
            colReject.FillWeight = 70F;
            colReject.HeaderText = "";
            colReject.Name = "colReject";
            colReject.ReadOnly = true;
            colReject.Text = "Reject";
            colReject.UseColumnTextForButtonValue = true;
            // 
            // groupDetails
            // 
            groupDetails.Controls.Add(btnUpdateDetailStatus);
            groupDetails.Controls.Add(cmbDetailStatus);
            groupDetails.Controls.Add(lblDetailStatus);
            groupDetails.Controls.Add(dgvItems);
            groupDetails.Controls.Add(lblItemsCaption);
            groupDetails.Controls.Add(txtOrderTime);
            groupDetails.Controls.Add(lblTimeCaption);
            groupDetails.Controls.Add(txtTotalAmount);
            groupDetails.Controls.Add(lblTotalCaption);
            groupDetails.Controls.Add(txtCustomerName);
            groupDetails.Controls.Add(lblCustomerCaption);
            groupDetails.Controls.Add(txtOrderId);
            groupDetails.Controls.Add(lblOrderIdCaption);
            groupDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupDetails.Location = new Point(586, 105);
            groupDetails.Name = "groupDetails";
            groupDetails.Size = new Size(302, 360);
            groupDetails.TabIndex = 2;
            groupDetails.TabStop = false;
            groupDetails.Text = "Order Details";
            // 
            // btnUpdateDetailStatus
            // 
            btnUpdateDetailStatus.BackColor = Color.FromArgb(17, 52, 91);
            btnUpdateDetailStatus.ForeColor = Color.White;
            btnUpdateDetailStatus.Location = new Point(207, 265);
            btnUpdateDetailStatus.Name = "btnUpdateDetailStatus";
            btnUpdateDetailStatus.Size = new Size(81, 31);
            btnUpdateDetailStatus.TabIndex = 12;
            btnUpdateDetailStatus.Text = "Update";
            btnUpdateDetailStatus.UseVisualStyleBackColor = false;
            btnUpdateDetailStatus.Click += btnUpdateDetailStatus_Click;
            // 
            // cmbDetailStatus
            // 
            cmbDetailStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDetailStatus.FormattingEnabled = true;
            cmbDetailStatus.Items.AddRange(new object[] { "Pending", "Accepted", "Preparing", "Ready for Pickup", "Out for Delivery", "Delivered", "Cancelled" });
            cmbDetailStatus.Location = new Point(70, 267);
            cmbDetailStatus.Name = "cmbDetailStatus";
            cmbDetailStatus.Size = new Size(130, 25);
            cmbDetailStatus.TabIndex = 11;
            // 
            // lblDetailStatus
            // 
            lblDetailStatus.AutoSize = true;
            lblDetailStatus.Location = new Point(10, 270);
            lblDetailStatus.Name = "lblDetailStatus";
            lblDetailStatus.Size = new Size(53, 19);
            lblDetailStatus.TabIndex = 10;
            lblDetailStatus.Text = "Status:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemName, colItemQuantity, colItemPrice });
            dgvItems.Location = new Point(10, 180);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(278, 75);
            dgvItems.TabIndex = 9;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "Food Name";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colItemQuantity
            // 
            colItemQuantity.HeaderText = "Qty";
            colItemQuantity.Name = "colItemQuantity";
            colItemQuantity.ReadOnly = true;
            // 
            // colItemPrice
            // 
            colItemPrice.HeaderText = "Price";
            colItemPrice.Name = "colItemPrice";
            colItemPrice.ReadOnly = true;
            // 
            // lblItemsCaption
            // 
            lblItemsCaption.AutoSize = true;
            lblItemsCaption.Location = new Point(10, 157);
            lblItemsCaption.Name = "lblItemsCaption";
            lblItemsCaption.Size = new Size(110, 19);
            lblItemsCaption.TabIndex = 8;
            lblItemsCaption.Text = "Items in Order:";
            // 
            // txtOrderTime
            // 
            txtOrderTime.Location = new Point(104, 122);
            txtOrderTime.Name = "txtOrderTime";
            txtOrderTime.ReadOnly = true;
            txtOrderTime.Size = new Size(184, 25);
            txtOrderTime.TabIndex = 7;
            // 
            // lblTimeCaption
            // 
            lblTimeCaption.AutoSize = true;
            lblTimeCaption.Location = new Point(10, 125);
            lblTimeCaption.Name = "lblTimeCaption";
            lblTimeCaption.Size = new Size(46, 19);
            lblTimeCaption.TabIndex = 6;
            lblTimeCaption.Text = "Time:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(104, 91);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(184, 25);
            txtTotalAmount.TabIndex = 5;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Location = new Point(10, 94);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(46, 19);
            lblTotalCaption.TabIndex = 4;
            lblTotalCaption.Text = "Total:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(104, 60);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(184, 25);
            txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerCaption
            // 
            lblCustomerCaption.AutoSize = true;
            lblCustomerCaption.Location = new Point(10, 63);
            lblCustomerCaption.Name = "lblCustomerCaption";
            lblCustomerCaption.Size = new Size(78, 19);
            lblCustomerCaption.TabIndex = 2;
            lblCustomerCaption.Text = "Customer:";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(104, 29);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(184, 25);
            txtOrderId.TabIndex = 1;
            // 
            // lblOrderIdCaption
            // 
            lblOrderIdCaption.AutoSize = true;
            lblOrderIdCaption.Location = new Point(10, 32);
            lblOrderIdCaption.Name = "lblOrderIdCaption";
            lblOrderIdCaption.Size = new Size(71, 19);
            lblOrderIdCaption.TabIndex = 0;
            lblOrderIdCaption.Text = "Order ID:";
            // 
            // groupActions
            // 
            groupActions.Controls.Add(btnMarkReady);
            groupActions.Controls.Add(cmbActionStatus);
            groupActions.Controls.Add(lblActionStatus);
            groupActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupActions.Location = new Point(12, 480);
            groupActions.Name = "groupActions";
            groupActions.Size = new Size(700, 75);
            groupActions.TabIndex = 3;
            groupActions.TabStop = false;
            groupActions.Text = "Order Actions";
            // 
            // btnMarkReady
            // 
            btnMarkReady.BackColor = Color.FromArgb(17, 52, 91);
            btnMarkReady.ForeColor = Color.White;
            btnMarkReady.Location = new Point(370, 23);
            btnMarkReady.Name = "btnMarkReady";
            btnMarkReady.Size = new Size(300, 39);
            btnMarkReady.TabIndex = 2;
            btnMarkReady.Text = "Mark as Ready";
            btnMarkReady.UseVisualStyleBackColor = false;
            btnMarkReady.Click += btnMarkReady_Click;
            // 
            // cmbActionStatus
            // 
            cmbActionStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActionStatus.FormattingEnabled = true;
            cmbActionStatus.Items.AddRange(new object[] { "Pending", "Accepted", "Preparing", "Ready for Pickup", "Out for Delivery", "Delivered", "Cancelled" });
            cmbActionStatus.Location = new Point(125, 29);
            cmbActionStatus.Name = "cmbActionStatus";
            cmbActionStatus.Size = new Size(190, 25);
            cmbActionStatus.TabIndex = 1;
            // 
            // lblActionStatus
            // 
            lblActionStatus.AutoSize = true;
            lblActionStatus.Location = new Point(15, 33);
            lblActionStatus.Name = "lblActionStatus";
            lblActionStatus.Size = new Size(106, 19);
            lblActionStatus.TabIndex = 0;
            lblActionStatus.Text = "Update Status:";
            // 
            // btnBackHome
            // 
            btnBackHome.BackColor = Color.FromArgb(17, 52, 91);
            btnBackHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBackHome.ForeColor = Color.White;
            btnBackHome.Location = new Point(725, 493);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(163, 48);
            btnBackHome.TabIndex = 4;
            btnBackHome.Text = "Back to Home";
            btnBackHome.UseVisualStyleBackColor = false;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // RestaurantOrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 580);
            Controls.Add(btnBackHome);
            Controls.Add(groupActions);
            Controls.Add(groupDetails);
            Controls.Add(groupOrders);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RestaurantOrderManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restaurant Order Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupDetails.ResumeLayout(false);
            groupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupActions.ResumeLayout(false);
            groupActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;
        private GroupBox groupOrders;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colOrderTime;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAccept;
        private DataGridViewButtonColumn colReject;
        private GroupBox groupDetails;
        private Label lblOrderIdCaption;
        private TextBox txtOrderId;
        private Label lblCustomerCaption;
        private TextBox txtCustomerName;
        private Label lblTotalCaption;
        private TextBox txtTotalAmount;
        private Label lblTimeCaption;
        private TextBox txtOrderTime;
        private Label lblItemsCaption;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colItemQuantity;
        private DataGridViewTextBoxColumn colItemPrice;
        private Label lblDetailStatus;
        private ComboBox cmbDetailStatus;
        private Button btnUpdateDetailStatus;
        private GroupBox groupActions;
        private Label lblActionStatus;
        private ComboBox cmbActionStatus;
        private Button btnMarkReady;
        private Button btnBackHome;
    }
}
