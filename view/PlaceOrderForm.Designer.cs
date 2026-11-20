namespace foododering
{
    partial class PlaceOrderForm
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
            lblHeaderIcon = new Label();
            groupDelivery = new GroupBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblDeliveryAddress = new Label();
            txtDeliveryAddress = new TextBox();
            lblAdditionalNotes = new Label();
            txtAdditionalNotes = new TextBox();
            groupSummary = new GroupBox();
            lblTotalCaption = new Label();
            lblTotalAmount = new Label();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            btnBackToCart = new Button();
            btnConfirmOrder = new Button();
            panelHeader.SuspendLayout();
            groupDelivery.SuspendLayout();
            groupSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 52, 91);
            panelHeader.Controls.Add(lblHeaderSystem);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(lblHeaderIcon);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(774, 96);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderSystem
            // 
            lblHeaderSystem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHeaderSystem.AutoSize = true;
            lblHeaderSystem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHeaderSystem.ForeColor = Color.White;
            lblHeaderSystem.Location = new Point(562, 62);
            lblHeaderSystem.Name = "lblHeaderSystem";
            lblHeaderSystem.Size = new Size(0, 20);
            lblHeaderSystem.TabIndex = 2;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(117, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(320, 51);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Place Your Order";
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.AutoSize = true;
            lblHeaderIcon.Font = new Font("Segoe UI Symbol", 28F);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(32, 19);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(0, 51);
            lblHeaderIcon.TabIndex = 0;
            // 
            // groupDelivery
            // 
            groupDelivery.Controls.Add(lblCustomerName);
            groupDelivery.Controls.Add(txtCustomerName);
            groupDelivery.Controls.Add(lblPhoneNumber);
            groupDelivery.Controls.Add(txtPhoneNumber);
            groupDelivery.Controls.Add(lblDeliveryAddress);
            groupDelivery.Controls.Add(txtDeliveryAddress);
            groupDelivery.Controls.Add(lblAdditionalNotes);
            groupDelivery.Controls.Add(txtAdditionalNotes);
            groupDelivery.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupDelivery.Location = new Point(16, 110);
            groupDelivery.Name = "groupDelivery";
            groupDelivery.Size = new Size(742, 210);
            groupDelivery.TabIndex = 1;
            groupDelivery.TabStop = false;
            groupDelivery.Text = "Delivery Information";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(17, 39);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(127, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(207, 36);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(295, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(17, 79);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(120, 20);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(207, 76);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(295, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblDeliveryAddress
            // 
            lblDeliveryAddress.AutoSize = true;
            lblDeliveryAddress.Location = new Point(17, 119);
            lblDeliveryAddress.Name = "lblDeliveryAddress";
            lblDeliveryAddress.Size = new Size(132, 20);
            lblDeliveryAddress.TabIndex = 4;
            lblDeliveryAddress.Text = "Delivery Address:";
            // 
            // txtDeliveryAddress
            // 
            txtDeliveryAddress.Location = new Point(207, 116);
            txtDeliveryAddress.Name = "txtDeliveryAddress";
            txtDeliveryAddress.Size = new Size(295, 27);
            txtDeliveryAddress.TabIndex = 5;
            // 
            // lblAdditionalNotes
            // 
            lblAdditionalNotes.AutoSize = true;
            lblAdditionalNotes.Location = new Point(17, 159);
            lblAdditionalNotes.Name = "lblAdditionalNotes";
            lblAdditionalNotes.Size = new Size(132, 20);
            lblAdditionalNotes.TabIndex = 6;
            lblAdditionalNotes.Text = "Additional Notes:";
            // 
            // txtAdditionalNotes
            // 
            txtAdditionalNotes.Location = new Point(207, 156);
            txtAdditionalNotes.Multiline = true;
            txtAdditionalNotes.Name = "txtAdditionalNotes";
            txtAdditionalNotes.ScrollBars = ScrollBars.Vertical;
            txtAdditionalNotes.Size = new Size(295, 50);
            txtAdditionalNotes.TabIndex = 7;
            // 
            // groupSummary
            // 
            groupSummary.Controls.Add(lblTotalCaption);
            groupSummary.Controls.Add(lblTotalAmount);
            groupSummary.Controls.Add(lblPaymentMethod);
            groupSummary.Controls.Add(cmbPaymentMethod);
            groupSummary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupSummary.Location = new Point(16, 334);
            groupSummary.Name = "groupSummary";
            groupSummary.Size = new Size(742, 82);
            groupSummary.TabIndex = 2;
            groupSummary.TabStop = false;
            groupSummary.Text = "Order Summary";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Location = new Point(17, 35);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(110, 20);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.BackColor = Color.FromArgb(220, 226, 238);
            lblTotalAmount.Location = new Point(168, 29);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(180, 36);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "0 RWF";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(387, 35);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(134, 20);
            lblPaymentMethod.TabIndex = 2;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash on Delivery", "Mobile Money", "Bank Card" });
            cmbPaymentMethod.Location = new Point(546, 31);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(176, 28);
            cmbPaymentMethod.TabIndex = 3;
            // 
            // btnBackToCart
            // 
            btnBackToCart.BackColor = Color.FromArgb(225, 228, 233);
            btnBackToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBackToCart.Location = new Point(139, 438);
            btnBackToCart.Name = "btnBackToCart";
            btnBackToCart.Size = new Size(238, 49);
            btnBackToCart.TabIndex = 3;
            btnBackToCart.Text = "  Back to Cart";
            btnBackToCart.UseVisualStyleBackColor = false;
            btnBackToCart.Click += btnBackToCart_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.FromArgb(17, 52, 91);
            btnConfirmOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(397, 438);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(238, 49);
            btnConfirmOrder.TabIndex = 4;
            btnConfirmOrder.Text = "  Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // PlaceOrderForm
            // 
            AcceptButton = btnConfirmOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBackToCart;
            ClientSize = new Size(774, 520);
            Controls.Add(btnConfirmOrder);
            Controls.Add(btnBackToCart);
            Controls.Add(groupSummary);
            Controls.Add(groupDelivery);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlaceOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Place Order";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupDelivery.ResumeLayout(false);
            groupDelivery.PerformLayout();
            groupSummary.ResumeLayout(false);
            groupSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderIcon;
        private Label lblHeaderTitle;
        private Label lblHeaderSystem;
        private GroupBox groupDelivery;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblDeliveryAddress;
        private TextBox txtDeliveryAddress;
        private Label lblAdditionalNotes;
        private TextBox txtAdditionalNotes;
        private GroupBox groupSummary;
        private Label lblTotalCaption;
        private Label lblTotalAmount;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Button btnBackToCart;
        private Button btnConfirmOrder;
    }
}
