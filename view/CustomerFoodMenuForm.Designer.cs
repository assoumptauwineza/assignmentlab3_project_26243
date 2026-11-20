namespace foododering
{
    partial class CustomerFoodMenuForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            dgvMenu = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFoodName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAddToCart = new Button();
            btnClose = new Button();
            lblStatus = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Maroon;
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 86);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FOOD MENU";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(27, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(257, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose an available meal and add it to your cart";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(24, 104);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(350, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 25);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.BackgroundColor = Color.White;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colId, colFoodName, colDescription, colPrice, colCategory, colStatus });
            dgvMenu.Location = new Point(24, 140);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(852, 300);
            dgvMenu.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.FillWeight = 35F;
            // 
            // colFoodName
            // 
            colFoodName.HeaderText = "Food Name";
            colFoodName.Name = "colFoodName";
            colFoodName.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.FillWeight = 150F;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.FillWeight = 70F;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 466);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(86, 463);
            numQuantity.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(70, 23);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.Maroon;
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(180, 460);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(150, 30);
            btnAddToCart.TabIndex = 7;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(760, 460);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 30);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Maroon;
            lblStatus.Location = new Point(24, 505);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Loading...";
            // 
            // CustomerFoodMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 540);
            Controls.Add(lblStatus);
            Controls.Add(btnClose);
            Controls.Add(btnAddToCart);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(dgvMenu);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerFoodMenuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Food Menu";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnRefresh;
        private DataGridView dgvMenu;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFoodName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colStatus;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAddToCart;
        private Button btnClose;
        private Label lblStatus;

        #endregion
    }
}
