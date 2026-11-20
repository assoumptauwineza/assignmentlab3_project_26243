namespace foododering
{
    partial class RestaurantMenuForm
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
            groupFoodDetails = new GroupBox();
            rdoUnavailable = new RadioButton();
            rdoAvailable = new RadioButton();
            lblStatus = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtFoodName = new TextBox();
            lblFoodName = new Label();
            btnChooseImage = new Button();
            picFood = new PictureBox();
            groupMenuList = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvMenu = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFoodName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colMenuStatus = new DataGridViewTextBoxColumn();
            panelActions = new Panel();
            btnChangeStatus = new Button();
            btnRemoveFood = new Button();
            btnEditFood = new Button();
            btnAddFood = new Button();
            btnBackHome = new Button();
            panelHeader.SuspendLayout();
            groupFoodDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).BeginInit();
            groupMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 128, 128);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 95);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(40, 20);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(368, 32);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Restaurant Menu Management";
            // 
            // groupFoodDetails
            // 
            groupFoodDetails.Controls.Add(rdoUnavailable);
            groupFoodDetails.Controls.Add(rdoAvailable);
            groupFoodDetails.Controls.Add(lblStatus);
            groupFoodDetails.Controls.Add(cmbCategory);
            groupFoodDetails.Controls.Add(lblCategory);
            groupFoodDetails.Controls.Add(txtPrice);
            groupFoodDetails.Controls.Add(lblPrice);
            groupFoodDetails.Controls.Add(txtDescription);
            groupFoodDetails.Controls.Add(lblDescription);
            groupFoodDetails.Controls.Add(txtFoodName);
            groupFoodDetails.Controls.Add(lblFoodName);
            groupFoodDetails.Controls.Add(btnChooseImage);
            groupFoodDetails.Controls.Add(picFood);
            groupFoodDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupFoodDetails.Location = new Point(12, 110);
            groupFoodDetails.Name = "groupFoodDetails";
            groupFoodDetails.Size = new Size(390, 390);
            groupFoodDetails.TabIndex = 1;
            groupFoodDetails.TabStop = false;
            groupFoodDetails.Text = "Food Details";
            // 
            // rdoUnavailable
            // 
            rdoUnavailable.AutoSize = true;
            rdoUnavailable.Location = new Point(315, 254);
            rdoUnavailable.Name = "rdoUnavailable";
            rdoUnavailable.Size = new Size(89, 19);
            rdoUnavailable.TabIndex = 12;
            rdoUnavailable.Text = "Unavailable";
            rdoUnavailable.UseVisualStyleBackColor = true;
            // 
            // rdoAvailable
            // 
            rdoAvailable.AutoSize = true;
            rdoAvailable.Checked = true;
            rdoAvailable.Location = new Point(235, 254);
            rdoAvailable.Name = "rdoAvailable";
            rdoAvailable.Size = new Size(75, 19);
            rdoAvailable.TabIndex = 11;
            rdoAvailable.TabStop = true;
            rdoAvailable.Text = "Available";
            rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(145, 255);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Main Course", "Snack", "Drink", "Salad", "Dessert" });
            cmbCategory.Location = new Point(235, 206);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(145, 23);
            cmbCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(145, 210);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(235, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter price...";
            txtPrice.Size = new Size(145, 23);
            txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(145, 164);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(75, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price (RWF):";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(235, 88);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter description...";
            txtDescription.Size = new Size(145, 58);
            txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(145, 92);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(74, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(235, 42);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = "Enter food name...";
            txtFoodName.Size = new Size(145, 23);
            txtFoodName.TabIndex = 3;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(145, 46);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(73, 15);
            lblFoodName.TabIndex = 2;
            lblFoodName.Text = "Food Name:";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(12, 185);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(120, 32);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // picFood
            // 
            picFood.BackgroundImageLayout = ImageLayout.Stretch;
            picFood.BorderStyle = BorderStyle.FixedSingle;
            picFood.Location = new Point(12, 45);
            picFood.Name = "picFood";
            picFood.Size = new Size(120, 130);
            picFood.SizeMode = PictureBoxSizeMode.Zoom;
            picFood.TabIndex = 0;
            picFood.TabStop = false;
            // 
            // groupMenuList
            // 
            groupMenuList.Controls.Add(txtSearch);
            groupMenuList.Controls.Add(btnSearch);
            groupMenuList.Controls.Add(dgvMenu);
            groupMenuList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupMenuList.Location = new Point(414, 110);
            groupMenuList.Name = "groupMenuList";
            groupMenuList.Size = new Size(474, 390);
            groupMenuList.TabIndex = 2;
            groupMenuList.TabStop = false;
            groupMenuList.Text = "Menu List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search food...";
            txtSearch.Size = new Size(180, 23);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 128, 128);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(358, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 25);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.BackgroundColor = Color.White;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colId, colFoodName, colDescription, colPrice, colCategory, colMenuStatus });
            dgvMenu.Location = new Point(7, 48);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(460, 330);
            dgvMenu.TabIndex = 15;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // colId
            // 
            colId.FillWeight = 35F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
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
            // 
            // colPrice
            // 
            colPrice.FillWeight = 75F;
            colPrice.HeaderText = "Price (RWF)";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colMenuStatus
            // 
            colMenuStatus.HeaderText = "Status";
            colMenuStatus.Name = "colMenuStatus";
            colMenuStatus.ReadOnly = true;
            // 
            // panelActions
            // 
            panelActions.BorderStyle = BorderStyle.FixedSingle;
            panelActions.Controls.Add(btnChangeStatus);
            panelActions.Controls.Add(btnRemoveFood);
            panelActions.Controls.Add(btnEditFood);
            panelActions.Controls.Add(btnAddFood);
            panelActions.Location = new Point(12, 515);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(650, 58);
            panelActions.TabIndex = 3;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.FromArgb(255, 128, 128);
            btnChangeStatus.ForeColor = Color.White;
            btnChangeStatus.Location = new Point(481, 10);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(160, 36);
            btnChangeStatus.TabIndex = 3;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // btnRemoveFood
            // 
            btnRemoveFood.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoveFood.ForeColor = Color.White;
            btnRemoveFood.Location = new Point(323, 10);
            btnRemoveFood.Name = "btnRemoveFood";
            btnRemoveFood.Size = new Size(150, 36);
            btnRemoveFood.TabIndex = 2;
            btnRemoveFood.Text = "Remove Food";
            btnRemoveFood.UseVisualStyleBackColor = false;
            btnRemoveFood.Click += btnRemoveFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = Color.FromArgb(255, 128, 128);
            btnEditFood.ForeColor = Color.White;
            btnEditFood.Location = new Point(165, 10);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(150, 36);
            btnEditFood.TabIndex = 1;
            btnEditFood.Text = "Edit Food";
            btnEditFood.UseVisualStyleBackColor = false;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.FromArgb(255, 128, 128);
            btnAddFood.ForeColor = Color.White;
            btnAddFood.Location = new Point(7, 10);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(150, 36);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.BackColor = Color.FromArgb(255, 128, 128);
            btnBackHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBackHome.ForeColor = Color.White;
            btnBackHome.Location = new Point(680, 519);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(208, 50);
            btnBackHome.TabIndex = 4;
            btnBackHome.Text = "Back to Home";
            btnBackHome.UseVisualStyleBackColor = false;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // RestaurantMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 590);
            Controls.Add(btnBackHome);
            Controls.Add(panelActions);
            Controls.Add(groupMenuList);
            Controls.Add(groupFoodDetails);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RestaurantMenuForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restaurant Menu Management";
            Load += RestaurantMenuForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            groupFoodDetails.ResumeLayout(false);
            groupFoodDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFood).EndInit();
            groupMenuList.ResumeLayout(false);
            groupMenuList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private GroupBox groupFoodDetails;
        private PictureBox picFood;
        private Button btnChooseImage;
        private Label lblFoodName;
        private TextBox txtFoodName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblStatus;
        private RadioButton rdoAvailable;
        private RadioButton rdoUnavailable;
        private GroupBox groupMenuList;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvMenu;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFoodName;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colMenuStatus;
        private Panel panelActions;
        private Button btnAddFood;
        private Button btnEditFood;
        private Button btnRemoveFood;
        private Button btnChangeStatus;
        private Button btnBackHome;
    }
}
