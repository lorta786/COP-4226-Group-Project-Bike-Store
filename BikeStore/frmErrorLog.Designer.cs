namespace BikeStore
{
    partial class frmErrorLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mtxtStartTime = new MaskedTextBox();
            mtxtEndTime = new MaskedTextBox();
            btnSearch = new Button();
            btnClear = new Button();
            label7 = new Label();
            grpErrorDetails = new GroupBox();
            dgvErrorLogs = new DataGridView();
            colErrorLogID = new DataGridViewTextBoxColumn();
            colErrorDate = new DataGridViewTextBoxColumn();
            colErrorMessage = new DataGridViewTextBoxColumn();
            grpErrorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErrorLogs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Error Log User Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 1;
            label2.Text = "Filter by Date and Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(12, 135);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(12, 198);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 112);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 6;
            label5.Text = "Start Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 175);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 7;
            label6.Text = "End Time";
            // 
            // mtxtStartTime
            // 
            mtxtStartTime.Location = new Point(286, 135);
            mtxtStartTime.Mask = "90:00";
            mtxtStartTime.Name = "mtxtStartTime";
            mtxtStartTime.Size = new Size(125, 27);
            mtxtStartTime.TabIndex = 8;
            mtxtStartTime.ValidatingType = typeof(DateTime);
            // 
            // mtxtEndTime
            // 
            mtxtEndTime.Location = new Point(286, 200);
            mtxtEndTime.Mask = "90:00";
            mtxtEndTime.Name = "mtxtEndTime";
            mtxtEndTime.Size = new Size(125, 27);
            mtxtEndTime.TabIndex = 9;
            mtxtEndTime.ValidatingType = typeof(DateTime);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(113, 231);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(213, 231);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 278);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 12;
            label7.Text = "Error Records";
            // 
            // grpErrorDetails
            // 
            grpErrorDetails.Controls.Add(dgvErrorLogs);
            grpErrorDetails.Location = new Point(15, 303);
            grpErrorDetails.Name = "grpErrorDetails";
            grpErrorDetails.Size = new Size(541, 230);
            grpErrorDetails.TabIndex = 13;
            grpErrorDetails.TabStop = false;
            grpErrorDetails.Text = "ko";
            // 
            // dgvErrorLogs
            // 
            dgvErrorLogs.AllowUserToDeleteRows = false;
            dgvErrorLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvErrorLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrorLogs.Columns.AddRange(new DataGridViewColumn[] { colErrorLogID, colErrorDate, colErrorMessage });
            dgvErrorLogs.Location = new Point(20, 26);
            dgvErrorLogs.MultiSelect = false;
            dgvErrorLogs.Name = "dgvErrorLogs";
            dgvErrorLogs.RowHeadersWidth = 51;
            dgvErrorLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvErrorLogs.Size = new Size(501, 188);
            dgvErrorLogs.TabIndex = 0;
            // 
            // colErrorLogID
            // 
            colErrorLogID.DataPropertyName = "ErrorLogID";
            colErrorLogID.HeaderText = "Error ID";
            colErrorLogID.MinimumWidth = 6;
            colErrorLogID.Name = "colErrorLogID";
            // 
            // colErrorDate
            // 
            colErrorDate.DataPropertyName = "ErrorDate";
            colErrorDate.HeaderText = "Error Date";
            colErrorDate.MinimumWidth = 6;
            colErrorDate.Name = "colErrorDate";
            // 
            // colErrorMessage
            // 
            colErrorMessage.DataPropertyName = "ErrorLogID";
            colErrorMessage.HeaderText = "Error Message";
            colErrorMessage.MinimumWidth = 6;
            colErrorMessage.Name = "colErrorMessage";
            // 
            // frmErrorLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(grpErrorDetails);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(mtxtEndTime);
            Controls.Add(mtxtStartTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpEndDate);
            Controls.Add(label4);
            Controls.Add(dtpStartDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmErrorLog";
            Text = "Error Log";
            Load += frmErrorLog_Load;
            grpErrorDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvErrorLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox mtxtStartTime;
        private MaskedTextBox mtxtEndTime;
        private Button btnSearch;
        private Button btnClear;
        private Label label7;
        private GroupBox grpErrorDetails;
        private DataGridView dgvErrorLogs;
        private DataGridViewTextBoxColumn colErrorLogID;
        private DataGridViewTextBoxColumn colErrorDate;
        private DataGridViewTextBoxColumn colErrorMessage;
    }
}