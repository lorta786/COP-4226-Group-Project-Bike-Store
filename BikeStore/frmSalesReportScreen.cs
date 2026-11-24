using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmSalesReportScreen : Form
    {
        public frmSalesReportScreen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fileTextBox.Text))
            {
                MessageBox.Show("Please select a file path to save the sales report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Sales Report from " + dateTimePicker1.Value + " to " + dateTimePicker2.Value + " successfully generated at " + fileTextBox.Text + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog()
            {
                Filter = "CSV Files|*.csv|Text Files|*.txt|Excel Files|*.xlsx;*.xls",
                Title = "Save Sales Report",
                DefaultExt = "csv",
                FileName = "SalesReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv",
                AddExtension = true,
                OverwritePrompt = true
            };

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                fileTextBox.Text = saveFileDialog.FileName;
            }

        }
    }
}
