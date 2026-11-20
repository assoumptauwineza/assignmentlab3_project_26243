namespace foododering
{
    partial class CustomerHomePage
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
            lblHeaderWelcome = new Label();
            lblTitle = new Label();
            panelMenu = new Panel();
            lblMenu = new Label();
            btnHome = new Button();
            btnRestaurants = new Button();
            btnFoodMenu = new Button();
            btnShoppingCart = new Button();
            btnOrders = new Button();
            btnLogout = new Button();
            btnRestaurantOrders = new Button();
            btnDeliveryManagement = new Button();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            picHero = new PictureBox();
            lblQuestion = new Label();
            btnViewRestaurants = new Button();
            btnExploreMenu = new Button();
            btnQuickCart = new Button();
            btnQuickOrders = new Button();
            lblCart = new Label();
            lblStatus = new Label();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHero).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Maroon;
            panelHeader.Controls.Add(lblHeaderWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(9, 8);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(592, 67);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblHeaderWelcome
            // 
            lblHeaderWelcome.AutoSize = true;
            lblHeaderWelcome.Font = new Font("Segoe UI", 8F);
            lblHeaderWelcome.ForeColor = Color.White;
            lblHeaderWelcome.Location = new Point(11, 40);
            lblHeaderWelcome.Name = "lblHeaderWelcome";
            lblHeaderWelcome.Size = new Size(202, 13);
            lblHeaderWelcome.TabIndex = 1;
            lblHeaderWelcome.Text = "Welcome to our food ordering system";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FOOD ORDERING SYSTEM";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(238, 242, 247);
            panelMenu.Controls.Add(lblMenu);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnRestaurants);
            panelMenu.Controls.Add(btnFoodMenu);
            panelMenu.Controls.Add(btnShoppingCart);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnRestaurantOrders);
            panelMenu.Controls.Add(btnDeliveryManagement);
            panelMenu.Location = new Point(9, 84);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(172, 418);
            panelMenu.TabIndex = 1;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMenu.ForeColor = Color.Gainsboro;
            lblMenu.Location = new Point(8, 10);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(41, 13);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "MENU";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 222, 222);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(7, 37);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(158, 26);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRestaurants
            // 
            btnRestaurants.FlatAppearance.BorderSize = 0;
            btnRestaurants.FlatStyle = FlatStyle.Flat;
            btnRestaurants.Location = new Point(7, 73);
            btnRestaurants.Name = "btnRestaurants";
            btnRestaurants.Size = new Size(158, 26);
            btnRestaurants.TabIndex = 2;
            btnRestaurants.Text = "Restaurants";
            btnRestaurants.TextAlign = ContentAlignment.MiddleLeft;
            btnRestaurants.UseVisualStyleBackColor = true;
            btnRestaurants.Click += btnRestaurants_Click;
            // 
            // btnFoodMenu
            // 
            btnFoodMenu.FlatAppearance.BorderSize = 0;
            btnFoodMenu.FlatStyle = FlatStyle.Flat;
            btnFoodMenu.Location = new Point(7, 109);
            btnFoodMenu.Name = "btnFoodMenu";
            btnFoodMenu.Size = new Size(158, 26);
            btnFoodMenu.TabIndex = 3;
            btnFoodMenu.Text = "Food Menu";
            btnFoodMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnFoodMenu.UseVisualStyleBackColor = true;
            btnFoodMenu.Click += btnFoodMenu_Click;
            // 
            // btnShoppingCart
            // 
            btnShoppingCart.FlatAppearance.BorderSize = 0;
            btnShoppingCart.FlatStyle = FlatStyle.Flat;
            btnShoppingCart.Location = new Point(7, 145);
            btnShoppingCart.Name = "btnShoppingCart";
            btnShoppingCart.Size = new Size(158, 26);
            btnShoppingCart.TabIndex = 4;
            btnShoppingCart.Text = "Shopping Cart";
            btnShoppingCart.TextAlign = ContentAlignment.MiddleLeft;
            btnShoppingCart.UseVisualStyleBackColor = true;
            btnShoppingCart.Click += btnCart_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(7, 181);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(158, 26);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "My Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(7, 272);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(158, 26);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRestaurantOrders
            // 
            btnRestaurantOrders.FlatAppearance.BorderSize = 0;
            btnRestaurantOrders.FlatStyle = FlatStyle.Flat;
            btnRestaurantOrders.Location = new Point(0, 213);
            btnRestaurantOrders.Name = "btnRestaurantOrders";
            btnRestaurantOrders.Size = new Size(158, 26);
            btnRestaurantOrders.TabIndex = 7;
            btnRestaurantOrders.Text = "Restaurant Orders";
            btnRestaurantOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnRestaurantOrders.UseVisualStyleBackColor = true;
            btnRestaurantOrders.Click += btnRestaurantOrders_Click;
            // 
            // btnDeliveryManagement
            // 
            btnDeliveryManagement.FlatAppearance.BorderSize = 0;
            btnDeliveryManagement.FlatStyle = FlatStyle.Flat;
            btnDeliveryManagement.Location = new Point(0, 240);
            btnDeliveryManagement.Name = "btnDeliveryManagement";
            btnDeliveryManagement.Size = new Size(158, 26);
            btnDeliveryManagement.TabIndex = 8;
            btnDeliveryManagement.Text = "Delivery Management";
            btnDeliveryManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnDeliveryManagement.UseVisualStyleBackColor = true;
            btnDeliveryManagement.Click += btnDeliveryManagement_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(190, 28, 32);
            lblWelcome.Location = new Point(187, 84);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(87, 21);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome!";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 8F);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(187, 111);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(174, 13);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Order your favourite food easily.";
            // 
            // picHero
            // 
            picHero.BackgroundImage = Properties.Resources._111;
            picHero.BackgroundImageLayout = ImageLayout.Stretch;
            picHero.Location = new Point(187, 127);
            picHero.Name = "picHero";
            picHero.Size = new Size(414, 234);
            picHero.SizeMode = PictureBoxSizeMode.Zoom;
            picHero.TabIndex = 4;
            picHero.TabStop = false;
            picHero.Click += picHero_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(187, 373);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(200, 20);
            lblQuestion.TabIndex = 6;
            lblQuestion.Text = "What would you like to do?";
            // 
            // btnViewRestaurants
            // 
            btnViewRestaurants.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnViewRestaurants.FlatStyle = FlatStyle.Flat;
            btnViewRestaurants.ForeColor = Color.FromArgb(210, 35, 40);
            btnViewRestaurants.Location = new Point(187, 398);
            btnViewRestaurants.Name = "btnViewRestaurants";
            btnViewRestaurants.Size = new Size(205, 28);
            btnViewRestaurants.TabIndex = 7;
            btnViewRestaurants.Text = "View Restaurants";
            btnViewRestaurants.UseVisualStyleBackColor = true;
            btnViewRestaurants.Click += btnRestaurants_Click;
            // 
            // btnExploreMenu
            // 
            btnExploreMenu.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnExploreMenu.FlatStyle = FlatStyle.Flat;
            btnExploreMenu.ForeColor = Color.FromArgb(210, 35, 40);
            btnExploreMenu.Location = new Point(396, 398);
            btnExploreMenu.Name = "btnExploreMenu";
            btnExploreMenu.Size = new Size(205, 28);
            btnExploreMenu.TabIndex = 8;
            btnExploreMenu.Text = "Explore Food Menu";
            btnExploreMenu.UseVisualStyleBackColor = true;
            btnExploreMenu.Click += btnFoodMenu_Click;
            // 
            // btnQuickCart
            // 
            btnQuickCart.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnQuickCart.FlatStyle = FlatStyle.Flat;
            btnQuickCart.ForeColor = Color.FromArgb(210, 35, 40);
            btnQuickCart.Location = new Point(187, 433);
            btnQuickCart.Name = "btnQuickCart";
            btnQuickCart.Size = new Size(205, 28);
            btnQuickCart.TabIndex = 9;
            btnQuickCart.Text = "Shopping Cart";
            btnQuickCart.UseVisualStyleBackColor = true;
            btnQuickCart.Click += btnCart_Click;
            // 
            // btnQuickOrders
            // 
            btnQuickOrders.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnQuickOrders.FlatStyle = FlatStyle.Flat;
            btnQuickOrders.ForeColor = Color.FromArgb(210, 35, 40);
            btnQuickOrders.Location = new Point(396, 433);
            btnQuickOrders.Name = "btnQuickOrders";
            btnQuickOrders.Size = new Size(205, 28);
            btnQuickOrders.TabIndex = 10;
            btnQuickOrders.Text = "My Orders";
            btnQuickOrders.UseVisualStyleBackColor = true;
            btnQuickOrders.Click += btnOrders_Click;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.ForeColor = Color.White;
            lblCart.Location = new Point(187, 467);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(46, 15);
            lblCart.TabIndex = 11;
            lblCart.Text = "Cart (0)";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Gainsboro;
            lblStatus.Location = new Point(187, 487);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(159, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Select an option to continue.";
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(242, 526);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(219, 15);
            lblFooter.TabIndex = 13;
            lblFooter.Text = "Food Ordering System | Enjoy your meal";
            // 
            // CustomerHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(643, 555);
            Controls.Add(lblFooter);
            Controls.Add(lblStatus);
            Controls.Add(lblCart);
            Controls.Add(btnQuickOrders);
            Controls.Add(btnQuickCart);
            Controls.Add(btnExploreMenu);
            Controls.Add(btnViewRestaurants);
            Controls.Add(lblQuestion);
            Controls.Add(picHero);
            Controls.Add(lblSubtitle);
            Controls.Add(lblWelcome);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page Design";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblHeaderWelcome;
        private Panel panelMenu;
        private Label lblMenu;
        private Button btnHome;
        private Button btnRestaurants;
        private Button btnFoodMenu;
        private Button btnShoppingCart;
        private Button btnOrders;
        private Button btnLogout;
        private Button btnRestaurantOrders;
        private Button btnDeliveryManagement;
        private Label lblWelcome;
        private Label lblSubtitle;
        private PictureBox picHero;
        private Label lblQuestion;
        private Button btnViewRestaurants;
        private Button btnExploreMenu;
        private Button btnQuickCart;
        private Button btnQuickOrders;
        private Label lblCart;
        private Label lblStatus;
        private Label lblFooter;
    }
}
