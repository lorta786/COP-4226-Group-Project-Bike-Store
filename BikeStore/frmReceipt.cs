using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BikeStore
{
    public partial class frmReceipt : Form
    {
        private BindingList<CartItem> _receiptItems = new();
        public frmReceipt(BindingList<CartItem> receiptItems, string customerName, int customerID, string companyName, decimal subtotal, decimal tax, decimal total)
        {
            InitializeComponent();

            _receiptItems = receiptItems ?? new BindingList<CartItem>();

            receiptItemList.DataSource = _receiptItems;
            customerTextBox.Text = customerName;
            companyTextBox.Text = companyName;
            ordernumTextBox.Text = customerID.ToString();
            sbtotalTextBox.Text = subtotal.ToString("C");
            taxTextBox.Text = tax.ToString("C");
            totalTextBox.Text = total.ToString("C");

            InitializeReceiptGrid();

            try
            {
                using (var connection = BaseDA.GetConnection())
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM SalesLT.SalesOrderHeader WHERE CustomerID = @CustomerID";
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ordernumTextBox.Text = reader["SalesOrderID"].ToString();
                            ordateTextBox.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("MM/dd/yyyy");
                            shipdateTextBox.Text = Convert.ToDateTime(reader["ShipDate"]).ToString("MM/dd/yyyy");
                            shipmethodTextBox.Text = reader["ShipMethod"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeReceiptGrid()
        {
            receiptItemList.AutoGenerateColumns = false;
            receiptItemList.AllowUserToAddRows = false;
            receiptItemList.AllowUserToDeleteRows = false;
            receiptItemList.ReadOnly = true;
            receiptItemList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            receiptItemList.MultiSelect = false;
            receiptItemList.RowHeadersVisible = false;
            receiptItemList.DataSource = _receiptItems;
            receiptItemList.ClearSelection();
            receiptItemList.CurrentCell = null;
            receiptItemList.Enabled = false;

            receiptItemList.Columns.Clear();

            receiptItemList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.ProductNumber),
                HeaderText = "Product #",
                Width = 115
            });

            receiptItemList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.ProductName),
                HeaderText = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            receiptItemList.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(CartItem.Quantity),
                HeaderText = "Qty",
                Width = 65,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            receiptItemList.Columns.Add(new DataGridViewTextBoxColumn
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

            receiptItemList.Columns.Add(new DataGridViewTextBoxColumn
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
