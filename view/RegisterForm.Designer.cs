namespace foododering
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbltitle = new Label();
            lblusername = new Label();
            txtusername = new TextBox();
            lblpassword = new Label();
            txtpassword = new TextBox();
            lblconfirmPassword = new Label();
            txtconfirmPassword = new TextBox();
            btnregister = new Button();
            btncancel = new Button();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(24, 20);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(147, 21);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Create an account";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(24, 65);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(60, 15);
            lblusername.TabIndex = 1;
            lblusername.Text = "Name";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.HighlightText;
            txtusername.Location = new Point(134, 65);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(202, 23);
            txtusername.TabIndex = 2;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(24, 119);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(57, 15);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(134, 119);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(202, 23);
            txtpassword.TabIndex = 4;
            // 
            // lblconfirmPassword
            // 
            lblconfirmPassword.AutoSize = true;
            lblconfirmPassword.Location = new Point(24, 173);
            lblconfirmPassword.Name = "lblconfirmPassword";
            lblconfirmPassword.Size = new Size(104, 15);
            lblconfirmPassword.TabIndex = 5;
            lblconfirmPassword.Text = "Confirm password";
            // 
            // txtconfirmPassword
            // 
            txtconfirmPassword.Location = new Point(134, 173);
            txtconfirmPassword.Name = "txtconfirmPassword";
            txtconfirmPassword.PasswordChar = '*';
            txtconfirmPassword.Size = new Size(201, 23);
            txtconfirmPassword.TabIndex = 6;
            // 
            // btnregister
            // 
            btnregister.Location = new Point(180, 232);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(75, 28);
            btnregister.TabIndex = 7;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // btncancel
            // 
            btncancel.DialogResult = DialogResult.Cancel;
            btncancel.Location = new Point(261, 232);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 28);
            btncancel.TabIndex = 8;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AcceptButton = btnregister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btncancel;
            ClientSize = new Size(647, 370);
            Controls.Add(btncancel);
            Controls.Add(btnregister);
            Controls.Add(txtconfirmPassword);
            Controls.Add(lblconfirmPassword);
            Controls.Add(txtpassword);
            Controls.Add(lblpassword);
            Controls.Add(txtusername);
            Controls.Add(lblusername);
            Controls.Add(lbltitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label lblusername;
        private TextBox txtusername;
        private Label lblpassword;
        private TextBox txtpassword;
        private Label lblconfirmPassword;
        private TextBox txtconfirmPassword;
        private Button btnregister;
        private Button btncancel;
    }
}
