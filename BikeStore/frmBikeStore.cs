using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmBikeStore : Form
    {
        public frmBikeStore()
        {
            InitializeComponent();
        }

        private void OpenFormHelper(Form form)
        {
            if (pnlContainer.Controls.Count > 0 && pnlContainer.Controls[0].GetType() == form.GetType())
            {
                form.Dispose();
                return;
            }
            pnlContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormHelper(new frmOrderScreen());

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormHelper(new frmBikeStore());
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormHelper(new frmSalesReportScreen());
        }
    }
}
