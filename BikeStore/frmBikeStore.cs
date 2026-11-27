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

public frmBikeStore()
{
    InitializeComponent();

    menuStrip1.Items.Add(
        "Customers", null,
        (sender, e) => OpenFormHelper(new frmCustomerMaint()));

    menuStrip1.Items.Add(
        "Products", null,
        (sender, e) => OpenFormHelper(new frmProductMaint()));

    menuStrip1.Items.Add(
        "Error Log", null,
        (sender, e) => OpenFormHelper(new frmErrorLog()));

    menuStrip1.BringToFront();
}

private void ClearCurrentForm()
{
    while (pnlContainer.Controls.Count > 0)
    {
        Control current = pnlContainer.Controls[0];
        pnlContainer.Controls.RemoveAt(0);
        current.Dispose();
    }
}
        private void OpenFormHelper(Form form)
        {
            if (pnlContainer.Controls.Count > 0 && pnlContainer.Controls[0].GetType() == form.GetType())
            {
                form.Dispose();
                return;
            }
            ClearCurrentForm();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCurrentForm();

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
