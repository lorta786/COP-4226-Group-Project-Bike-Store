using System;
using System.Windows.Forms;

namespace BikeStore
{
    /// <summary>
    /// Customer maintenance: search, add, edit and delete customers.
    /// Phase 2: screen design and input validation.
    /// Phase 3: connect Search, Save and Delete to the database (CustomerDA).
    /// </summary>
    public partial class frmCustomerMaint : Form
    {
        public frmCustomerMaint()
        {
            InitializeComponent();
        }

        // Checks every field before saving.
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName, "First name") &&
                   Validator.IsPresent(txtLastName, "Last name") &&
                   Validator.IsValidEmail(txtEmail, "Email") &&
                   Validator.IsMaskComplete(mtbPhone, "Phone");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSearch, "Search text"))
            {
                // Phase 3: CustomerDA.Search(txtSearch.Text) fills cboResults.
                MessageBox.Show("Search will look up customers in the database in Phase 3.", "Search");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Validator.ClearScreen(this);
            txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Phase 3: insert if txtCustomerID is empty, otherwise update.
                MessageBox.Show("Customer data is valid.", "Save");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Trim() == "")
            {
                MessageBox.Show("Search for and select a customer before deleting.", "Delete");
                txtSearch.Focus();
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Delete " + txtFirstName.Text + " " + txtLastName.Text + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                // Phase 3: CustomerDA.Delete(customerID). Blocked if the customer has orders.
                Validator.ClearScreen(this);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Validator.ClearScreen(this);
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
