using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BikeStore

{
    public partial class frmOrderScreen : Form
    {
        private readonly Dictionary<string, (int CustomerID, string FirstName, string LastName, string CompanyName)> _customerData = new();

        private readonly Dictionary<string, (string ProductNumber, string ProductName, decimal ListPrice)> _productData = new();

        private readonly BindingList<CartItem> _cartItems = new();
        public frmOrderScreen()
        {
            InitializeComponent();
            InitializeCartDataGrid();
        }

        private void InitializeCartDataGrid()
        {
            itemlist.AutoGenerateColumns = false;
            itemlist.AllowUserToAddRows = false;
            itemlist.AllowUserToDeleteRows = false;
            itemlist.ReadOnly = true;
            itemlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            itemlist.MultiSelect = false;
            itemlist.RowHeadersVisible = false;
            itemlist.DataSource = _cartItems;

            itemlist.Columns.Clear();

            itemlist.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.ProductNumber),
                HeaderText = "Product #",
                Width = 115
            });

            itemlist.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.ProductName),
                HeaderText = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            itemlist.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.Quantity),
                HeaderText = "Qty",
                Width = 65,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            itemlist.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.UnitPrice),
                HeaderText = "Unit Price",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            itemlist.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.ListPrice),
                HeaderText = "List Price",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = lstnameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(query) || string.Equals(query, "Enter Last Name:", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a last name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstnameTextBox.Focus();
                return;
            }

            try
            {
                using (var connection = BaseDA.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM SalesLT.Customer WHERE LastName LIKE @LastName";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LastName", "%" + query + "%");
                        using (var reader = command.ExecuteReader())
                        {
                            resultComboBox.Items.Clear();
                            _customerData.Clear();
                            while (reader.Read())
                            {
                                int customerID = Convert.ToInt32(reader["CustomerID"]);
                                string firstName = reader["FirstName"]?.ToString() ?? string.Empty;
                                string lastName = reader["LastName"]?.ToString() ?? string.Empty;
                                string companyName = reader["CompanyName"]?.ToString() ?? string.Empty;

                                string fullName = $"{customerID}: {firstName} {lastName}";
                                resultComboBox.Items.Add(fullName);
                                _customerData[fullName] = (customerID, firstName, lastName, companyName);
                            }
                        }
                    }
                }
                if (resultComboBox.Items.Count > 0)
                {
                    resultComboBox.DroppedDown = true;
                }
                else
                {
                    MessageBox.Show("No customers found with the provided last name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultComboBox.SelectedItem is not string SelectedItem)
            {
                return;
            }

            if (resultComboBox.SelectedItem is string selectedItem && _customerData.TryGetValue(selectedItem, out var customerInfo))
            {
                frstnameTextBox.Text = customerInfo.FirstName;
                lstnameTextBox2.Text = customerInfo.LastName;
                companyTextBox.Text = customerInfo.CompanyName;
                cidTextBox.Text = customerInfo.CustomerID.ToString();
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            string query = productTextBox.Text.Trim();

            if (string.IsNullOrEmpty(query) || string.Equals(query, "Enter Product Name:", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a product name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productTextBox.Focus();
                return;
            }

            try
            {
                using (var connection = BaseDA.GetConnection())
                {
                    connection.Open();
                    string sql = "SELECT * FROM SalesLT.Product WHERE Name LIKE @ProductName";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", "%" + query + "%");
                        using (var reader = command.ExecuteReader())
                        {
                            resultComboBox2.Items.Clear();
                            _productData.Clear();
                            while (reader.Read())
                            {
                                string productNumber = reader["ProductNumber"]?.ToString() ?? string.Empty;
                                string productName = reader["Name"]?.ToString() ?? string.Empty;
                                decimal listPrice = Convert.ToDecimal(reader["ListPrice"]);
                                string displayText = $"{productNumber}: {productName}";
                                resultComboBox2.Items.Add(displayText);
                                _productData[displayText] = (productNumber, productName, listPrice);
                            }
                        }
                    }
                }
                if (resultComboBox2.Items.Count > 0)
                {
                    resultComboBox2.DroppedDown = true;
                }
                else
                {
                    MessageBox.Show("No products found with the provided name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addtocartButton_Click(object sender, EventArgs e)
        {
            if (resultComboBox2.SelectedItem is not string selectedItem || !_productData.TryGetValue(selectedItem, out var productInfo))
            {
                MessageBox.Show("Please select a valid product to add to the cart.", "Add to Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(qtyTextBox.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CartItem? existingItem = _cartItems.FirstOrDefault(item => item.ProductNumber == productInfo.ProductNumber);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductNumber = productInfo.ProductNumber,
                    ProductName = productInfo.ProductName,
                    UnitPrice = productInfo.ListPrice,
                    Quantity = quantity
                });
            }

            _cartItems.ResetBindings();
            itemlist.ClearSelection();
            itemlist.CurrentCell = null;

            decimal subtotal = _cartItems.Sum(item => item.ListPrice);
            const decimal taxRate = 0.07m;
            decimal tax = subtotal * taxRate;
            decimal total = subtotal + tax;

            sbtotalTextBox.Text = subtotal.ToString("C");
            taxTextBox.Text = tax.ToString("C");
            totalTextBox.Text = total.ToString("C");
        }

        private void resultComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultComboBox2.SelectedItem is not string SelectedItem)
            {
                return;
            }
            if (resultComboBox2.SelectedItem is string selectedItem && _productData.TryGetValue(selectedItem, out var productInfo))
            {
                priceTextBox.Text = productInfo.ListPrice.ToString("C");
            }
        }

        private void updtqtyButton_Click(object sender, EventArgs e)
        {
            if (itemlist.CurrentCell == null || itemlist.CurrentRow?.Index < 0 || itemlist.CurrentRow?.Index >= _cartItems.Count)
            {
                MessageBox.Show("Please select an item in the cart to update.", "Update Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(qtyTextBox.Text.Trim(), out int newQuantity) || newQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = itemlist.CurrentRow?.Index ?? -1;
            _cartItems[selectedIndex].Quantity = newQuantity;
            
_cartItems.ResetBindings();

decimal subtotal = _cartItems.Sum(item => item.ListPrice);
decimal tax = subtotal * 0.07m;
decimal total = subtotal + tax;

sbtotalTextBox.Text = subtotal.ToString("C");
taxTextBox.Text = tax.ToString("C");
totalTextBox.Text = total.ToString("C");

            itemlist.ClearSelection();
            itemlist.Rows[selectedIndex].Selected = true;
            itemlist.CurrentCell = itemlist.Rows[selectedIndex].Cells[0];
        }

        private void removeitmButton_Click(object sender, EventArgs e)
        {
            if (itemlist.CurrentCell == null || itemlist.CurrentRow?.Index < 0 || itemlist.CurrentRow?.Index >= _cartItems.Count)
            {
                MessageBox.Show("Please select an item in the cart to remove.", "Remove Item Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = itemlist.CurrentRow?.Index ?? -1;
            _cartItems.RemoveAt(selectedIndex);
            sbtotalTextBox.Text = _cartItems.Sum(item => item.ListPrice).ToString("C");
            taxTextBox.Text = (_cartItems.Sum(item => item.ListPrice) * 0.07m).ToString("C");
            totalTextBox.Text = (_cartItems.Sum(item => item.ListPrice) * 1.07m).ToString("C");

            itemlist.ClearSelection();
        }

        
private void clearButton_Click(object sender, EventArgs e)
{
    if (MessageBox.Show(
        "Are you sure you want to clear the cart?",
        "Clear Cart Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
    {
        _cartItems.Clear();

        sbtotalTextBox.Text = "$0.00";
        taxTextBox.Text = "$0.00";
        totalTextBox.Text = "$0.00";

        itemlist.ClearSelection();
        qtyTextBox.Clear();
        priceTextBox.Clear();
        productTextBox.Clear();
        resultComboBox2.SelectedIndex = -1;
    }
}


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newordButton_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0 || string.IsNullOrWhiteSpace(frstnameTextBox.Text) || string.IsNullOrWhiteSpace(lstnameTextBox2.Text))
            {
                MessageBox.Show("The cart is empty or customer information is missing. Please add items to the cart and fill in all customer details before proceeding to checkout.", "Empty Cart or Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(cidTextBox.Text.Trim(), out int customerID))
            {
                MessageBox.Show("Invalid Customer ID. Please ensure the customer information is correct.", "Customer ID Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string customerName = $"{frstnameTextBox.Text} {lstnameTextBox2.Text}".Trim();
            string companyName = companyTextBox.Text.Trim();

            decimal subtotal = _cartItems.Sum(item => item.ListPrice);
            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            frmReceipt receiptForm = new(_cartItems, customerName, customerID, companyName, subtotal, tax, total);

            receiptForm.ShowDialog();
            this.Close();
        }
    }
    public sealed class CartItem
    {
        public string ProductNumber { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice => UnitPrice * Quantity;
    }
}
