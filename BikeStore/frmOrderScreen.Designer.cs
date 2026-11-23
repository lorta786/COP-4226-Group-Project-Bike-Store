namespace BikeStore
{
    partial class frmOrderScreen
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
            pnlOrderScreen = new Panel();
            totalTextBox = new TextBox();
            taxTextBox = new TextBox();
            sbtotalTextBox = new TextBox();
            newodrButton = new Button();
            exitButton = new Button();
            totalLabel = new Label();
            taxLabel = new Label();
            sbtotalLabel = new Label();
            clearButton = new Button();
            removeitmButton = new Button();
            updtqtyButton = new Button();
            itemlist = new DataGridView();
            addtocartButton = new Button();
            qtyTextBox = new TextBox();
            qtyLabel2 = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            resultComboBox2 = new ComboBox();
            resultLabel2 = new Label();
            searchButton2 = new Button();
            productTextBox = new TextBox();
            prdctLabel = new Label();
            label5 = new Label();
            cidTextBox = new TextBox();
            cidLabel = new Label();
            lstnameTextBox2 = new TextBox();
            lstnameLabel2 = new Label();
            companyTextBox = new TextBox();
            companyLabel = new Label();
            frstnameTextBox = new TextBox();
            frstnameLabel = new Label();
            resultComboBox = new ComboBox();
            searchButton = new Button();
            resultLabel = new Label();
            lstnameTextBox = new TextBox();
            lstnameLabel = new Label();
            line = new Label();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            pnlOrderScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemlist).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOrderScreen
            // 
            pnlOrderScreen.Controls.Add(totalTextBox);
            pnlOrderScreen.Controls.Add(taxTextBox);
            pnlOrderScreen.Controls.Add(sbtotalTextBox);
            pnlOrderScreen.Controls.Add(newodrButton);
            pnlOrderScreen.Controls.Add(exitButton);
            pnlOrderScreen.Controls.Add(totalLabel);
            pnlOrderScreen.Controls.Add(taxLabel);
            pnlOrderScreen.Controls.Add(sbtotalLabel);
            pnlOrderScreen.Controls.Add(clearButton);
            pnlOrderScreen.Controls.Add(removeitmButton);
            pnlOrderScreen.Controls.Add(updtqtyButton);
            pnlOrderScreen.Controls.Add(itemlist);
            pnlOrderScreen.Controls.Add(addtocartButton);
            pnlOrderScreen.Controls.Add(qtyTextBox);
            pnlOrderScreen.Controls.Add(qtyLabel2);
            pnlOrderScreen.Controls.Add(priceTextBox);
            pnlOrderScreen.Controls.Add(priceLabel);
            pnlOrderScreen.Controls.Add(resultComboBox2);
            pnlOrderScreen.Controls.Add(resultLabel2);
            pnlOrderScreen.Controls.Add(searchButton2);
            pnlOrderScreen.Controls.Add(productTextBox);
            pnlOrderScreen.Controls.Add(prdctLabel);
            pnlOrderScreen.Controls.Add(label5);
            pnlOrderScreen.Controls.Add(cidTextBox);
            pnlOrderScreen.Controls.Add(cidLabel);
            pnlOrderScreen.Controls.Add(lstnameTextBox2);
            pnlOrderScreen.Controls.Add(lstnameLabel2);
            pnlOrderScreen.Controls.Add(companyTextBox);
            pnlOrderScreen.Controls.Add(companyLabel);
            pnlOrderScreen.Controls.Add(frstnameTextBox);
            pnlOrderScreen.Controls.Add(frstnameLabel);
            pnlOrderScreen.Controls.Add(resultComboBox);
            pnlOrderScreen.Controls.Add(searchButton);
            pnlOrderScreen.Controls.Add(resultLabel);
            pnlOrderScreen.Controls.Add(lstnameTextBox);
            pnlOrderScreen.Controls.Add(lstnameLabel);
            pnlOrderScreen.Controls.Add(line);
            pnlOrderScreen.Controls.Add(menuStrip1);
            pnlOrderScreen.Dock = DockStyle.Fill;
            pnlOrderScreen.Location = new Point(0, 0);
            pnlOrderScreen.Name = "pnlOrderScreen";
            pnlOrderScreen.Size = new Size(960, 756);
            pnlOrderScreen.TabIndex = 1;
            // 
            // totalTextBox
            // 
            totalTextBox.BackColor = SystemColors.Window;
            totalTextBox.Enabled = false;
            totalTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextBox.ForeColor = SystemColors.WindowText;
            totalTextBox.Location = new Point(717, 625);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.PlaceholderText = "$";
            totalTextBox.ReadOnly = true;
            totalTextBox.Size = new Size(231, 38);
            totalTextBox.TabIndex = 39;
            // 
            // taxTextBox
            // 
            taxTextBox.BackColor = SystemColors.Window;
            taxTextBox.Enabled = false;
            taxTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxTextBox.ForeColor = SystemColors.WindowText;
            taxTextBox.Location = new Point(717, 581);
            taxTextBox.Name = "taxTextBox";
            taxTextBox.PlaceholderText = "$";
            taxTextBox.ReadOnly = true;
            taxTextBox.Size = new Size(231, 38);
            taxTextBox.TabIndex = 38;
            // 
            // sbtotalTextBox
            // 
            sbtotalTextBox.BackColor = SystemColors.Window;
            sbtotalTextBox.Enabled = false;
            sbtotalTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtotalTextBox.ForeColor = SystemColors.WindowText;
            sbtotalTextBox.Location = new Point(717, 537);
            sbtotalTextBox.Name = "sbtotalTextBox";
            sbtotalTextBox.PlaceholderText = "$";
            sbtotalTextBox.ReadOnly = true;
            sbtotalTextBox.Size = new Size(231, 38);
            sbtotalTextBox.TabIndex = 37;
            // 
            // newodrButton
            // 
            newodrButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newodrButton.Location = new Point(612, 684);
            newodrButton.Name = "newodrButton";
            newodrButton.Size = new Size(165, 40);
            newodrButton.TabIndex = 36;
            newodrButton.Text = "New Order";
            newodrButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(783, 684);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(165, 40);
            exitButton.TabIndex = 35;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(570, 625);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(121, 32);
            totalLabel.TabIndex = 34;
            totalLabel.Text = "Total Due:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taxLabel.Location = new Point(639, 581);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(52, 32);
            taxLabel.TabIndex = 33;
            taxLabel.Text = "Tax:";
            // 
            // sbtotalLabel
            // 
            sbtotalLabel.AutoSize = true;
            sbtotalLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sbtotalLabel.Location = new Point(583, 537);
            sbtotalLabel.Name = "sbtotalLabel";
            sbtotalLabel.Size = new Size(108, 32);
            sbtotalLabel.TabIndex = 32;
            sbtotalLabel.Text = "Subtotal:";
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(386, 549);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(165, 40);
            clearButton.TabIndex = 31;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // removeitmButton
            // 
            removeitmButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeitmButton.Location = new Point(200, 549);
            removeitmButton.Name = "removeitmButton";
            removeitmButton.Size = new Size(165, 40);
            removeitmButton.TabIndex = 30;
            removeitmButton.Text = "Remove item";
            removeitmButton.UseVisualStyleBackColor = true;
            removeitmButton.Click += removeitmButton_Click;
            // 
            // updtqtyButton
            // 
            updtqtyButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updtqtyButton.Location = new Point(12, 549);
            updtqtyButton.Name = "updtqtyButton";
            updtqtyButton.Size = new Size(165, 40);
            updtqtyButton.TabIndex = 29;
            updtqtyButton.Text = "Update Qty";
            updtqtyButton.UseVisualStyleBackColor = true;
            updtqtyButton.Click += updtqtyButton_Click;
            // 
            // itemlist
            // 
            itemlist.AllowUserToAddRows = false;
            itemlist.AllowUserToDeleteRows = false;
            itemlist.AllowUserToResizeColumns = false;
            itemlist.AllowUserToResizeRows = false;
            itemlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemlist.Location = new Point(12, 342);
            itemlist.MultiSelect = false;
            itemlist.Name = "itemlist";
            itemlist.ReadOnly = true;
            itemlist.RowHeadersVisible = false;
            itemlist.RowHeadersWidth = 72;
            itemlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemlist.Size = new Size(936, 192);
            itemlist.TabIndex = 28;
            // 
            // addtocartButton
            // 
            addtocartButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addtocartButton.Location = new Point(776, 298);
            addtocartButton.Name = "addtocartButton";
            addtocartButton.Size = new Size(172, 40);
            addtocartButton.TabIndex = 27;
            addtocartButton.Text = "Add To Cart";
            addtocartButton.UseVisualStyleBackColor = true;
            addtocartButton.Click += addtocartButton_Click;
            // 
            // qtyTextBox
            // 
            qtyTextBox.BackColor = SystemColors.Window;
            qtyTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qtyTextBox.ForeColor = SystemColors.WindowText;
            qtyTextBox.Location = new Point(629, 298);
            qtyTextBox.Name = "qtyTextBox";
            qtyTextBox.Size = new Size(131, 38);
            qtyTextBox.TabIndex = 26;
            // 
            // qtyLabel2
            // 
            qtyLabel2.AutoSize = true;
            qtyLabel2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qtyLabel2.Location = new Point(538, 300);
            qtyLabel2.Name = "qtyLabel2";
            qtyLabel2.Size = new Size(57, 32);
            qtyLabel2.TabIndex = 25;
            qtyLabel2.Text = "Qty:";
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = SystemColors.Window;
            priceTextBox.Enabled = false;
            priceTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceTextBox.ForeColor = SystemColors.WindowText;
            priceTextBox.Location = new Point(134, 297);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "$";
            priceTextBox.ReadOnly = true;
            priceTextBox.Size = new Size(231, 38);
            priceTextBox.TabIndex = 24;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(7, 298);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(121, 32);
            priceLabel.TabIndex = 23;
            priceLabel.Text = "Unit Price:";
            // 
            // resultComboBox2
            // 
            resultComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            resultComboBox2.FormattingEnabled = true;
            resultComboBox2.Location = new Point(592, 251);
            resultComboBox2.Name = "resultComboBox2";
            resultComboBox2.Size = new Size(356, 38);
            resultComboBox2.TabIndex = 22;
            resultComboBox2.SelectedIndexChanged += resultComboBox2_SelectedIndexChanged;
            // 
            // resultLabel2
            // 
            resultLabel2.AutoSize = true;
            resultLabel2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel2.Location = new Point(501, 252);
            resultLabel2.Name = "resultLabel2";
            resultLabel2.Size = new Size(93, 32);
            resultLabel2.TabIndex = 21;
            resultLabel2.Text = "Results:";
            // 
            // searchButton2
            // 
            searchButton2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton2.Location = new Point(371, 249);
            searchButton2.Name = "searchButton2";
            searchButton2.Size = new Size(131, 40);
            searchButton2.TabIndex = 20;
            searchButton2.Text = "Search";
            searchButton2.UseVisualStyleBackColor = true;
            searchButton2.Click += searchButton2_Click;
            // 
            // productTextBox
            // 
            productTextBox.BackColor = SystemColors.Window;
            productTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTextBox.ForeColor = SystemColors.WindowText;
            productTextBox.Location = new Point(112, 249);
            productTextBox.Name = "productTextBox";
            productTextBox.PlaceholderText = "Enter Product Name:";
            productTextBox.Size = new Size(253, 38);
            productTextBox.TabIndex = 19;
            // 
            // prdctLabel
            // 
            prdctLabel.AutoSize = true;
            prdctLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prdctLabel.Location = new Point(7, 249);
            prdctLabel.Name = "prdctLabel";
            prdctLabel.Size = new Size(101, 32);
            prdctLabel.TabIndex = 18;
            prdctLabel.Text = "Product:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(20, 230);
            label5.Name = "label5";
            label5.Size = new Size(920, 1);
            label5.TabIndex = 17;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cidTextBox
            // 
            cidTextBox.BackColor = SystemColors.Window;
            cidTextBox.Enabled = false;
            cidTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cidTextBox.ForeColor = SystemColors.WindowText;
            cidTextBox.Location = new Point(592, 180);
            cidTextBox.Name = "cidTextBox";
            cidTextBox.ReadOnly = true;
            cidTextBox.Size = new Size(253, 38);
            cidTextBox.TabIndex = 16;
            cidTextBox.Text = "Auto-Assigned:";
            // 
            // cidLabel
            // 
            cidLabel.AutoSize = true;
            cidLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cidLabel.Location = new Point(442, 180);
            cidLabel.Name = "cidLabel";
            cidLabel.Size = new Size(152, 32);
            cidLabel.TabIndex = 15;
            cidLabel.Text = "Customer ID:";
            // 
            // lstnameTextBox2
            // 
            lstnameTextBox2.BackColor = SystemColors.Window;
            lstnameTextBox2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameTextBox2.ForeColor = SystemColors.WindowText;
            lstnameTextBox2.Location = new Point(592, 116);
            lstnameTextBox2.Name = "lstnameTextBox2";
            lstnameTextBox2.PlaceholderText = "Enter Last Name:";
            lstnameTextBox2.Size = new Size(253, 38);
            lstnameTextBox2.TabIndex = 14;
            // 
            // lstnameLabel2
            // 
            lstnameLabel2.AutoSize = true;
            lstnameLabel2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameLabel2.Location = new Point(442, 116);
            lstnameLabel2.Name = "lstnameLabel2";
            lstnameLabel2.Size = new Size(141, 32);
            lstnameLabel2.TabIndex = 12;
            lstnameLabel2.Text = "Last Name*:";
            // 
            // companyTextBox
            // 
            companyTextBox.BackColor = SystemColors.Window;
            companyTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyTextBox.ForeColor = SystemColors.WindowText;
            companyTextBox.Location = new Point(157, 174);
            companyTextBox.Name = "companyTextBox";
            companyTextBox.PlaceholderText = "Enter Company Name:";
            companyTextBox.Size = new Size(253, 38);
            companyTextBox.TabIndex = 11;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyLabel.Location = new Point(30, 174);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new Size(121, 32);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Company:";
            // 
            // frstnameTextBox
            // 
            frstnameTextBox.BackColor = SystemColors.Window;
            frstnameTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frstnameTextBox.ForeColor = SystemColors.WindowText;
            frstnameTextBox.Location = new Point(157, 110);
            frstnameTextBox.Name = "frstnameTextBox";
            frstnameTextBox.PlaceholderText = "Enter First Name:";
            frstnameTextBox.Size = new Size(253, 38);
            frstnameTextBox.TabIndex = 9;
            // 
            // frstnameLabel
            // 
            frstnameLabel.AutoSize = true;
            frstnameLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            frstnameLabel.Location = new Point(7, 110);
            frstnameLabel.Name = "frstnameLabel";
            frstnameLabel.Size = new Size(144, 32);
            frstnameLabel.TabIndex = 8;
            frstnameLabel.Text = "First Name*:";
            // 
            // resultComboBox
            // 
            resultComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            resultComboBox.FormattingEnabled = true;
            resultComboBox.Location = new Point(592, 49);
            resultComboBox.Name = "resultComboBox";
            resultComboBox.Size = new Size(356, 38);
            resultComboBox.TabIndex = 7;
            resultComboBox.SelectedIndexChanged += resultComboBox_SelectedIndexChanged;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(356, 49);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(131, 40);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(493, 49);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(93, 32);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Results:";
            // 
            // lstnameTextBox
            // 
            lstnameTextBox.BackColor = SystemColors.Window;
            lstnameTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameTextBox.ForeColor = SystemColors.WindowText;
            lstnameTextBox.Location = new Point(144, 49);
            lstnameTextBox.Name = "lstnameTextBox";
            lstnameTextBox.PlaceholderText = "Enter Last Name:";
            lstnameTextBox.Size = new Size(196, 38);
            lstnameTextBox.TabIndex = 4;
            // 
            // lstnameLabel
            // 
            lstnameLabel.AutoSize = true;
            lstnameLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameLabel.Location = new Point(7, 49);
            lstnameLabel.Name = "lstnameLabel";
            lstnameLabel.Size = new Size(131, 32);
            lstnameLabel.TabIndex = 3;
            lstnameLabel.Text = "Last Name:";
            // 
            // line
            // 
            line.BorderStyle = BorderStyle.FixedSingle;
            line.Location = new Point(20, 97);
            line.Name = "line";
            line.Size = new Size(920, 1);
            line.TabIndex = 2;
            line.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, orderToolStripMenuItem, salesReportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(138, 34);
            mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(84, 34);
            orderToolStripMenuItem.Text = "Order";
            // 
            // salesReportToolStripMenuItem
            // 
            salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            salesReportToolStripMenuItem.Size = new Size(145, 34);
            salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // frmOrderScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 756);
            Controls.Add(pnlOrderScreen);
            MainMenuStrip = menuStrip1;
            Name = "frmOrderScreen";
            Text = "Order";
            pnlOrderScreen.ResumeLayout(false);
            pnlOrderScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemlist).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlOrderScreen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private Label line;
        private Label lstnameLabel;
        private TextBox lstnameTextBox;
        private Button searchButton;
        private Label resultLabel;
        private ComboBox resultComboBox;
        private Label frstnameLabel;
        private TextBox frstnameTextBox;
        private TextBox companyTextBox;
        private Label companyLabel;
        private Label cidLabel;
        private TextBox lstnameTextBox2;
        private Label lstnameLabel2;
        private Label label5;
        private TextBox cidTextBox;
        private Label prdctLabel;
        private Label resultLabel2;
        private Button searchButton2;
        private Button addtocartButton;
        private Label totalLabel;
        private Label qtyLabel2;
        private TextBox priceTextBox;
        private Label priceLabel;
        private ComboBox resultComboBox2;
        private DataGridView itemlist;
        private Button clearButton;
        private Button removeitmButton;
        private Button updtqtyButton;
        private Label sbtotalLabel;
        private Button newodrButton;
        private Button exitButton;
        private TextBox taxTextBox;
        private TextBox sbtotalTextBox;
        private TextBox qtyTextBox;
        private Label taxLabel;
        private TextBox totalTextBox;
        
        private TextBox productTextBox;
    }
}