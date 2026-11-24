namespace BikeStore
{
    partial class frmReceipt
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
            lstnameLabel = new Label();
            ordernumLabel = new Label();
            customerLabel = new Label();
            companyLabel = new Label();
            label5 = new Label();
            receiptItemList = new DataGridView();
            sbtotalLabel = new Label();
            sbtotalTextBox = new TextBox();
            taxTextBox = new TextBox();
            totalTextBox = new TextBox();
            taxLabel = new Label();
            totalLabel = new Label();
            exitButton = new Button();
            ordateLabel = new Label();
            ordernumTextBox = new TextBox();
            customerTextBox = new TextBox();
            companyTextBox = new TextBox();
            ordateTextBox = new TextBox();
            shipdateLabel = new Label();
            shipdateTextBox = new TextBox();
            shipmethodLabel = new Label();
            shipmethodTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)receiptItemList).BeginInit();
            SuspendLayout();
            // 
            // lstnameLabel
            // 
            lstnameLabel.AutoSize = true;
            lstnameLabel.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameLabel.Location = new Point(417, 30);
            lstnameLabel.Name = "lstnameLabel";
            lstnameLabel.Size = new Size(126, 45);
            lstnameLabel.TabIndex = 4;
            lstnameLabel.Text = "Receipt";
            // 
            // ordernumLabel
            // 
            ordernumLabel.AutoSize = true;
            ordernumLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordernumLabel.Location = new Point(72, 92);
            ordernumLabel.Name = "ordernumLabel";
            ordernumLabel.Size = new Size(101, 32);
            ordernumLabel.TabIndex = 5;
            ordernumLabel.Text = "Order #:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerLabel.Location = new Point(51, 176);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(122, 32);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyLabel.Location = new Point(52, 260);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new Size(121, 32);
            companyLabel.TabIndex = 7;
            companyLabel.Text = "Company:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(20, 317);
            label5.Name = "label5";
            label5.Size = new Size(920, 1);
            label5.TabIndex = 18;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // receiptItemList
            // 
            receiptItemList.AllowUserToAddRows = false;
            receiptItemList.AllowUserToDeleteRows = false;
            receiptItemList.AllowUserToResizeColumns = false;
            receiptItemList.AllowUserToResizeRows = false;
            receiptItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receiptItemList.Location = new Point(12, 340);
            receiptItemList.MultiSelect = false;
            receiptItemList.Name = "receiptItemList";
            receiptItemList.ReadOnly = true;
            receiptItemList.RowHeadersVisible = false;
            receiptItemList.RowHeadersWidth = 72;
            receiptItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            receiptItemList.Size = new Size(936, 192);
            receiptItemList.TabIndex = 29;
            // 
            // sbtotalLabel
            // 
            sbtotalLabel.AutoSize = true;
            sbtotalLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtotalLabel.Location = new Point(597, 535);
            sbtotalLabel.Name = "sbtotalLabel";
            sbtotalLabel.Size = new Size(108, 32);
            sbtotalLabel.TabIndex = 33;
            sbtotalLabel.Text = "Subtotal:";
            // 
            // sbtotalTextBox
            // 
            sbtotalTextBox.BackColor = SystemColors.Window;
            sbtotalTextBox.Enabled = false;
            sbtotalTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtotalTextBox.ForeColor = SystemColors.WindowText;
            sbtotalTextBox.Location = new Point(717, 535);
            sbtotalTextBox.Name = "sbtotalTextBox";
            sbtotalTextBox.PlaceholderText = "$";
            sbtotalTextBox.ReadOnly = true;
            sbtotalTextBox.Size = new Size(231, 38);
            sbtotalTextBox.TabIndex = 38;
            // 
            // taxTextBox
            // 
            taxTextBox.BackColor = SystemColors.Window;
            taxTextBox.Enabled = false;
            taxTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxTextBox.ForeColor = SystemColors.WindowText;
            taxTextBox.Location = new Point(717, 579);
            taxTextBox.Name = "taxTextBox";
            taxTextBox.PlaceholderText = "$";
            taxTextBox.ReadOnly = true;
            taxTextBox.Size = new Size(231, 38);
            taxTextBox.TabIndex = 39;
            // 
            // totalTextBox
            // 
            totalTextBox.BackColor = SystemColors.Window;
            totalTextBox.Enabled = false;
            totalTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextBox.ForeColor = SystemColors.WindowText;
            totalTextBox.Location = new Point(717, 623);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.PlaceholderText = "$";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(231, 38);
            totalTextBox.TabIndex = 40;
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxLabel.Location = new Point(653, 579);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(52, 32);
            taxLabel.TabIndex = 41;
            taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(584, 623);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(121, 32);
            totalLabel.TabIndex = 42;
            totalLabel.Text = "Total Due:";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(783, 689);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(165, 40);
            exitButton.TabIndex = 44;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ordateLabel
            // 
            ordateLabel.AutoSize = true;
            ordateLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordateLabel.Location = new Point(548, 86);
            ordateLabel.Name = "ordateLabel";
            ordateLabel.Size = new Size(137, 32);
            ordateLabel.TabIndex = 45;
            ordateLabel.Text = "Order Date:";
            // 
            // ordernumTextBox
            // 
            ordernumTextBox.BackColor = SystemColors.Window;
            ordernumTextBox.Enabled = false;
            ordernumTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordernumTextBox.ForeColor = SystemColors.WindowText;
            ordernumTextBox.Location = new Point(179, 92);
            ordernumTextBox.Name = "ordernumTextBox";
            ordernumTextBox.ReadOnly = true;
            ordernumTextBox.Size = new Size(231, 38);
            ordernumTextBox.TabIndex = 46;
            // 
            // customerTextBox
            // 
            customerTextBox.BackColor = SystemColors.Window;
            customerTextBox.Enabled = false;
            customerTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerTextBox.ForeColor = SystemColors.WindowText;
            customerTextBox.Location = new Point(179, 176);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.ReadOnly = true;
            customerTextBox.Size = new Size(231, 38);
            customerTextBox.TabIndex = 47;
            // 
            // companyTextBox
            // 
            companyTextBox.BackColor = SystemColors.Window;
            companyTextBox.Enabled = false;
            companyTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyTextBox.ForeColor = SystemColors.WindowText;
            companyTextBox.Location = new Point(179, 260);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.ReadOnly = true;
            companyTextBox.Size = new Size(231, 38);
            companyTextBox.TabIndex = 48;
            // 
            // ordateTextBox
            // 
            ordateTextBox.BackColor = SystemColors.Window;
            ordateTextBox.Enabled = false;
            ordateTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordateTextBox.ForeColor = SystemColors.WindowText;
            ordateTextBox.Location = new Point(709, 86);
            ordateTextBox.Name = "ordateTextBox";
            ordateTextBox.ReadOnly = true;
            ordateTextBox.Size = new Size(231, 38);
            ordateTextBox.TabIndex = 49;
            // 
            // shipdateLabel
            // 
            shipdateLabel.AutoSize = true;
            shipdateLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipdateLabel.Location = new Point(562, 176);
            shipdateLabel.Name = "shipdateLabel";
            shipdateLabel.Size = new Size(123, 32);
            shipdateLabel.TabIndex = 50;
            shipdateLabel.Text = "Ship Date:";
            // 
            // shipdateTextBox
            // 
            shipdateTextBox.BackColor = SystemColors.Window;
            shipdateTextBox.Enabled = false;
            shipdateTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipdateTextBox.ForeColor = SystemColors.WindowText;
            shipdateTextBox.Location = new Point(709, 173);
            shipdateTextBox.Name = "shipdateTextBox";
            shipdateTextBox.ReadOnly = true;
            shipdateTextBox.Size = new Size(231, 38);
            shipdateTextBox.TabIndex = 51;
            // 
            // shipmethodLabel
            // 
            shipmethodLabel.AutoSize = true;
            shipmethodLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipmethodLabel.Location = new Point(527, 260);
            shipmethodLabel.Name = "shipmethodLabel";
            shipmethodLabel.Size = new Size(158, 32);
            shipmethodLabel.TabIndex = 52;
            shipmethodLabel.Text = "Ship Method:";
            // 
            // shipmethodTextBox
            // 
            shipmethodTextBox.BackColor = SystemColors.Window;
            shipmethodTextBox.Enabled = false;
            shipmethodTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipmethodTextBox.ForeColor = SystemColors.WindowText;
            shipmethodTextBox.Location = new Point(709, 260);
            shipmethodTextBox.Name = "shipmethodTextBox";
            shipmethodTextBox.ReadOnly = true;
            shipmethodTextBox.Size = new Size(231, 38);
            shipmethodTextBox.TabIndex = 53;
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 756);
            Controls.Add(shipmethodTextBox);
            Controls.Add(shipmethodLabel);
            Controls.Add(shipdateTextBox);
            Controls.Add(shipdateLabel);
            Controls.Add(ordateTextBox);
            Controls.Add(companyTextBox);
            Controls.Add(customerTextBox);
            Controls.Add(ordernumTextBox);
            Controls.Add(ordateLabel);
            Controls.Add(exitButton);
            Controls.Add(totalLabel);
            Controls.Add(taxLabel);
            Controls.Add(totalTextBox);
            Controls.Add(taxTextBox);
            Controls.Add(sbtotalTextBox);
            Controls.Add(sbtotalLabel);
            Controls.Add(receiptItemList);
            Controls.Add(label5);
            Controls.Add(companyLabel);
            Controls.Add(customerLabel);
            Controls.Add(ordernumLabel);
            Controls.Add(lstnameLabel);
            Name = "frmReceipt";
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)receiptItemList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lstnameLabel;
        private Label ordernumLabel;
        private Label customerLabel;
        private Label companyLabel;
        private Label label5;
        private DataGridView receiptItemList;
        private Label sbtotalLabel;
        private TextBox sbtotalTextBox;
        private TextBox textBox1;
        private TextBox totalTextBox;
        private Label taxLabel;
        private Label totalLabel;
        private Button exitButton;
        private Label ordateLabel;
        private TextBox ordernumTextBox;
        private TextBox customerTextBox;
        private TextBox companyTextBox;
        private TextBox ordateTextBox;
        private Label shipdateLabel;
        private TextBox shipdateTextBox;
        private Label shipmethodLabel;
        private TextBox shipmethodTextBox;

        private TextBox taxTextBox;
    }
}