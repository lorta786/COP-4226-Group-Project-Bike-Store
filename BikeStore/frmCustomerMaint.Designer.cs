namespace BikeStore
{
    partial class frmCustomerMaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.cboResults = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(12, 12);
            this.lblHeading.Text = "Customer Maintenance";
            this.lblHeading.Name = "lblHeading";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = false;
            this.lblSearch.Location = new System.Drawing.Point(12, 52);
            this.lblSearch.Size = new System.Drawing.Size(60, 23);
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearch.Name = "lblSearch";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 53);
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Name = "txtSearch";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(306, 50);
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = false;
            this.lblResults.Location = new System.Drawing.Point(404, 52);
            this.lblResults.Size = new System.Drawing.Size(64, 23);
            this.lblResults.Text = "Results:";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResults.Name = "lblResults";
            // 
            // cboResults
            // 
            this.cboResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResults.FormattingEnabled = true;
            this.cboResults.Location = new System.Drawing.Point(474, 53);
            this.cboResults.Size = new System.Drawing.Size(272, 21);
            this.cboResults.TabIndex = 2;
            this.cboResults.Name = "cboResults";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Location = new System.Drawing.Point(12, 100);
            this.lblTitle.Size = new System.Drawing.Size(110, 23);
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Name = "lblTitle";
            // 
            // cboTitle
            // 
            this.cboTitle.Location = new System.Drawing.Point(128, 101);
            this.cboTitle.Size = new System.Drawing.Size(230, 21);
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.TabIndex = 3;
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Items.AddRange(new object[] { "Mr.", "Ms.", "Mrs.", "Dr." });
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = false;
            this.lblFirstName.Location = new System.Drawing.Point(12, 134);
            this.lblFirstName.Size = new System.Drawing.Size(110, 23);
            this.lblFirstName.Text = "First name: *";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFirstName.Name = "lblFirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(128, 135);
            this.txtFirstName.Size = new System.Drawing.Size(230, 20);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = false;
            this.lblMiddleName.Location = new System.Drawing.Point(12, 168);
            this.lblMiddleName.Size = new System.Drawing.Size(110, 23);
            this.lblMiddleName.Text = "Middle name:";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMiddleName.Name = "lblMiddleName";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(128, 169);
            this.txtMiddleName.Size = new System.Drawing.Size(230, 20);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.TabIndex = 5;
            this.txtMiddleName.Name = "txtMiddleName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = false;
            this.lblLastName.Location = new System.Drawing.Point(12, 202);
            this.lblLastName.Size = new System.Drawing.Size(110, 23);
            this.lblLastName.Text = "Last name: *";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLastName.Name = "lblLastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(128, 203);
            this.txtLastName.Size = new System.Drawing.Size(230, 20);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.TabIndex = 6;
            this.txtLastName.Name = "txtLastName";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = false;
            this.lblSuffix.Location = new System.Drawing.Point(12, 236);
            this.lblSuffix.Size = new System.Drawing.Size(110, 23);
            this.lblSuffix.Text = "Suffix:";
            this.lblSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSuffix.Name = "lblSuffix";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(128, 237);
            this.txtSuffix.Size = new System.Drawing.Size(230, 20);
            this.txtSuffix.MaxLength = 10;
            this.txtSuffix.TabIndex = 7;
            this.txtSuffix.Name = "txtSuffix";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = false;
            this.lblCompanyName.Location = new System.Drawing.Point(380, 100);
            this.lblCompanyName.Size = new System.Drawing.Size(110, 23);
            this.lblCompanyName.Text = "Company:";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCompanyName.Name = "lblCompanyName";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(496, 101);
            this.txtCompanyName.Size = new System.Drawing.Size(250, 20);
            this.txtCompanyName.MaxLength = 128;
            this.txtCompanyName.TabIndex = 8;
            this.txtCompanyName.Name = "txtCompanyName";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.Location = new System.Drawing.Point(380, 134);
            this.lblEmail.Size = new System.Drawing.Size(110, 23);
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(496, 135);
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Name = "txtEmail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = false;
            this.lblPhone.Location = new System.Drawing.Point(380, 168);
            this.lblPhone.Size = new System.Drawing.Size(110, 23);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhone.Name = "lblPhone";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(496, 169);
            this.mtbPhone.Size = new System.Drawing.Size(250, 20);
            this.mtbPhone.Mask = "(000) 000-0000";
            this.mtbPhone.TabIndex = 10;
            this.mtbPhone.Name = "mtbPhone";
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = false;
            this.lblSalesPerson.Location = new System.Drawing.Point(380, 202);
            this.lblSalesPerson.Size = new System.Drawing.Size(110, 23);
            this.lblSalesPerson.Text = "Sales person:";
            this.lblSalesPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSalesPerson.Name = "lblSalesPerson";
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(496, 203);
            this.txtSalesPerson.Size = new System.Drawing.Size(250, 20);
            this.txtSalesPerson.MaxLength = 256;
            this.txtSalesPerson.TabIndex = 11;
            this.txtSalesPerson.Name = "txtSalesPerson";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = false;
            this.lblCustomerID.Location = new System.Drawing.Point(380, 236);
            this.lblCustomerID.Size = new System.Drawing.Size(110, 23);
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCustomerID.Name = "lblCustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(496, 237);
            this.txtCustomerID.Size = new System.Drawing.Size(250, 20);
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.TabStop = false;
            this.txtCustomerID.TabIndex = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = false;
            this.lblRequired.Location = new System.Drawing.Point(12, 290);
            this.lblRequired.Size = new System.Drawing.Size(120, 23);
            this.lblRequired.Text = "* = required";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRequired.Name = "lblRequired";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(297, 286);
            this.btnNew.Size = new System.Drawing.Size(85, 30);
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.TabIndex = 13;
            this.btnNew.Name = "btnNew";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 286);
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.TabIndex = 14;
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(479, 286);
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(570, 286);
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.TabIndex = 16;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 286);
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.TabIndex = 17;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomerMaint
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(760, 332);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cboResults);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.lblSalesPerson);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCustomerMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cboResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
