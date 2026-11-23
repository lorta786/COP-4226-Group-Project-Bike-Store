namespace BikeStore
{
    partial class CreateAccount
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
            label1 = new Label();
            lblEnterFirstName = new Label();
            txtFirstName = new TextBox();
            lblEnterLastName = new Label();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            lblEnterUserName = new Label();
            lblEnterPassword = new Label();
            txtPassword = new TextBox();
            btnExit = new Button();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 42);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // lblEnterFirstName
            // 
            lblEnterFirstName.AutoSize = true;
            lblEnterFirstName.Location = new Point(60, 104);
            lblEnterFirstName.Name = "lblEnterFirstName";
            lblEnterFirstName.Size = new Size(146, 25);
            lblEnterFirstName.TabIndex = 1;
            lblEnterFirstName.Text = "Enter First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(238, 104);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(282, 31);
            txtFirstName.TabIndex = 2;
            // 
            // lblEnterLastName
            // 
            lblEnterLastName.AutoSize = true;
            lblEnterLastName.Location = new Point(56, 177);
            lblEnterLastName.Name = "lblEnterLastName";
            lblEnterLastName.Size = new Size(144, 25);
            lblEnterLastName.TabIndex = 3;
            lblEnterLastName.Text = "Enter Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(238, 177);
            txtLastName.MaxLength = 20;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 31);
            txtLastName.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(238, 242);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(282, 31);
            txtUserName.TabIndex = 5;
            // 
            // lblEnterUserName
            // 
            lblEnterUserName.AutoSize = true;
            lblEnterUserName.Location = new Point(56, 245);
            lblEnterUserName.Name = "lblEnterUserName";
            lblEnterUserName.Size = new Size(140, 25);
            lblEnterUserName.TabIndex = 6;
            lblEnterUserName.Text = "Enter Username:";
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Location = new Point(60, 309);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(136, 25);
            lblEnterPassword.TabIndex = 7;
            lblEnterPassword.Text = "Enter Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(238, 306);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(444, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 63);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(620, 375);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(132, 63);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // CreateAccount
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(lblEnterPassword);
            Controls.Add(lblEnterUserName);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(lblEnterLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEnterFirstName);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblEnterFirstName;
        private TextBox txtFirstName;
        private Label lblEnterLastName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private Label lblEnterUserName;
        private Label lblEnterPassword;
        private TextBox txtPassword;
        private Button btnExit;
        private Button btnEnter;
    }
}