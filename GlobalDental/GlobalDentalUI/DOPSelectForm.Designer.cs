namespace GlobalDentalUI
{
    partial class DOPSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOPSelectForm));
            this.DOPsList = new System.Windows.Forms.DataGridView();
            this.DOPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOPRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DOPsList)).BeginInit();
            this.SuspendLayout();
            // 
            // DOPsList
            // 
            this.DOPsList.AllowUserToAddRows = false;
            this.DOPsList.AllowUserToDeleteRows = false;
            this.DOPsList.AllowUserToResizeRows = false;
            this.DOPsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DOPsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOPName,
            this.StartDate,
            this.EndDate,
            this.Country,
            this.DOPRegion});
            this.DOPsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOPsList.Location = new System.Drawing.Point(0, 0);
            this.DOPsList.Name = "DOPsList";
            this.DOPsList.ReadOnly = true;
            this.DOPsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DOPsList.Size = new System.Drawing.Size(544, 361);
            this.DOPsList.TabIndex = 0;
            this.DOPsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.DOPsList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DOPsList_RowStateChanged);
            // 
            // DOPName
            // 
            this.DOPName.HeaderText = "Name";
            this.DOPName.Name = "DOPName";
            this.DOPName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // DOPRegion
            // 
            this.DOPRegion.HeaderText = "Region";
            this.DOPRegion.Name = "DOPRegion";
            this.DOPRegion.ReadOnly = true;
            // 
            // DOPSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.DOPsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(560, 1000);
            this.MinimumSize = new System.Drawing.Size(560, 400);
            this.Name = "DOPSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Double-Click to Select a Dental Outreach Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DOPSelectForm_FormClosed);
            this.Load += new System.EventHandler(this.DOPSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DOPsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DOPsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOPRegion;
    }
}