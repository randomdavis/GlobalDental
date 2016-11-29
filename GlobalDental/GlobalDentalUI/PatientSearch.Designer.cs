namespace GlobalDentalUI
{
    partial class PatientSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearch));
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTypeDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PatientSearchResults = new System.Windows.Forms.DataGridView();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 22);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(202, 20);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchTypeDropdown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 80);
            this.panel1.TabIndex = 4;
            // 
            // SearchTypeDropdown
            // 
            this.SearchTypeDropdown.FormattingEnabled = true;
            this.SearchTypeDropdown.Location = new System.Drawing.Point(220, 21);
            this.SearchTypeDropdown.Name = "SearchTypeDropdown";
            this.SearchTypeDropdown.Size = new System.Drawing.Size(84, 21);
            this.SearchTypeDropdown.TabIndex = 9;
            this.SearchTypeDropdown.Text = "Select One...";
            this.SearchTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.SearchTypeDropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(358, 21);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 7;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1MinSize = 80;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PatientSearchResults);
            this.splitContainer1.Size = new System.Drawing.Size(484, 461);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 6;
            // 
            // PatientSearchResults
            // 
            this.PatientSearchResults.AllowUserToAddRows = false;
            this.PatientSearchResults.AllowUserToDeleteRows = false;
            this.PatientSearchResults.AllowUserToOrderColumns = true;
            this.PatientSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastNameColumn,
            this.FirstNameColumn,
            this.DOBColumn,
            this.PatientIDColumn});
            this.PatientSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientSearchResults.Location = new System.Drawing.Point(0, 0);
            this.PatientSearchResults.Name = "PatientSearchResults";
            this.PatientSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientSearchResults.Size = new System.Drawing.Size(484, 377);
            this.PatientSearchResults.TabIndex = 0;
            this.PatientSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientSearchResults_CellClick);
            this.PatientSearchResults.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientSearchResults_CellLeave);
            this.PatientSearchResults.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.PatientSearchResults_CellStateChanged);
            this.PatientSearchResults.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.PatientSearchResults_RowStateChanged);
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastNameColumn.HeaderText = "Last Name";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstNameColumn.HeaderText = "First Name";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // DOBColumn
            // 
            this.DOBColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOBColumn.HeaderText = "DOB";
            this.DOBColumn.Name = "DOBColumn";
            this.DOBColumn.ReadOnly = true;
            // 
            // PatientIDColumn
            // 
            this.PatientIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientIDColumn.HeaderText = "ID";
            this.PatientIDColumn.Name = "PatientIDColumn";
            this.PatientIDColumn.ReadOnly = true;
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "PatientSearch";
            this.ShowInTaskbar = false;
            this.Text = "Patient Search";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientSearch_FormClosed);
            this.Load += new System.EventHandler(this.PatientSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView PatientSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOBColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientIDColumn;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchTypeDropdown;
    }
}