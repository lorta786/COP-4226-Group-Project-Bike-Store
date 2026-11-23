namespace BikeStore
{
    partial class frmLogin
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
            lblUserName = new Label();
            lblGreeting = new Label();
            txtUserName = new TextBox();
            btnForgotUser = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnForgotPassword = new Button();
            btnExit = new Button();
            btnCreateAccount = new Button();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(42, 108);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username:";
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Location = new Point(219, 51);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(227, 25);
            lblGreeting.TabIndex = 1;
            lblGreeting.Text = "Welcome to our Bike Store!";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(193, 108);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(325, 31);
            txtUserName.TabIndex = 2;
            // 
            // btnForgotUser
            // 
            btnForgotUser.Location = new Point(248, 159);
            btnForgotUser.Name = "btnForgotUser";
            btnForgotUser.Size = new Size(198, 34);
            btnForgotUser.TabIndex = 3;
            btnForgotUser.Text = "Forgot Username?";
            btnForgotUser.UseVisualStyleBackColor = true;
            btnForgotUser.Click += btnForgotUser_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(42, 227);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 224);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(325, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Location = new Point(248, 273);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(198, 34);
            btnForgotPassword.TabIndex = 6;
            btnForgotPassword.Text = "Forgot Password?";
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(193, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 61);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(344, 349);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(127, 61);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(499, 349);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(124, 61);
            btnLogIn.TabIndex = 9;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LogIn
            // 
            AcceptButton = btnLogIn;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(684, 437);
            Controls.Add(btnLogIn);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnExit);
            Controls.Add(btnForgotPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnForgotUser);
            Controls.Add(txtUserName);
            Controls.Add(lblGreeting);
            Controls.Add(lblUserName);
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblGreeting;
        private TextBox txtUserName;
        private Button btnForgotUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnForgotPassword;
        private Button btnExit;
        private Button btnCreateAccount;
        private Button btnLogIn;
    }
}
