using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        
private void btnEnter_Click(object sender, EventArgs e)
{
    // Check that the username is entered.
    if (!InputValidation.IsRequired(txtUserName, "Username"))
    {
        return;
    }

    // Check that a new password is entered.
    if (!InputValidation.IsRequired(txtPassword, "New password"))
    {
        return;
    }

    // Check the minimum password length.
    if (!InputValidation.HasMinLength(txtPassword, "New password", 8))
    {
        return;
    }

    MessageBox.Show(
        "Password reset fields passed validation.",
        "Validation Complete");
}


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
