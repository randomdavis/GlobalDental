namespace GlobalDentalUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInLogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ProgressNotesView = new System.Windows.Forms.TabControl();
            this.TreatmentPlanTab = new System.Windows.Forms.TabPage();
            this.NotesTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.ProgressNotesView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.selectPatientToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.editPatientToolStripMenuItem,
            this.logInLogOutToolStripMenuItem,
            this.syncToolStripMenuItem,
            this.closeChartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient...";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // selectPatientToolStripMenuItem
            // 
            this.selectPatientToolStripMenuItem.Name = "selectPatientToolStripMenuItem";
            this.selectPatientToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectPatientToolStripMenuItem.Text = "Select Patient...";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data...";
            // 
            // editPatientToolStripMenuItem
            // 
            this.editPatientToolStripMenuItem.Name = "editPatientToolStripMenuItem";
            this.editPatientToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.editPatientToolStripMenuItem.Text = "Edit Patient...";
            // 
            // logInLogOutToolStripMenuItem
            // 
            this.logInLogOutToolStripMenuItem.Enabled = false;
            this.logInLogOutToolStripMenuItem.Name = "logInLogOutToolStripMenuItem";
            this.logInLogOutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logInLogOutToolStripMenuItem.Text = "Log In/Log Out...";
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Enabled = false;
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.syncToolStripMenuItem.Text = "Sync...";
            // 
            // closeChartToolStripMenuItem
            // 
            this.closeChartToolStripMenuItem.Name = "closeChartToolStripMenuItem";
            this.closeChartToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeChartToolStripMenuItem.Text = "Close Chart";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ProgressNotesView
            // 
            this.ProgressNotesView.Controls.Add(this.TreatmentPlanTab);
            this.ProgressNotesView.Controls.Add(this.NotesTab);
            this.ProgressNotesView.Location = new System.Drawing.Point(12, 501);
            this.ProgressNotesView.Name = "ProgressNotesView";
            this.ProgressNotesView.SelectedIndex = 0;
            this.ProgressNotesView.Size = new System.Drawing.Size(893, 168);
            this.ProgressNotesView.TabIndex = 2;
            // 
            // TreatmentPlanTab
            // 
            this.TreatmentPlanTab.Location = new System.Drawing.Point(4, 22);
            this.TreatmentPlanTab.Name = "TreatmentPlanTab";
            this.TreatmentPlanTab.Padding = new System.Windows.Forms.Padding(3);
            this.TreatmentPlanTab.Size = new System.Drawing.Size(885, 142);
            this.TreatmentPlanTab.TabIndex = 0;
            this.TreatmentPlanTab.Text = "Treatment Plan";
            this.TreatmentPlanTab.UseVisualStyleBackColor = true;
            // 
            // NotesTab
            // 
            this.NotesTab.Location = new System.Drawing.Point(4, 22);
            this.NotesTab.Name = "NotesTab";
            this.NotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NotesTab.Size = new System.Drawing.Size(885, 142);
            this.NotesTab.TabIndex = 1;
            this.NotesTab.Text = "Notes";
            this.NotesTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ProgressNotesView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Global Dental © 2016 Random Davis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProgressNotesView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInLogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl ProgressNotesView;
        private System.Windows.Forms.TabPage TreatmentPlanTab;
        private System.Windows.Forms.TabPage NotesTab;
    }
}

