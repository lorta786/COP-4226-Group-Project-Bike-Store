using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
private void btnEnter_Click(object sender, EventArgs e)
{
    if (!InputValidation.IsRequired(txtFirstName, "First name"))
        return;

    if (!InputValidation.IsRequired(txtLastName, "Last name"))
        return;

    if (!InputValidation.IsRequired(txtUserName, "Username"))
        return;

    if (!InputValidation.IsRequired(txtPassword, "Password"))
        return;

    if (!InputValidation.HasMinLength(txtPassword, "Password", 8))
        return;

    MessageBox.Show("All input fields passed validation.");
}

    }
}
