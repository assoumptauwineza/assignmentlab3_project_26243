namespace foododering
{
    partial class OrderTrackingForm
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
            lblHeaderSystem = new Label();
            lblHeaderTitle = new Label();
            groupTrack = new GroupBox();
            panelStatus = new Panel();
            lstStatusHistory = new ListBox();
            lblStatusMessage = new Label();
            lblOrderStatus = new Label();
            lblStatusCaption = new Label();
            lblDeliveryIcon = new Label();
            lblEnterOrderId = new Label();
            txtOrderId = new TextBox();
            btnTrack = new Button();
            groupHistory = new GroupBox();
            dgvOrderHistory = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnViewDetails = new Button();
            btnBackHome = new Button();
            panelHeader.SuspendLayout();
            groupTrack.SuspendLayout();
            panelStatus.SuspendLayout();
            groupHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 52, 91);
            panelHeader.Controls.Add(lblHeaderSystem);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(850, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSystem
            // 
            lblHeaderSystem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHeaderSystem.AutoSize = true;
            lblHeaderSystem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderSystem.ForeColor = Color.White;
            lblHeaderSystem.Location = new Point(675, 53);
            lblHeaderSystem.Name = "lblHeaderSystem";
            lblHeaderSystem.Size = new Size(160, 19);
            lblHeaderSystem.TabIndex = 2;
            lblHeaderSystem.Text = "Food Ordering System";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(115, 20);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(244, 45);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Order Tracking";
            // 
            // groupTrack
            // 
            groupTrack.Controls.Add(panelStatus);
            groupTrack.Controls.Add(lblEnterOrderId);
            groupTrack.Controls.Add(txtOrderId);
            groupTrack.Controls.Add(btnTrack);
            groupTrack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupTrack.Location = new Point(15, 105);
            groupTrack.Name = "groupTrack";
            groupTrack.Size = new Size(820, 210);
            groupTrack.TabIndex = 1;
            groupTrack.TabStop = false;
            groupTrack.Text = "Track Your Order";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(231, 240, 255);
            panelStatus.BorderStyle = BorderStyle.FixedSingle;
            panelStatus.Controls.Add(lstStatusHistory);
            panelStatus.Controls.Add(lblStatusMessage);
            panelStatus.Controls.Add(lblOrderStatus);
            panelStatus.Controls.Add(lblStatusCaption);
            panelStatus.Controls.Add(lblDeliveryIcon);
            panelStatus.Location = new Point(15, 90);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(790, 105);
            panelStatus.TabIndex = 3;
            // 
            // lstStatusHistory
            // 
            lstStatusHistory.Font = new Font("Segoe UI", 8F);
            lstStatusHistory.FormattingEnabled = true;
            lstStatusHistory.Location = new Point(570, 10);
            lstStatusHistory.Name = "lstStatusHistory";
            lstStatusHistory.Size = new Size(200, 69);
            lstStatusHistory.TabIndex = 4;
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Font = new Font("Segoe UI", 10F);
            lblStatusMessage.Location = new Point(130, 80);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(173, 19);
            lblStatusMessage.TabIndex = 3;
            lblStatusMessage.Text = "Your order will arrive soon!";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.BackColor = Color.FromArgb(25, 180, 45);
            lblOrderStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrderStatus.ForeColor = Color.White;
            lblOrderStatus.Location = new Point(125, 45);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(220, 32);
            lblOrderStatus.TabIndex = 2;
            lblOrderStatus.Text = "Out for Delivery";
            lblOrderStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatusCaption.Location = new Point(125, 12);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(150, 30);
            lblStatusCaption.TabIndex = 1;
            lblStatusCaption.Text = "Order Status:";
            // 
            // lblDeliveryIcon
            // 
            lblDeliveryIcon.BackColor = Color.FromArgb(17, 52, 91);
            lblDeliveryIcon.Font = new Font("Segoe UI Emoji", 24F);
            lblDeliveryIcon.ForeColor = Color.White;
            lblDeliveryIcon.Location = new Point(20, 15);
            lblDeliveryIcon.Name = "lblDeliveryIcon";
            lblDeliveryIcon.Size = new Size(85, 75);
            lblDeliveryIcon.TabIndex = 0;
            lblDeliveryIcon.Text = "\U0001f6f5";
            lblDeliveryIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnterOrderId
            // 
            lblEnterOrderId.AutoSize = true;
            lblEnterOrderId.Location = new Point(20, 42);
            lblEnterOrderId.Name = "lblEnterOrderId";
            lblEnterOrderId.Size = new Size(109, 19);
            lblEnterOrderId.TabIndex = 0;
            lblEnterOrderId.Text = "Enter Order ID:";
            // 
            // txtOrderId
            // 
            txtOrderId.Font = new Font("Segoe UI", 11F);
            txtOrderId.Location = new Point(140, 38);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.PlaceholderText = "e.g. #12345";
            txtOrderId.Size = new Size(220, 27);
            txtOrderId.TabIndex = 1;
            // 
            // btnTrack
            // 
            btnTrack.BackColor = Color.FromArgb(17, 52, 91);
            btnTrack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTrack.ForeColor = Color.White;
            btnTrack.Location = new Point(380, 33);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(120, 36);
            btnTrack.TabIndex = 2;
            btnTrack.Text = "⌕  Track";
            btnTrack.UseVisualStyleBackColor = false;
            btnTrack.Click += btnTrack_Click;
            // 
            // groupHistory
            // 
            groupHistory.Controls.Add(dgvOrderHistory);
            groupHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupHistory.Location = new Point(15, 330);
            groupHistory.Name = "groupHistory";
            groupHistory.Size = new Size(820, 170);
            groupHistory.TabIndex = 4;
            groupHistory.TabStop = false;
            groupHistory.Text = "Your Order History";
            // 
            // dgvOrderHistory
            // 
            dgvOrderHistory.AllowUserToAddRows = false;
            dgvOrderHistory.AllowUserToDeleteRows = false;
            dgvOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderHistory.BackgroundColor = Color.White;
            dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderHistory.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colDate, colTotalAmount, colStatus });
            dgvOrderHistory.Location = new Point(8, 30);
            dgvOrderHistory.MultiSelect = false;
            dgvOrderHistory.Name = "dgvOrderHistory";
            dgvOrderHistory.ReadOnly = true;
            dgvOrderHistory.RowHeadersVisible = false;
            dgvOrderHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderHistory.Size = new Size(804, 105);
            dgvOrderHistory.TabIndex = 0;
            dgvOrderHistory.CellDoubleClick += dgvOrderHistory_CellDoubleClick;
            // 
            // colOrderId
            // 
            colOrderId.HeaderText = "Order ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.HeaderText = "Total Amount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(17, 52, 91);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(540, 520);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(180, 40);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Order Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.BackColor = Color.FromArgb(17, 52, 91);
            btnBackHome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBackHome.ForeColor = Color.White;
            btnBackHome.Location = new Point(270, 520);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(250, 40);
            btnBackHome.TabIndex = 6;
            btnBackHome.Text = "⌂  Back to Home";
            btnBackHome.UseVisualStyleBackColor = false;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // OrderTrackingForm
            // 
            AcceptButton = btnTrack;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 580);
            Controls.Add(btnBackHome);
            Controls.Add(btnViewDetails);
            Controls.Add(groupHistory);
            Controls.Add(groupTrack);
            Controls.Add(panelHeader);
            Name = "OrderTrackingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Tracking";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupTrack.ResumeLayout(false);
            groupTrack.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            groupHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Label lblHeaderSystem;
        private GroupBox groupTrack;
        private Label lblEnterOrderId;
        private TextBox txtOrderId;
        private Button btnTrack;
        private Panel panelStatus;
        private Label lblDeliveryIcon;
        private Label lblStatusCaption;
        private Label lblOrderStatus;
        private Label lblStatusMessage;
        private ListBox lstStatusHistory;
        private GroupBox groupHistory;
        private DataGridView dgvOrderHistory;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnViewDetails;
        private Button btnBackHome;
    }
}
