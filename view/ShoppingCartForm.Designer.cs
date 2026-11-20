namespace foododering
{
    partial class ShoppingCartForm
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
            lblTitle = new Label();
            lblProduct = new Label();
            txtProduct = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            lblBasket = new Label();
            dgvBasket = new DataGridView();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            btnRemove = new Button();
            btnEdit = new Button();
            btnClearBasket = new Button();
            btnSave = new Button();
            btnClose = new Button();
            btnPlaceOrder = new Button();
            lblNoItems = new Label();
            lblNoItemsValue = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBasket).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(166, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SHOPPING CART";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblProduct.Location = new Point(8, 36);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(107, 12);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "PleaseSpecify An Item";
            // 
            // txtProduct
            // 
            txtProduct.FormattingEnabled = true;
            txtProduct.Items.AddRange(new object[] { "Pineapples", "Lemons", "Pizza", "Burger", "Chips" });
            txtProduct.Location = new Point(8, 48);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(96, 23);
            txtProduct.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblQuantity.Location = new Point(120, 36);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(131, 12);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "PleaseSpecify The Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(166, 48);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(42, 23);
            txtQuantity.TabIndex = 4;
            txtQuantity.Text = "1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblPrice.Location = new Point(263, 33);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(113, 12);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "PleaseSpecify The Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(276, 48);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(75, 23);
            txtPrice.TabIndex = 6;
            txtPrice.Text = "1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(394, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 25);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBasket
            // 
            lblBasket.AutoSize = true;
            lblBasket.Location = new Point(8, 78);
            lblBasket.Name = "lblBasket";
            lblBasket.Size = new Size(41, 15);
            lblBasket.TabIndex = 8;
            lblBasket.Text = "Basket";
            // 
            // dgvBasket
            // 
            dgvBasket.AllowUserToAddRows = false;
            dgvBasket.AllowUserToDeleteRows = false;
            dgvBasket.AllowUserToResizeRows = false;
            dgvBasket.BackgroundColor = Color.DarkGray;
            dgvBasket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBasket.Columns.AddRange(new DataGridViewColumn[] { colProduct, colQuantity, colPrice, colTotal });
            dgvBasket.Location = new Point(8, 93);
            dgvBasket.MultiSelect = false;
            dgvBasket.Name = "dgvBasket";
            dgvBasket.ReadOnly = true;
            dgvBasket.RowHeadersVisible = false;
            dgvBasket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBasket.Size = new Size(322, 184);
            dgvBasket.TabIndex = 9;
            dgvBasket.CellClick += dgvBasket_CellClick;
            // 
            // colProduct
            // 
            colProduct.HeaderText = "Product";
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            colProduct.Width = 80;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 80;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 80;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 80;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(394, 104);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(58, 25);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Delete";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(394, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(58, 25);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClearBasket
            // 
            btnClearBasket.Location = new Point(394, 180);
            btnClearBasket.Name = "btnClearBasket";
            btnClearBasket.Size = new Size(58, 25);
            btnClearBasket.TabIndex = 12;
            btnClearBasket.Text = "Clear Basket";
            btnClearBasket.UseVisualStyleBackColor = true;
            btnClearBasket.Click += btnClearBasket_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(394, 218);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(58, 25);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(394, 252);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 25);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.FromArgb(17, 52, 91);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(293, 306);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(58, 25);
            btnPlaceOrder.TabIndex = 15;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // lblNoItems
            // 
            lblNoItems.AutoSize = true;
            lblNoItems.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblNoItems.Location = new Point(8, 306);
            lblNoItems.Name = "lblNoItems";
            lblNoItems.Size = new Size(47, 12);
            lblNoItems.TabIndex = 15;
            lblNoItems.Text = "No Items";
            // 
            // lblNoItemsValue
            // 
            lblNoItemsValue.BorderStyle = BorderStyle.FixedSingle;
            lblNoItemsValue.Location = new Point(54, 302);
            lblNoItemsValue.Name = "lblNoItemsValue";
            lblNoItemsValue.Size = new Size(50, 23);
            lblNoItemsValue.TabIndex = 16;
            lblNoItemsValue.Text = "0";
            lblNoItemsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblTotal.Location = new Point(120, 308);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 12);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblTotalValue
            // 
            lblTotalValue.BorderStyle = BorderStyle.FixedSingle;
            lblTotalValue.Location = new Point(154, 306);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(86, 23);
            lblTotalValue.TabIndex = 18;
            lblTotalValue.Text = "Rwf0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ShoppingCartForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(460, 350);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotal);
            Controls.Add(lblNoItemsValue);
            Controls.Add(lblNoItems);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnClearBasket);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(dgvBasket);
            Controls.Add(lblBasket);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtProduct);
            Controls.Add(lblProduct);
            Controls.Add(lblTitle);
            Controls.Add(btnPlaceOrder);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShoppingCartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SHOPPING CART";
            Load += ShoppingCartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProduct;
        private ComboBox txtProduct;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnAdd;
        private Label lblBasket;
        private DataGridView dgvBasket;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotal;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnClearBasket;
        private Button btnSave;
        private Button btnClose;
        private Button btnPlaceOrder;
        private Label lblNoItems;
        private Label lblNoItemsValue;
        private Label lblTotal;
        private Label lblTotalValue;
    }
}
