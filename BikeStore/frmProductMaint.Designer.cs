namespace BikeStore
{
    partial class frmProductMaint
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.dtpDiscontinued = new System.Windows.Forms.DateTimePicker();
            this.lblStandardCost = new System.Windows.Forms.Label();
            this.txtStandardCost = new System.Windows.Forms.TextBox();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.lblSellStart = new System.Windows.Forms.Label();
            this.dtpSellStart = new System.Windows.Forms.DateTimePicker();
            this.lblSellEnd = new System.Windows.Forms.Label();
            this.dtpSellEnd = new System.Windows.Forms.DateTimePicker();
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
            this.lblHeading.Text = "Product Maintenance";
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
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.Location = new System.Drawing.Point(12, 100);
            this.lblName.Size = new System.Drawing.Size(110, 23);
            this.lblName.Text = "Name: *";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Name = "lblName";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 101);
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.MaxLength = 50;
            this.txtName.TabIndex = 3;
            this.txtName.Name = "txtName";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = false;
            this.lblProductNumber.Location = new System.Drawing.Point(12, 134);
            this.lblProductNumber.Size = new System.Drawing.Size(110, 23);
            this.lblProductNumber.Text = "Product #: *";
            this.lblProductNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProductNumber.Name = "lblProductNumber";
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(128, 135);
            this.txtProductNumber.Size = new System.Drawing.Size(230, 20);
            this.txtProductNumber.MaxLength = 25;
            this.txtProductNumber.TabIndex = 4;
            this.txtProductNumber.Name = "txtProductNumber";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = false;
            this.lblColor.Location = new System.Drawing.Point(12, 168);
            this.lblColor.Size = new System.Drawing.Size(110, 23);
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColor.Name = "lblColor";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(128, 169);
            this.txtColor.Size = new System.Drawing.Size(230, 20);
            this.txtColor.MaxLength = 15;
            this.txtColor.TabIndex = 5;
            this.txtColor.Name = "txtColor";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = false;
            this.lblSize.Location = new System.Drawing.Point(12, 202);
            this.lblSize.Size = new System.Drawing.Size(110, 23);
            this.lblSize.Text = "Size:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSize.Name = "lblSize";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(128, 203);
            this.txtSize.Size = new System.Drawing.Size(230, 20);
            this.txtSize.MaxLength = 5;
            this.txtSize.TabIndex = 6;
            this.txtSize.Name = "txtSize";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = false;
            this.lblWeight.Location = new System.Drawing.Point(12, 236);
            this.lblWeight.Size = new System.Drawing.Size(110, 23);
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWeight.Name = "lblWeight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(128, 237);
            this.txtWeight.Size = new System.Drawing.Size(230, 20);
            this.txtWeight.MaxLength = 9;
            this.txtWeight.TabIndex = 7;
            this.txtWeight.Name = "txtWeight";
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = false;
            this.lblDiscontinued.Location = new System.Drawing.Point(12, 270);
            this.lblDiscontinued.Size = new System.Drawing.Size(110, 23);
            this.lblDiscontinued.Text = "Discontinued:";
            this.lblDiscontinued.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscontinued.Name = "lblDiscontinued";
            // 
            // dtpDiscontinued
            // 
            this.dtpDiscontinued.Location = new System.Drawing.Point(128, 271);
            this.dtpDiscontinued.Size = new System.Drawing.Size(230, 20);
            this.dtpDiscontinued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiscontinued.ShowCheckBox = true;
            this.dtpDiscontinued.Checked = false;
            this.dtpDiscontinued.TabIndex = 8;
            this.dtpDiscontinued.Name = "dtpDiscontinued";
            // 
            // lblStandardCost
            // 
            this.lblStandardCost.AutoSize = false;
            this.lblStandardCost.Location = new System.Drawing.Point(380, 100);
            this.lblStandardCost.Size = new System.Drawing.Size(110, 23);
            this.lblStandardCost.Text = "Standard cost: *";
            this.lblStandardCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStandardCost.Name = "lblStandardCost";
            // 
            // txtStandardCost
            // 
            this.txtStandardCost.Location = new System.Drawing.Point(496, 101);
            this.txtStandardCost.Size = new System.Drawing.Size(250, 20);
            this.txtStandardCost.MaxLength = 12;
            this.txtStandardCost.TabIndex = 9;
            this.txtStandardCost.Name = "txtStandardCost";
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = false;
            this.lblListPrice.Location = new System.Drawing.Point(380, 134);
            this.lblListPrice.Size = new System.Drawing.Size(110, 23);
            this.lblListPrice.Text = "List price: *";
            this.lblListPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblListPrice.Name = "lblListPrice";
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(496, 135);
            this.txtListPrice.Size = new System.Drawing.Size(250, 20);
            this.txtListPrice.MaxLength = 12;
            this.txtListPrice.TabIndex = 10;
            this.txtListPrice.Name = "txtListPrice";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = false;
            this.lblCategory.Location = new System.Drawing.Point(380, 168);
            this.lblCategory.Size = new System.Drawing.Size(110, 23);
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCategory.Name = "lblCategory";
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(496, 169);
            this.cboCategory.Size = new System.Drawing.Size(250, 21);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.TabIndex = 11;
            this.cboCategory.Name = "cboCategory";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = false;
            this.lblModel.Location = new System.Drawing.Point(380, 202);
            this.lblModel.Size = new System.Drawing.Size(110, 23);
            this.lblModel.Text = "Model:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblModel.Name = "lblModel";
            // 
            // cboModel
            // 
            this.cboModel.Location = new System.Drawing.Point(496, 203);
            this.cboModel.Size = new System.Drawing.Size(250, 21);
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.TabIndex = 12;
            this.cboModel.Name = "cboModel";
            // 
            // lblSellStart
            // 
            this.lblSellStart.AutoSize = false;
            this.lblSellStart.Location = new System.Drawing.Point(380, 236);
            this.lblSellStart.Size = new System.Drawing.Size(110, 23);
            this.lblSellStart.Text = "Sell start: *";
            this.lblSellStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSellStart.Name = "lblSellStart";
            // 
            // dtpSellStart
            // 
            this.dtpSellStart.Location = new System.Drawing.Point(496, 237);
            this.dtpSellStart.Size = new System.Drawing.Size(250, 20);
            this.dtpSellStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSellStart.TabIndex = 13;
            this.dtpSellStart.Name = "dtpSellStart";
            // 
            // lblSellEnd
            // 
            this.lblSellEnd.AutoSize = false;
            this.lblSellEnd.Location = new System.Drawing.Point(380, 270);
            this.lblSellEnd.Size = new System.Drawing.Size(110, 23);
            this.lblSellEnd.Text = "Sell end:";
            this.lblSellEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSellEnd.Name = "lblSellEnd";
            // 
            // dtpSellEnd
            // 
            this.dtpSellEnd.Location = new System.Drawing.Point(496, 271);
            this.dtpSellEnd.Size = new System.Drawing.Size(250, 20);
            this.dtpSellEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSellEnd.ShowCheckBox = true;
            this.dtpSellEnd.Checked = false;
            this.dtpSellEnd.TabIndex = 14;
            this.dtpSellEnd.Name = "dtpSellEnd";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = false;
            this.lblRequired.Location = new System.Drawing.Point(12, 324);
            this.lblRequired.Size = new System.Drawing.Size(120, 23);
            this.lblRequired.Text = "* = required";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRequired.Name = "lblRequired";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(297, 320);
            this.btnNew.Size = new System.Drawing.Size(85, 30);
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.TabIndex = 15;
            this.btnNew.Name = "btnNew";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 320);
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.TabIndex = 16;
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(479, 320);
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(570, 320);
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.TabIndex = 18;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 320);
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.TabIndex = 19;
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProductMaint
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(760, 366);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.cboResults);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblDiscontinued);
            this.Controls.Add(this.dtpDiscontinued);
            this.Controls.Add(this.lblStandardCost);
            this.Controls.Add(this.txtStandardCost);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.lblSellStart);
            this.Controls.Add(this.dtpSellStart);
            this.Controls.Add(this.lblSellEnd);
            this.Controls.Add(this.dtpSellEnd);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProductMaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Maintenance";
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.DateTimePicker dtpDiscontinued;
        private System.Windows.Forms.Label lblStandardCost;
        private System.Windows.Forms.TextBox txtStandardCost;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.Label lblSellStart;
        private System.Windows.Forms.DateTimePicker dtpSellStart;
        private System.Windows.Forms.Label lblSellEnd;
        private System.Windows.Forms.DateTimePicker dtpSellEnd;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
