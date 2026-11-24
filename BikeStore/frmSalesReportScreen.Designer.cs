namespace BikeStore
{
    partial class frmSalesReportScreen
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
            panel1 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            exitButton = new Button();
            generatereportButton = new Button();
            browseButton = new Button();
            fileTextBox = new TextBox();
            savefileLabel = new Label();
            label5 = new Label();
            shipdateLabel = new Label();
            ordateLabel = new Label();
            lstnameLabel = new Label();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(generatereportButton);
            panel1.Controls.Add(browseButton);
            panel1.Controls.Add(fileTextBox);
            panel1.Controls.Add(savefileLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(shipdateLabel);
            panel1.Controls.Add(ordateLabel);
            panel1.Controls.Add(lstnameLabel);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 756);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(276, 217);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(638, 35);
            dateTimePicker2.TabIndex = 58;
            dateTimePicker2.Value = new DateTime(2004, 6, 14, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(276, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(638, 35);
            dateTimePicker1.TabIndex = 57;
            dateTimePicker1.Value = new DateTime(2004, 6, 1, 0, 0, 0, 0);
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(629, 610);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(196, 108);
            exitButton.TabIndex = 56;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // generatereportButton
            // 
            generatereportButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generatereportButton.Location = new Point(163, 610);
            generatereportButton.Name = "generatereportButton";
            generatereportButton.Size = new Size(196, 108);
            generatereportButton.TabIndex = 54;
            generatereportButton.Text = "Generate Report";
            generatereportButton.UseVisualStyleBackColor = true;
            generatereportButton.Click += button1_Click;
            // 
            // browseButton
            // 
            browseButton.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browseButton.Location = new Point(831, 405);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(115, 40);
            browseButton.TabIndex = 53;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // fileTextBox
            // 
            fileTextBox.BackColor = SystemColors.Window;
            fileTextBox.Enabled = false;
            fileTextBox.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileTextBox.ForeColor = SystemColors.WindowText;
            fileTextBox.Location = new Point(163, 407);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.ReadOnly = true;
            fileTextBox.Size = new Size(662, 38);
            fileTextBox.TabIndex = 52;
            // 
            // savefileLabel
            // 
            savefileLabel.AutoSize = true;
            savefileLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savefileLabel.Location = new Point(20, 407);
            savefileLabel.Name = "savefileLabel";
            savefileLabel.Size = new Size(142, 32);
            savefileLabel.TabIndex = 51;
            savefileLabel.Text = "Save to File:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(20, 306);
            label5.Name = "label5";
            label5.Size = new Size(920, 1);
            label5.TabIndex = 50;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shipdateLabel
            // 
            shipdateLabel.AutoSize = true;
            shipdateLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shipdateLabel.Location = new Point(111, 217);
            shipdateLabel.Name = "shipdateLabel";
            shipdateLabel.Size = new Size(123, 32);
            shipdateLabel.TabIndex = 47;
            shipdateLabel.Text = "Ship Date:";
            // 
            // ordateLabel
            // 
            ordateLabel.AutoSize = true;
            ordateLabel.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordateLabel.Location = new Point(111, 133);
            ordateLabel.Name = "ordateLabel";
            ordateLabel.Size = new Size(137, 32);
            ordateLabel.TabIndex = 46;
            ordateLabel.Text = "Order Date:";
            // 
            // lstnameLabel
            // 
            lstnameLabel.AutoSize = true;
            lstnameLabel.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstnameLabel.Location = new Point(381, 60);
            lstnameLabel.Name = "lstnameLabel";
            lstnameLabel.Size = new Size(199, 45);
            lstnameLabel.TabIndex = 5;
            lstnameLabel.Text = "Sales Report";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, ordersToolStripMenuItem, salesReportToolStripMenuItem });
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
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(84, 34);
            ordersToolStripMenuItem.Text = "Order";
            // 
            // salesReportToolStripMenuItem
            // 
            salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            salesReportToolStripMenuItem.Size = new Size(145, 34);
            salesReportToolStripMenuItem.Text = "Sales Report";
            // 
            // frmSalesReportScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 756);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "frmSalesReportScreen";
            Text = "Sales Report";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem salesReportToolStripMenuItem;
        private Label lstnameLabel;
        private Label ordateLabel;
        private Label shipdateLabel;
        private Label label5;
        private Label savefileLabel;
        private TextBox fileTextBox;
        private Button browseButton;
        private Button exitButton;
        private Button generatereportButton;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private SaveFileDialog saveFileDialog1;
    }
}