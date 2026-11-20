namespace foododering
{
    partial class DeliveryManagementForm
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
            lblHeaderTitle = new Label();
            groupAssign = new GroupBox();
            btnAssignDelivery = new Button();
            cmbDeliveryPerson = new ComboBox();
            lblDeliveryPerson = new Label();
            cmbReadyOrder = new ComboBox();
            lblReadyOrder = new Label();
            groupAssigned = new GroupBox();
            dgvAssignedDeliveries = new DataGridView();
            colAssignedOrderId = new DataGridViewTextBoxColumn();
            colAssignedCustomer = new DataGridViewTextBoxColumn();
            colAssignedPerson = new DataGridViewTextBoxColumn();
            colAssignedStatus = new DataGridViewTextBoxColumn();
            colAssignedTime = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            groupDetails = new GroupBox();
            btnRefresh = new Button();
            btnUpdateStatus = new Button();
            btnDeleteDelivery = new Button();
            rdoDelivered = new RadioButton();
            rdoPickedUp = new RadioButton();
            lblSelectedStatus = new Label();
            lblSelectedStatusCaption = new Label();
            txtSelectedAddress = new TextBox();
            lblAddressCaption = new Label();
            txtSelectedCustomer = new TextBox();
            lblCustomerCaption = new Label();
            txtSelectedOrderId = new TextBox();
            lblOrderIdCaption = new Label();
            btnBackHome = new Button();
            panelHeader.SuspendLayout();
            groupAssign.SuspendLayout();
            groupAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedDeliveries).BeginInit();
            groupDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.Black;
            lblHeaderTitle.Location = new Point(28, 12);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(330, 41);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Delivery Management";
            // 
            // groupAssign
            // 
            groupAssign.Controls.Add(btnAssignDelivery);
            groupAssign.Controls.Add(cmbDeliveryPerson);
            groupAssign.Controls.Add(lblDeliveryPerson);
            groupAssign.Controls.Add(cmbReadyOrder);
            groupAssign.Controls.Add(lblReadyOrder);
            groupAssign.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupAssign.Location = new Point(15, 95);
            groupAssign.Name = "groupAssign";
            groupAssign.Size = new Size(870, 110);
            groupAssign.TabIndex = 1;
            groupAssign.TabStop = false;
            groupAssign.Text = "1. Assign Order to Delivery Person";
            // 
            // btnAssignDelivery
            // 
            btnAssignDelivery.BackColor = Color.FromArgb(70, 70, 70);
            btnAssignDelivery.ForeColor = Color.White;
            btnAssignDelivery.Location = new Point(525, 49);
            btnAssignDelivery.Name = "btnAssignDelivery";
            btnAssignDelivery.Size = new Size(190, 43);
            btnAssignDelivery.TabIndex = 4;
            btnAssignDelivery.Text = "Assign Delivery";
            btnAssignDelivery.UseVisualStyleBackColor = false;
            btnAssignDelivery.Click += btnAssignDelivery_Click;
            // 
            // cmbDeliveryPerson
            // 
            cmbDeliveryPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeliveryPerson.FormattingEnabled = true;
            cmbDeliveryPerson.Location = new Point(278, 59);
            cmbDeliveryPerson.Name = "cmbDeliveryPerson";
            cmbDeliveryPerson.Size = new Size(210, 25);
            cmbDeliveryPerson.TabIndex = 3;
            // 
            // lblDeliveryPerson
            // 
            lblDeliveryPerson.AutoSize = true;
            lblDeliveryPerson.Location = new Point(278, 35);
            lblDeliveryPerson.Name = "lblDeliveryPerson";
            lblDeliveryPerson.Size = new Size(120, 19);
            lblDeliveryPerson.TabIndex = 2;
            lblDeliveryPerson.Text = "Delivery Person:";
            // 
            // cmbReadyOrder
            // 
            cmbReadyOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReadyOrder.FormattingEnabled = true;
            cmbReadyOrder.Location = new Point(16, 59);
            cmbReadyOrder.Name = "cmbReadyOrder";
            cmbReadyOrder.Size = new Size(235, 25);
            cmbReadyOrder.TabIndex = 1;
            // 
            // lblReadyOrder
            // 
            lblReadyOrder.AutoSize = true;
            lblReadyOrder.Location = new Point(16, 35);
            lblReadyOrder.Name = "lblReadyOrder";
            lblReadyOrder.Size = new Size(100, 19);
            lblReadyOrder.TabIndex = 0;
            lblReadyOrder.Text = "Ready Order:";
            // 
            // groupAssigned
            // 
            groupAssigned.Controls.Add(dgvAssignedDeliveries);
            groupAssigned.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupAssigned.Location = new Point(15, 220);
            groupAssigned.Name = "groupAssigned";
            groupAssigned.Size = new Size(870, 175);
            groupAssigned.TabIndex = 2;
            groupAssigned.TabStop = false;
            groupAssigned.Text = "2. Assigned Deliveries";
            // 
            // dgvAssignedDeliveries
            // 
            dgvAssignedDeliveries.AllowUserToAddRows = false;
            dgvAssignedDeliveries.AllowUserToDeleteRows = false;
            dgvAssignedDeliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignedDeliveries.BackgroundColor = Color.White;
            dgvAssignedDeliveries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignedDeliveries.Columns.AddRange(new DataGridViewColumn[] { colAssignedOrderId, colAssignedCustomer, colAssignedPerson, colAssignedStatus, colAssignedTime, colView });
            dgvAssignedDeliveries.Location = new Point(7, 29);
            dgvAssignedDeliveries.MultiSelect = false;
            dgvAssignedDeliveries.Name = "dgvAssignedDeliveries";
            dgvAssignedDeliveries.ReadOnly = true;
            dgvAssignedDeliveries.RowHeadersVisible = false;
            dgvAssignedDeliveries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignedDeliveries.Size = new Size(856, 137);
            dgvAssignedDeliveries.TabIndex = 0;
            dgvAssignedDeliveries.CellClick += dgvAssignedDeliveries_CellClick;
            // 
            // colAssignedOrderId
            // 
            colAssignedOrderId.FillWeight = 75F;
            colAssignedOrderId.HeaderText = "Order ID";
            colAssignedOrderId.Name = "colAssignedOrderId";
            colAssignedOrderId.ReadOnly = true;
            // 
            // colAssignedCustomer
            // 
            colAssignedCustomer.FillWeight = 120F;
            colAssignedCustomer.HeaderText = "Customer Name";
            colAssignedCustomer.Name = "colAssignedCustomer";
            colAssignedCustomer.ReadOnly = true;
            // 
            // colAssignedPerson
            // 
            colAssignedPerson.FillWeight = 110F;
            colAssignedPerson.HeaderText = "Delivery Person";
            colAssignedPerson.Name = "colAssignedPerson";
            colAssignedPerson.ReadOnly = true;
            // 
            // colAssignedStatus
            // 
            colAssignedStatus.HeaderText = "Status";
            colAssignedStatus.Name = "colAssignedStatus";
            colAssignedStatus.ReadOnly = true;
            // 
            // colAssignedTime
            // 
            colAssignedTime.FillWeight = 120F;
            colAssignedTime.HeaderText = "Assigned Time";
            colAssignedTime.Name = "colAssignedTime";
            colAssignedTime.ReadOnly = true;
            // 
            // colView
            // 
            colView.FillWeight = 70F;
            colView.HeaderText = "Action";
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Text = "View";
            colView.UseColumnTextForButtonValue = true;
            // 
            // groupDetails
            // 
            groupDetails.Controls.Add(btnRefresh);
            groupDetails.Controls.Add(btnUpdateStatus);
            groupDetails.Controls.Add(btnDeleteDelivery);
            groupDetails.Controls.Add(rdoDelivered);
            groupDetails.Controls.Add(rdoPickedUp);
            groupDetails.Controls.Add(lblSelectedStatus);
            groupDetails.Controls.Add(lblSelectedStatusCaption);
            groupDetails.Controls.Add(txtSelectedAddress);
            groupDetails.Controls.Add(lblAddressCaption);
            groupDetails.Controls.Add(txtSelectedCustomer);
            groupDetails.Controls.Add(lblCustomerCaption);
            groupDetails.Controls.Add(txtSelectedOrderId);
            groupDetails.Controls.Add(lblOrderIdCaption);
            groupDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupDetails.Location = new Point(15, 410);
            groupDetails.Name = "groupDetails";
            groupDetails.Size = new Size(870, 145);
            groupDetails.TabIndex = 3;
            groupDetails.TabStop = false;
            groupDetails.Text = "3. Delivery Details and Update Status";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(720, 98);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 30);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(70, 70, 70);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(720, 58);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(135, 38);
            btnUpdateStatus.TabIndex = 10;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnDeleteDelivery
            // 
            btnDeleteDelivery.BackColor = Color.FromArgb(70, 70, 70);
            btnDeleteDelivery.ForeColor = Color.White;
            btnDeleteDelivery.Location = new Point(720, 20);
            btnDeleteDelivery.Name = "btnDeleteDelivery";
            btnDeleteDelivery.Size = new Size(135, 30);
            btnDeleteDelivery.TabIndex = 11;
            btnDeleteDelivery.Text = "Delete";
            btnDeleteDelivery.UseVisualStyleBackColor = false;
            btnDeleteDelivery.Click += btnDeleteDelivery_Click;
            // 
            // rdoDelivered
            // 
            rdoDelivered.AutoSize = true;
            rdoDelivered.Location = new Point(625, 70);
            rdoDelivered.Name = "rdoDelivered";
            rdoDelivered.Size = new Size(92, 23);
            rdoDelivered.TabIndex = 9;
            rdoDelivered.Text = "Delivered";
            rdoDelivered.UseVisualStyleBackColor = true;
            // 
            // rdoPickedUp
            // 
            rdoPickedUp.AutoSize = true;
            rdoPickedUp.Location = new Point(525, 70);
            rdoPickedUp.Name = "rdoPickedUp";
            rdoPickedUp.Size = new Size(95, 23);
            rdoPickedUp.TabIndex = 8;
            rdoPickedUp.Text = "Picked Up";
            rdoPickedUp.UseVisualStyleBackColor = true;
            // 
            // lblSelectedStatus
            // 
            lblSelectedStatus.BackColor = Color.LightGreen;
            lblSelectedStatus.Location = new Point(585, 27);
            lblSelectedStatus.Name = "lblSelectedStatus";
            lblSelectedStatus.Size = new Size(100, 27);
            lblSelectedStatus.TabIndex = 7;
            lblSelectedStatus.Text = "Assigned";
            lblSelectedStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelectedStatusCaption
            // 
            lblSelectedStatusCaption.AutoSize = true;
            lblSelectedStatusCaption.Location = new Point(525, 31);
            lblSelectedStatusCaption.Name = "lblSelectedStatusCaption";
            lblSelectedStatusCaption.Size = new Size(53, 19);
            lblSelectedStatusCaption.TabIndex = 6;
            lblSelectedStatusCaption.Text = "Status:";
            // 
            // txtSelectedAddress
            // 
            txtSelectedAddress.Location = new Point(95, 67);
            txtSelectedAddress.Name = "txtSelectedAddress";
            txtSelectedAddress.ReadOnly = true;
            txtSelectedAddress.Size = new Size(405, 25);
            txtSelectedAddress.TabIndex = 5;
            // 
            // lblAddressCaption
            // 
            lblAddressCaption.AutoSize = true;
            lblAddressCaption.Location = new Point(16, 70);
            lblAddressCaption.Name = "lblAddressCaption";
            lblAddressCaption.Size = new Size(67, 19);
            lblAddressCaption.TabIndex = 4;
            lblAddressCaption.Text = "Address:";
            // 
            // txtSelectedCustomer
            // 
            txtSelectedCustomer.Location = new Point(330, 28);
            txtSelectedCustomer.Name = "txtSelectedCustomer";
            txtSelectedCustomer.ReadOnly = true;
            txtSelectedCustomer.Size = new Size(170, 25);
            txtSelectedCustomer.TabIndex = 3;
            // 
            // lblCustomerCaption
            // 
            lblCustomerCaption.AutoSize = true;
            lblCustomerCaption.Location = new Point(250, 31);
            lblCustomerCaption.Name = "lblCustomerCaption";
            lblCustomerCaption.Size = new Size(78, 19);
            lblCustomerCaption.TabIndex = 2;
            lblCustomerCaption.Text = "Customer:";
            // 
            // txtSelectedOrderId
            // 
            txtSelectedOrderId.Location = new Point(95, 28);
            txtSelectedOrderId.Name = "txtSelectedOrderId";
            txtSelectedOrderId.ReadOnly = true;
            txtSelectedOrderId.Size = new Size(135, 25);
            txtSelectedOrderId.TabIndex = 1;
            // 
            // lblOrderIdCaption
            // 
            lblOrderIdCaption.AutoSize = true;
            lblOrderIdCaption.Location = new Point(16, 31);
            lblOrderIdCaption.Name = "lblOrderIdCaption";
            lblOrderIdCaption.Size = new Size(71, 19);
            lblOrderIdCaption.TabIndex = 0;
            lblOrderIdCaption.Text = "Order ID:";
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(690, 570);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(195, 38);
            btnBackHome.TabIndex = 4;
            btnBackHome.Text = "Back to Home";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // DeliveryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 630);
            Controls.Add(btnBackHome);
            Controls.Add(groupDetails);
            Controls.Add(groupAssigned);
            Controls.Add(groupAssign);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DeliveryManagementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delivery Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupAssign.ResumeLayout(false);
            groupAssign.PerformLayout();
            groupAssigned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssignedDeliveries).EndInit();
            groupDetails.ResumeLayout(false);
            groupDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private GroupBox groupAssign;
        private Label lblReadyOrder;
        private ComboBox cmbReadyOrder;
        private Label lblDeliveryPerson;
        private ComboBox cmbDeliveryPerson;
        private Button btnAssignDelivery;
        private GroupBox groupAssigned;
        private DataGridView dgvAssignedDeliveries;
        private DataGridViewTextBoxColumn colAssignedOrderId;
        private DataGridViewTextBoxColumn colAssignedCustomer;
        private DataGridViewTextBoxColumn colAssignedPerson;
        private DataGridViewTextBoxColumn colAssignedStatus;
        private DataGridViewTextBoxColumn colAssignedTime;
        private DataGridViewButtonColumn colView;
        private GroupBox groupDetails;
        private Label lblOrderIdCaption;
        private TextBox txtSelectedOrderId;
        private Label lblCustomerCaption;
        private TextBox txtSelectedCustomer;
        private Label lblAddressCaption;
        private TextBox txtSelectedAddress;
        private Label lblSelectedStatusCaption;
        private Label lblSelectedStatus;
        private RadioButton rdoPickedUp;
        private RadioButton rdoDelivered;
        private Button btnUpdateStatus;
        private Button btnDeleteDelivery;
        private Button btnRefresh;
        private Button btnBackHome;
    }
}
