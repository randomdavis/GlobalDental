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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInLogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShortcutToolStrip = new System.Windows.Forms.ToolStrip();
            this.ShortcutButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.ProphyButton = new System.Windows.Forms.Button();
            this.ShortcutTinyTable2 = new System.Windows.Forms.TableLayoutPanel();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.MissingButton = new System.Windows.Forms.Button();
            this.FluorideButton = new System.Windows.Forms.Button();
            this.ShortcutTinyTable1 = new System.Windows.Forms.TableLayoutPanel();
            this.TreatmentPlanButton = new System.Windows.Forms.Button();
            this.ExistingOtherButton = new System.Windows.Forms.Button();
            this.SealantsButton = new System.Windows.Forms.Button();
            this.AmalgamButton = new System.Windows.Forms.Button();
            this.ExtractionButton = new System.Windows.Forms.Button();
            this.CompositeButton = new System.Windows.Forms.Button();
            this.ProgressNotesView = new System.Windows.Forms.TabControl();
            this.TreatmentPlanTab = new System.Windows.Forms.TabPage();
            this.TreatmentPlanDataTable = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToothColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NotesTab = new System.Windows.Forms.TabPage();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.MainHorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenuStrip.SuspendLayout();
            this.ShortcutButtonTable.SuspendLayout();
            this.ShortcutTinyTable2.SuspendLayout();
            this.ShortcutTinyTable1.SuspendLayout();
            this.ProgressNotesView.SuspendLayout();
            this.TreatmentPlanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentPlanDataTable)).BeginInit();
            this.NotesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainHorizontalSplitContainer)).BeginInit();
            this.MainHorizontalSplitContainer.Panel1.SuspendLayout();
            this.MainHorizontalSplitContainer.Panel2.SuspendLayout();
            this.MainHorizontalSplitContainer.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(4, 4);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1000, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
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
            this.selectPatientToolStripMenuItem.Click += new System.EventHandler(this.selectPatientToolStripMenuItem_Click);
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
            // ShortcutToolStrip
            // 
            this.ShortcutToolStrip.Location = new System.Drawing.Point(4, 28);
            this.ShortcutToolStrip.Name = "ShortcutToolStrip";
            this.ShortcutToolStrip.Size = new System.Drawing.Size(1000, 25);
            this.ShortcutToolStrip.TabIndex = 1;
            this.ShortcutToolStrip.Text = "MainToolStrip";
            // 
            // ShortcutButtonTable
            // 
            this.ShortcutButtonTable.AutoSize = true;
            this.ShortcutButtonTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShortcutButtonTable.ColumnCount = 2;
            this.ShortcutButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutButtonTable.Controls.Add(this.ProphyButton, 1, 3);
            this.ShortcutButtonTable.Controls.Add(this.ShortcutTinyTable2, 1, 0);
            this.ShortcutButtonTable.Controls.Add(this.FluorideButton, 0, 3);
            this.ShortcutButtonTable.Controls.Add(this.ShortcutTinyTable1, 0, 0);
            this.ShortcutButtonTable.Controls.Add(this.SealantsButton, 1, 2);
            this.ShortcutButtonTable.Controls.Add(this.AmalgamButton, 0, 1);
            this.ShortcutButtonTable.Controls.Add(this.ExtractionButton, 0, 2);
            this.ShortcutButtonTable.Controls.Add(this.CompositeButton, 1, 1);
            this.ShortcutButtonTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShortcutButtonTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ShortcutButtonTable.Location = new System.Drawing.Point(793, 4);
            this.ShortcutButtonTable.MinimumSize = new System.Drawing.Size(0, 150);
            this.ShortcutButtonTable.Name = "ShortcutButtonTable";
            this.ShortcutButtonTable.RowCount = 4;
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.Size = new System.Drawing.Size(199, 150);
            this.ShortcutButtonTable.TabIndex = 3;
            // 
            // ProphyButton
            // 
            this.ProphyButton.AutoSize = true;
            this.ProphyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProphyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProphyButton.Location = new System.Drawing.Point(102, 114);
            this.ProphyButton.Name = "ProphyButton";
            this.ProphyButton.Size = new System.Drawing.Size(94, 33);
            this.ProphyButton.TabIndex = 7;
            this.ProphyButton.Text = "Pro";
            this.ProphyButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutTinyTable2
            // 
            this.ShortcutTinyTable2.AutoSize = true;
            this.ShortcutTinyTable2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShortcutTinyTable2.ColumnCount = 2;
            this.ShortcutTinyTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutTinyTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutTinyTable2.Controls.Add(this.CompleteButton, 0, 0);
            this.ShortcutTinyTable2.Controls.Add(this.MissingButton, 1, 0);
            this.ShortcutTinyTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutTinyTable2.Location = new System.Drawing.Point(99, 0);
            this.ShortcutTinyTable2.Margin = new System.Windows.Forms.Padding(0);
            this.ShortcutTinyTable2.Name = "ShortcutTinyTable2";
            this.ShortcutTinyTable2.RowCount = 1;
            this.ShortcutTinyTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShortcutTinyTable2.Size = new System.Drawing.Size(100, 37);
            this.ShortcutTinyTable2.TabIndex = 1;
            // 
            // CompleteButton
            // 
            this.CompleteButton.AutoSize = true;
            this.CompleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompleteButton.Location = new System.Drawing.Point(3, 3);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(44, 31);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "C";
            this.CompleteButton.UseVisualStyleBackColor = true;
            // 
            // MissingButton
            // 
            this.MissingButton.AutoSize = true;
            this.MissingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MissingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissingButton.Location = new System.Drawing.Point(53, 3);
            this.MissingButton.Name = "MissingButton";
            this.MissingButton.Size = new System.Drawing.Size(44, 31);
            this.MissingButton.TabIndex = 3;
            this.MissingButton.Text = "M";
            this.MissingButton.UseVisualStyleBackColor = true;
            // 
            // FluorideButton
            // 
            this.FluorideButton.AutoSize = true;
            this.FluorideButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FluorideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FluorideButton.Location = new System.Drawing.Point(3, 114);
            this.FluorideButton.Name = "FluorideButton";
            this.FluorideButton.Size = new System.Drawing.Size(93, 33);
            this.FluorideButton.TabIndex = 6;
            this.FluorideButton.Text = "FL";
            this.FluorideButton.UseVisualStyleBackColor = true;
            // 
            // ShortcutTinyTable1
            // 
            this.ShortcutTinyTable1.AutoSize = true;
            this.ShortcutTinyTable1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShortcutTinyTable1.ColumnCount = 2;
            this.ShortcutTinyTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutTinyTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ShortcutTinyTable1.Controls.Add(this.TreatmentPlanButton, 0, 0);
            this.ShortcutTinyTable1.Controls.Add(this.ExistingOtherButton, 1, 0);
            this.ShortcutTinyTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutTinyTable1.Location = new System.Drawing.Point(0, 0);
            this.ShortcutTinyTable1.Margin = new System.Windows.Forms.Padding(0);
            this.ShortcutTinyTable1.Name = "ShortcutTinyTable1";
            this.ShortcutTinyTable1.RowCount = 1;
            this.ShortcutTinyTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShortcutTinyTable1.Size = new System.Drawing.Size(99, 37);
            this.ShortcutTinyTable1.TabIndex = 0;
            // 
            // TreatmentPlanButton
            // 
            this.TreatmentPlanButton.AutoSize = true;
            this.TreatmentPlanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TreatmentPlanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentPlanButton.Location = new System.Drawing.Point(3, 3);
            this.TreatmentPlanButton.Name = "TreatmentPlanButton";
            this.TreatmentPlanButton.Size = new System.Drawing.Size(43, 31);
            this.TreatmentPlanButton.TabIndex = 0;
            this.TreatmentPlanButton.Text = "TX";
            this.TreatmentPlanButton.UseVisualStyleBackColor = true;
            // 
            // ExistingOtherButton
            // 
            this.ExistingOtherButton.AutoSize = true;
            this.ExistingOtherButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExistingOtherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistingOtherButton.Location = new System.Drawing.Point(52, 3);
            this.ExistingOtherButton.Name = "ExistingOtherButton";
            this.ExistingOtherButton.Size = new System.Drawing.Size(44, 31);
            this.ExistingOtherButton.TabIndex = 1;
            this.ExistingOtherButton.Text = "EO";
            this.ExistingOtherButton.UseVisualStyleBackColor = true;
            // 
            // SealantsButton
            // 
            this.SealantsButton.AutoSize = true;
            this.SealantsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SealantsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SealantsButton.Location = new System.Drawing.Point(102, 77);
            this.SealantsButton.Name = "SealantsButton";
            this.SealantsButton.Size = new System.Drawing.Size(94, 31);
            this.SealantsButton.TabIndex = 5;
            this.SealantsButton.Text = "Sealants";
            this.SealantsButton.UseVisualStyleBackColor = true;
            // 
            // AmalgamButton
            // 
            this.AmalgamButton.AutoSize = true;
            this.AmalgamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AmalgamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmalgamButton.Location = new System.Drawing.Point(3, 40);
            this.AmalgamButton.Name = "AmalgamButton";
            this.AmalgamButton.Size = new System.Drawing.Size(93, 31);
            this.AmalgamButton.TabIndex = 2;
            this.AmalgamButton.Text = "Amalgam";
            this.AmalgamButton.UseVisualStyleBackColor = true;
            // 
            // ExtractionButton
            // 
            this.ExtractionButton.AutoSize = true;
            this.ExtractionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExtractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtractionButton.Location = new System.Drawing.Point(3, 77);
            this.ExtractionButton.Name = "ExtractionButton";
            this.ExtractionButton.Size = new System.Drawing.Size(93, 31);
            this.ExtractionButton.TabIndex = 4;
            this.ExtractionButton.Text = "exo";
            this.ExtractionButton.UseVisualStyleBackColor = true;
            // 
            // CompositeButton
            // 
            this.CompositeButton.AutoSize = true;
            this.CompositeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompositeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompositeButton.Location = new System.Drawing.Point(102, 40);
            this.CompositeButton.Name = "CompositeButton";
            this.CompositeButton.Size = new System.Drawing.Size(94, 31);
            this.CompositeButton.TabIndex = 3;
            this.CompositeButton.Text = "Composite";
            this.CompositeButton.UseVisualStyleBackColor = true;
            // 
            // ProgressNotesView
            // 
            this.ProgressNotesView.Controls.Add(this.TreatmentPlanTab);
            this.ProgressNotesView.Controls.Add(this.NotesTab);
            this.ProgressNotesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressNotesView.Location = new System.Drawing.Point(0, 0);
            this.ProgressNotesView.MinimumSize = new System.Drawing.Size(0, 125);
            this.ProgressNotesView.Name = "ProgressNotesView";
            this.ProgressNotesView.SelectedIndex = 0;
            this.ProgressNotesView.Size = new System.Drawing.Size(996, 190);
            this.ProgressNotesView.TabIndex = 4;
            // 
            // TreatmentPlanTab
            // 
            this.TreatmentPlanTab.Controls.Add(this.TreatmentPlanDataTable);
            this.TreatmentPlanTab.Location = new System.Drawing.Point(4, 22);
            this.TreatmentPlanTab.Name = "TreatmentPlanTab";
            this.TreatmentPlanTab.Padding = new System.Windows.Forms.Padding(3);
            this.TreatmentPlanTab.Size = new System.Drawing.Size(988, 164);
            this.TreatmentPlanTab.TabIndex = 0;
            this.TreatmentPlanTab.Text = "Treatment Plan";
            this.TreatmentPlanTab.UseVisualStyleBackColor = true;
            // 
            // TreatmentPlanDataTable
            // 
            this.TreatmentPlanDataTable.AllowUserToAddRows = false;
            this.TreatmentPlanDataTable.AllowUserToDeleteRows = false;
            this.TreatmentPlanDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreatmentPlanDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.ToothColumn,
            this.SurfaceColumn,
            this.CodeColumn,
            this.DescriptionColumn,
            this.StatusColumn});
            this.TreatmentPlanDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentPlanDataTable.Location = new System.Drawing.Point(3, 3);
            this.TreatmentPlanDataTable.Name = "TreatmentPlanDataTable";
            this.TreatmentPlanDataTable.Size = new System.Drawing.Size(982, 158);
            this.TreatmentPlanDataTable.TabIndex = 0;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // ToothColumn
            // 
            this.ToothColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToothColumn.HeaderText = "Tooth";
            this.ToothColumn.Name = "ToothColumn";
            this.ToothColumn.ReadOnly = true;
            // 
            // SurfaceColumn
            // 
            this.SurfaceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurfaceColumn.HeaderText = "Surface";
            this.SurfaceColumn.Name = "SurfaceColumn";
            this.SurfaceColumn.ReadOnly = true;
            // 
            // CodeColumn
            // 
            this.CodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeColumn.HeaderText = "Code";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // NotesTab
            // 
            this.NotesTab.Controls.Add(this.NotesTextBox);
            this.NotesTab.Location = new System.Drawing.Point(4, 22);
            this.NotesTab.Name = "NotesTab";
            this.NotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NotesTab.Size = new System.Drawing.Size(988, 164);
            this.NotesTab.TabIndex = 1;
            this.NotesTab.Text = "Notes";
            this.NotesTab.UseVisualStyleBackColor = true;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(3, 3);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(982, 158);
            this.NotesTextBox.TabIndex = 0;
            this.NotesTextBox.Text = "";
            // 
            // MainHorizontalSplitContainer
            // 
            this.MainHorizontalSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainHorizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainHorizontalSplitContainer.Location = new System.Drawing.Point(4, 53);
            this.MainHorizontalSplitContainer.Name = "MainHorizontalSplitContainer";
            this.MainHorizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainHorizontalSplitContainer.Panel1
            // 
            this.MainHorizontalSplitContainer.Panel1.Controls.Add(this.TopTableLayout);
            this.MainHorizontalSplitContainer.Panel1MinSize = 125;
            // 
            // MainHorizontalSplitContainer.Panel2
            // 
            this.MainHorizontalSplitContainer.Panel2.Controls.Add(this.ProgressNotesView);
            this.MainHorizontalSplitContainer.Panel2MinSize = 125;
            this.MainHorizontalSplitContainer.Size = new System.Drawing.Size(1000, 672);
            this.MainHorizontalSplitContainer.SplitterDistance = 474;
            this.MainHorizontalSplitContainer.TabIndex = 5;
            // 
            // TopTableLayout
            // 
            this.TopTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TopTableLayout.ColumnCount = 2;
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.TopTableLayout.Controls.Add(this.ShortcutButtonTable, 1, 0);
            this.TopTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(0, 0);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 1;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.Size = new System.Drawing.Size(996, 470);
            this.TopTableLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 16;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 462);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.MainHorizontalSplitContainer);
            this.Controls.Add(this.ShortcutToolStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Global Dental © 2016 Random Davis";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ShortcutButtonTable.ResumeLayout(false);
            this.ShortcutButtonTable.PerformLayout();
            this.ShortcutTinyTable2.ResumeLayout(false);
            this.ShortcutTinyTable2.PerformLayout();
            this.ShortcutTinyTable1.ResumeLayout(false);
            this.ShortcutTinyTable1.PerformLayout();
            this.ProgressNotesView.ResumeLayout(false);
            this.TreatmentPlanTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TreatmentPlanDataTable)).EndInit();
            this.NotesTab.ResumeLayout(false);
            this.MainHorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.MainHorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainHorizontalSplitContainer)).EndInit();
            this.MainHorizontalSplitContainer.ResumeLayout(false);
            this.TopTableLayout.ResumeLayout(false);
            this.TopTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInLogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ShortcutToolStrip;
        private System.Windows.Forms.TabControl ProgressNotesView;
        private System.Windows.Forms.TabPage TreatmentPlanTab;
        private System.Windows.Forms.TabPage NotesTab;
        private System.Windows.Forms.TableLayoutPanel ShortcutButtonTable;
        private System.Windows.Forms.Button ProphyButton;
        private System.Windows.Forms.TableLayoutPanel ShortcutTinyTable2;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button MissingButton;
        private System.Windows.Forms.Button FluorideButton;
        private System.Windows.Forms.TableLayoutPanel ShortcutTinyTable1;
        private System.Windows.Forms.Button TreatmentPlanButton;
        private System.Windows.Forms.Button ExistingOtherButton;
        private System.Windows.Forms.Button SealantsButton;
        private System.Windows.Forms.Button AmalgamButton;
        private System.Windows.Forms.Button ExtractionButton;
        private System.Windows.Forms.Button CompositeButton;
        private System.Windows.Forms.SplitContainer MainHorizontalSplitContainer;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.DataGridView TreatmentPlanDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToothColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

