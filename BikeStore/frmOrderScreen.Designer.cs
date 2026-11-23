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
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            salesReportToolStripMenuItem = new ToolStripMenuItem();
            pnlOrderScreen.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOrderScreen
            // 
            pnlOrderScreen.Controls.Add(menuStrip1);
            pnlOrderScreen.Dock = DockStyle.Fill;
            pnlOrderScreen.Location = new Point(0, 0);
            pnlOrderScreen.Name = "pnlOrderScreen";
            pnlOrderScreen.Size = new Size(960, 540);
            pnlOrderScreen.TabIndex = 1;
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
            ClientSize = new Size(960, 540);
            Controls.Add(pnlOrderScreen);
            MainMenuStrip = menuStrip1;
            Name = "frmOrderScreen";
            Text = "Order";
            pnlOrderScreen.ResumeLayout(false);
            pnlOrderScreen.PerformLayout();
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
    }
}