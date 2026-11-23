namespace BikeStore
{
    partial class frmForgotUserName
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
            lblEnterUserName = new Label();
            txtUserName = new TextBox();
            lblCheckUserGreeting = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(379, 244);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(132, 63);
            btnEnter.TabIndex = 14;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(126, 244);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 63);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblEnterUserName
            // 
            lblEnterUserName.AutoSize = true;
            lblEnterUserName.Location = new Point(47, 127);
            lblEnterUserName.Name = "lblEnterUserName";
            lblEnterUserName.Size = new Size(140, 25);
            lblEnterUserName.TabIndex = 12;
            lblEnterUserName.Text = "Enter Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(229, 124);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(282, 31);
            txtUserName.TabIndex = 11;
            // 
            // lblCheckUserGreeting
            // 
            lblCheckUserGreeting.AutoSize = true;
            lblCheckUserGreeting.Location = new Point(170, 43);
            lblCheckUserGreeting.Name = "lblCheckUserGreeting";
            lblCheckUserGreeting.Size = new Size(297, 25);
            lblCheckUserGreeting.TabIndex = 15;
            lblCheckUserGreeting.Text = "See if Username is an active account";
            // 
            // ForgotUserName
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(608, 353);
            Controls.Add(lblCheckUserGreeting);
            Controls.Add(btnEnter);
            Controls.Add(btnExit);
            Controls.Add(lblEnterUserName);
            Controls.Add(txtUserName);
            MaximizeBox = false;
            Name = "ForgotUserName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Username";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnExit;
        private Label lblEnterUserName;
        private TextBox txtUserName;
        private Label lblCheckUserGreeting;
    }
}