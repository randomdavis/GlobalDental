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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerButton = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToothColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesTab = new System.Windows.Forms.TabPage();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.MainHorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OdontogramLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
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
            this.registerButton,
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
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newPatientToolStripMenuItem.Text = "New Patient...";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // selectPatientToolStripMenuItem
            // 
            this.selectPatientToolStripMenuItem.Name = "selectPatientToolStripMenuItem";
            this.selectPatientToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectPatientToolStripMenuItem.Text = "Select Patient...";
            this.selectPatientToolStripMenuItem.Click += new System.EventHandler(this.selectPatientToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data...";
            // 
            // editPatientToolStripMenuItem
            // 
            this.editPatientToolStripMenuItem.Name = "editPatientToolStripMenuItem";
            this.editPatientToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editPatientToolStripMenuItem.Text = "View/Edit Patient...";
            this.editPatientToolStripMenuItem.Click += new System.EventHandler(this.editPatientToolStripMenuItem_Click);
            // 
            // registerButton
            // 
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(173, 22);
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // logInLogOutToolStripMenuItem
            // 
            this.logInLogOutToolStripMenuItem.Name = "logInLogOutToolStripMenuItem";
            this.logInLogOutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.logInLogOutToolStripMenuItem.Text = "Log In/Log Out...";
            this.logInLogOutToolStripMenuItem.Click += new System.EventHandler(this.logInLogOutToolStripMenuItem_Click);
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.syncToolStripMenuItem.Text = "Sync...";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // closeChartToolStripMenuItem
            // 
            this.closeChartToolStripMenuItem.Name = "closeChartToolStripMenuItem";
            this.closeChartToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.closeChartToolStripMenuItem.Text = "Close Chart";
            this.closeChartToolStripMenuItem.Click += new System.EventHandler(this.closeChartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
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
            this.ShortcutButtonTable.Location = new System.Drawing.Point(778, 4);
            this.ShortcutButtonTable.MinimumSize = new System.Drawing.Size(0, 150);
            this.ShortcutButtonTable.Name = "ShortcutButtonTable";
            this.ShortcutButtonTable.RowCount = 4;
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ShortcutButtonTable.Size = new System.Drawing.Size(214, 150);
            this.ShortcutButtonTable.TabIndex = 3;
            // 
            // ProphyButton
            // 
            this.ProphyButton.AutoSize = true;
            this.ProphyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProphyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProphyButton.Location = new System.Drawing.Point(110, 114);
            this.ProphyButton.Name = "ProphyButton";
            this.ProphyButton.Size = new System.Drawing.Size(101, 33);
            this.ProphyButton.TabIndex = 7;
            this.ProphyButton.Text = "Pro";
            this.ProphyButton.UseVisualStyleBackColor = true;
            this.ProphyButton.Click += new System.EventHandler(this.ProphyButton_Click);
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
            this.ShortcutTinyTable2.Location = new System.Drawing.Point(107, 0);
            this.ShortcutTinyTable2.Margin = new System.Windows.Forms.Padding(0);
            this.ShortcutTinyTable2.Name = "ShortcutTinyTable2";
            this.ShortcutTinyTable2.RowCount = 1;
            this.ShortcutTinyTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ShortcutTinyTable2.Size = new System.Drawing.Size(107, 37);
            this.ShortcutTinyTable2.TabIndex = 1;
            // 
            // CompleteButton
            // 
            this.CompleteButton.AutoSize = true;
            this.CompleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompleteButton.Location = new System.Drawing.Point(3, 3);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(47, 31);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "C";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // MissingButton
            // 
            this.MissingButton.AutoSize = true;
            this.MissingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MissingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissingButton.Location = new System.Drawing.Point(56, 3);
            this.MissingButton.Name = "MissingButton";
            this.MissingButton.Size = new System.Drawing.Size(48, 31);
            this.MissingButton.TabIndex = 3;
            this.MissingButton.Text = "M";
            this.MissingButton.UseVisualStyleBackColor = true;
            this.MissingButton.Click += new System.EventHandler(this.MissingButton_Click);
            // 
            // FluorideButton
            // 
            this.FluorideButton.AutoSize = true;
            this.FluorideButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FluorideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FluorideButton.Location = new System.Drawing.Point(3, 114);
            this.FluorideButton.Name = "FluorideButton";
            this.FluorideButton.Size = new System.Drawing.Size(101, 33);
            this.FluorideButton.TabIndex = 6;
            this.FluorideButton.Text = "FL";
            this.FluorideButton.UseVisualStyleBackColor = true;
            this.FluorideButton.Click += new System.EventHandler(this.FluorideButton_Click);
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
            this.ShortcutTinyTable1.Size = new System.Drawing.Size(107, 37);
            this.ShortcutTinyTable1.TabIndex = 0;
            // 
            // TreatmentPlanButton
            // 
            this.TreatmentPlanButton.AutoSize = true;
            this.TreatmentPlanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TreatmentPlanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentPlanButton.Enabled = false;
            this.TreatmentPlanButton.Location = new System.Drawing.Point(3, 3);
            this.TreatmentPlanButton.Name = "TreatmentPlanButton";
            this.TreatmentPlanButton.Size = new System.Drawing.Size(47, 31);
            this.TreatmentPlanButton.TabIndex = 0;
            this.TreatmentPlanButton.Text = "TX";
            this.TreatmentPlanButton.UseVisualStyleBackColor = true;
            // 
            // ExistingOtherButton
            // 
            this.ExistingOtherButton.AutoSize = true;
            this.ExistingOtherButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExistingOtherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistingOtherButton.Location = new System.Drawing.Point(56, 3);
            this.ExistingOtherButton.Name = "ExistingOtherButton";
            this.ExistingOtherButton.Size = new System.Drawing.Size(48, 31);
            this.ExistingOtherButton.TabIndex = 1;
            this.ExistingOtherButton.Text = "EO";
            this.ExistingOtherButton.UseVisualStyleBackColor = true;
            this.ExistingOtherButton.Click += new System.EventHandler(this.ExistingOtherButton_Click);
            // 
            // SealantsButton
            // 
            this.SealantsButton.AutoSize = true;
            this.SealantsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SealantsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SealantsButton.Location = new System.Drawing.Point(110, 77);
            this.SealantsButton.Name = "SealantsButton";
            this.SealantsButton.Size = new System.Drawing.Size(101, 31);
            this.SealantsButton.TabIndex = 5;
            this.SealantsButton.Text = "Sealants";
            this.SealantsButton.UseVisualStyleBackColor = true;
            this.SealantsButton.Click += new System.EventHandler(this.SealantsButton_Click);
            // 
            // AmalgamButton
            // 
            this.AmalgamButton.AutoSize = true;
            this.AmalgamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AmalgamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmalgamButton.Location = new System.Drawing.Point(3, 40);
            this.AmalgamButton.Name = "AmalgamButton";
            this.AmalgamButton.Size = new System.Drawing.Size(101, 31);
            this.AmalgamButton.TabIndex = 2;
            this.AmalgamButton.Text = "Amalgam";
            this.AmalgamButton.UseVisualStyleBackColor = true;
            this.AmalgamButton.Click += new System.EventHandler(this.AmalgamButton_Click);
            // 
            // ExtractionButton
            // 
            this.ExtractionButton.AutoSize = true;
            this.ExtractionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExtractionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtractionButton.Location = new System.Drawing.Point(3, 77);
            this.ExtractionButton.Name = "ExtractionButton";
            this.ExtractionButton.Size = new System.Drawing.Size(101, 31);
            this.ExtractionButton.TabIndex = 4;
            this.ExtractionButton.Text = "exo";
            this.ExtractionButton.UseVisualStyleBackColor = true;
            this.ExtractionButton.Click += new System.EventHandler(this.ExtractionButton_Click);
            // 
            // CompositeButton
            // 
            this.CompositeButton.AutoSize = true;
            this.CompositeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompositeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompositeButton.Location = new System.Drawing.Point(110, 40);
            this.CompositeButton.Name = "CompositeButton";
            this.CompositeButton.Size = new System.Drawing.Size(101, 31);
            this.CompositeButton.TabIndex = 3;
            this.CompositeButton.Text = "Composite";
            this.CompositeButton.UseVisualStyleBackColor = true;
            this.CompositeButton.Click += new System.EventHandler(this.CompositeButton_Click);
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
            this.TreatmentPlanDataTable.AllowUserToResizeRows = false;
            this.TreatmentPlanDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TreatmentPlanDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DateColumn,
            this.ToothColumn,
            this.SurfaceColumn,
            this.CodeColumn,
            this.DescriptionColumn,
            this.StatusColumn});
            this.TreatmentPlanDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentPlanDataTable.Location = new System.Drawing.Point(3, 3);
            this.TreatmentPlanDataTable.MultiSelect = false;
            this.TreatmentPlanDataTable.Name = "TreatmentPlanDataTable";
            this.TreatmentPlanDataTable.ReadOnly = true;
            this.TreatmentPlanDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TreatmentPlanDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TreatmentPlanDataTable.Size = new System.Drawing.Size(982, 158);
            this.TreatmentPlanDataTable.TabIndex = 0;
            this.TreatmentPlanDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TreatmentPlanDataTable_CellContentClick);
            this.TreatmentPlanDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TreatmentPlanDataTable_CellDoubleClick);
            this.TreatmentPlanDataTable.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.TreatmentPlanDataTable_RowStateChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            this.StatusColumn.ReadOnly = true;
            this.StatusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.NotesTextBox.TextChanged += new System.EventHandler(this.NotesTextBox_TextChanged);
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
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.TopTableLayout.Controls.Add(this.ShortcutButtonTable, 1, 0);
            this.TopTableLayout.Controls.Add(this.OdontogramLayoutPanel, 0, 0);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(0, 0);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 1;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.Size = new System.Drawing.Size(996, 470);
            this.TopTableLayout.TabIndex = 0;
            // 
            // OdontogramLayoutPanel
            // 
            this.OdontogramLayoutPanel.ColumnCount = 16;
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.OdontogramLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OdontogramLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.OdontogramLayoutPanel.Name = "OdontogramLayoutPanel";
            this.OdontogramLayoutPanel.RowCount = 2;
            this.OdontogramLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OdontogramLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OdontogramLayoutPanel.Size = new System.Drawing.Size(767, 462);
            this.OdontogramLayoutPanel.TabIndex = 4;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataSource = typeof(GlobalDentalUI.Model.Treatment);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel OdontogramLayoutPanel;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToothColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.ToolStripMenuItem registerButton;
    }
}

