namespace BikeStore
{
    partial class frmForgotPasasword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnter = new Button();
            btnExit = new Button();
            txtPassword = new TextBox();
            lblEnterPassword = new Label();
            lblEnterUserName = new Label();
            txtUserName = new TextBox();
            lblChangePassword = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(413, 260);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(132, 63);
            btnEnter.TabIndex = 16;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(124, 260);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 63);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(234, 191);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 14;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Location = new Point(35, 194);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(176, 25);
            lblEnterPassword.TabIndex = 13;
            lblEnterPassword.Text = "Enter New Password:";
            // 
            // lblEnterUserName
            // 
            lblEnterUserName.AutoSize = true;
            lblEnterUserName.Location = new Point(52, 130);
            lblEnterUserName.Name = "lblEnterUserName";
            lblEnterUserName.Size = new Size(140, 25);
            lblEnterUserName.TabIndex = 12;
            lblEnterUserName.Text = "Enter Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(234, 127);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(282, 31);
            txtUserName.TabIndex = 11;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Location = new Point(281, 57);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(152, 25);
            lblChangePassword.TabIndex = 17;
            lblChangePassword.Text = "Change Password";
            // 
            // ForgotPassword
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(655, 359);
            Controls.Add(lblChangePassword);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(lblEnterPassword);
            Controls.Add(lblEnterUserName);
            Controls.Add(txtUserName);
            MaximizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnExit;
        private TextBox txtPassword;
        private Label lblEnterPassword;
        private Label lblEnterUserName;
        private TextBox txtUserName;
        private Label lblChangePassword;
    }
}