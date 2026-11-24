using System;
using System.Windows.Forms;

namespace BikeStore
{
    /// <summary>
    /// Product maintenance: search, add, edit and delete products.
    /// Phase 2: screen design and input validation.
    /// Phase 3: connect Search, Save, Delete and the dropdowns to the database (ProductDA).
    /// </summary>
    public partial class frmProductMaint : Form
    {
        public frmProductMaint()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmProductMaint_Load);
        }

        private void frmProductMaint_Load(object? sender, EventArgs e)
        {
            // Phase 3: fill these from the ProductCategory and ProductModel tables.
            // Temporary items so the dropdowns can be tested in Phase 2.
            cboCategory.Items.AddRange(new object[] { "Bikes", "Components", "Clothing", "Accessories" });
            cboModel.Items.Add("(models load from the database in Phase 3)");
        }

        // Checks every field before saving.
        private bool IsValidData()
        {
            // Required fields, and prices must be numbers of 0 or more.
            if (!(Validator.IsPresent(txtName, "Name") &&
                  Validator.IsPresent(txtProductNumber, "Product #") &&
                  Validator.IsPresent(txtStandardCost, "Standard cost") &&
                  Validator.IsDecimal(txtStandardCost, "Standard cost") &&
                  Validator.IsWithinRange(txtStandardCost, "Standard cost", 0m, 1000000m) &&
                  Validator.IsPresent(txtListPrice, "List price") &&
                  Validator.IsDecimal(txtListPrice, "List price") &&
                  Validator.IsWithinRange(txtListPrice, "List price", 0m, 1000000m)))
            {
                return false;
            }

            // Weight is optional, but must be a valid number if entered (decimal 8,2).
            if (txtWeight.Text.Trim() != "")
            {
                if (!(Validator.IsDecimal(txtWeight, "Weight") &&
                      Validator.IsWithinRange(txtWeight, "Weight", 0m, 999999.99m)))
                {
                    return false;
                }
            }

            // Sell end and discontinued dates are optional, but can't be before sell start.
            if (dtpSellEnd.Checked &&
                !Validator.IsDateOnOrAfter(dtpSellEnd, dtpSellStart, "Sell end date", "the sell start date"))
            {
                return false;
            }

            if (dtpDiscontinued.Checked &&
                !Validator.IsDateOnOrAfter(dtpDiscontinued, dtpSellStart, "Discontinued date", "the sell start date"))
            {
                return false;
            }

            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSearch, "Search text"))
            {
                // Phase 3: ProductDA.SearchByName(txtSearch.Text) fills cboResults.
                MessageBox.Show("Search will look up products by partial name in Phase 3.", "Search");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Validator.ClearScreen(this);
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Phase 3: insert a new product or update the selected one.
                MessageBox.Show("Product data is valid.", "Save");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboResults.SelectedIndex == -1)
            {
                MessageBox.Show("Search for and select a product before deleting.", "Delete");
                txtSearch.Focus();
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Delete " + txtName.Text + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                // Phase 3: ProductDA.Delete(productID). Blocked if the product has been sold.
                Validator.ClearScreen(this);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Validator.ClearScreen(this);
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
