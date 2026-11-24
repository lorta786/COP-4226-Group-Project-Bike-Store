
using System;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmErrorLog : Form
    {
        public frmErrorLog()
        {
            InitializeComponent();
        }

        private void frmErrorLog_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            mtxtStartTime.Text = "00:00";
            mtxtEndTime.Text = "23:59";
        }

        private bool ValidateSearch()
        {
            if (!TimeSpan.TryParse(mtxtStartTime.Text, out TimeSpan startTime) ||
                !TimeSpan.TryParse(mtxtEndTime.Text, out TimeSpan endTime))
            {
                MessageBox.Show("Please enter valid times.");
                return false;
            }

            if (startTime >= TimeSpan.FromDays(1) ||
                endTime >= TimeSpan.FromDays(1))
            {
                MessageBox.Show("Time must be between 00:00 and 23:59.");
                return false;
            }

            DateTime start = dtpStartDate.Value.Date + startTime;
            DateTime end = dtpEndDate.Value.Date + endTime;

            if (start > end)
            {
                MessageBox.Show(
                    "Start date and time cannot be later than end date and time.");
                return false;
            }

            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateSearch())
                return;

            MessageBox.Show("Date and time range is valid.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            mtxtStartTime.Text = "00:00";
            mtxtEndTime.Text = "23:59";

            dgvErrorLogs.ClearSelection();
        }
    }
}
