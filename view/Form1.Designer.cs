namespace foododering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbtitle = new Label();
            lbpassword = new Label();
            lbusername = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            picfood = new PictureBox();
            chkshowpassword = new CheckBox();
            lblink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picfood).BeginInit();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitle.Location = new Point(267, 66);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(159, 21);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Main Form of Login";
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpassword.Location = new Point(81, 224);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(82, 21);
            lbpassword.TabIndex = 1;
            lbpassword.Text = "Password";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbusername.Location = new Point(81, 149);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(87, 21);
            lbusername.TabIndex = 2;
            lbusername.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(78, 179);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(210, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(78, 253);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(210, 23);
            txtpassword.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ActiveCaption;
            btnlogin.Location = new Point(78, 360);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(210, 38);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // picfood
            // 
            picfood.BackgroundImage = Properties.Resources._111;
            picfood.Location = new Point(463, 145);
            picfood.Name = "picfood";
            picfood.Size = new Size(266, 278);
            picfood.SizeMode = PictureBoxSizeMode.Zoom;
            picfood.TabIndex = 6;
            picfood.TabStop = false;
            // 
            // chkshowpassword
            // 
            chkshowpassword.AutoSize = true;
            chkshowpassword.Location = new Point(91, 295);
            chkshowpassword.Name = "chkshowpassword";
            chkshowpassword.Size = new Size(54, 19);
            chkshowpassword.TabIndex = 7;
            chkshowpassword.Text = "show";
            chkshowpassword.UseVisualStyleBackColor = true;
            chkshowpassword.CheckedChanged += chkshowpassword_CheckedChanged;
            // 
            // lblink
            // 
            lblink.AutoSize = true;
            lblink.Location = new Point(80, 410);
            lblink.Name = "lblink";
            lblink.Size = new Size(176, 15);
            lblink.TabIndex = 8;
            lblink.TabStop = true;
            lblink.Text = "Don't have an account? Register";
            lblink.LinkClicked += lblink_LinkClicked;
            // 
            // Form1
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblink);
            Controls.Add(chkshowpassword);
            Controls.Add(picfood);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lbusername);
            Controls.Add(lbpassword);
            Controls.Add(lbtitle);
            Name = "Form1";
            Text = "login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picfood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private Label lbpassword;
        private Label lbusername;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private PictureBox picfood;
        private CheckBox chkshowpassword;
        private LinkLabel lblink;
    }
}
