namespace GlobalDentalUI
{
    partial class EditTreatmentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTreatmentWindow));
            this.SaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToothNumberTextBox = new System.Windows.Forms.TextBox();
            this.InvalidText = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(119, 130);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Existing",
            "Planned",
            "Completed"});
            this.StatusComboBox.Location = new System.Drawing.Point(15, 26);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tooth";
            // 
            // ToothNumberTextBox
            // 
            this.ToothNumberTextBox.Enabled = false;
            this.ToothNumberTextBox.Location = new System.Drawing.Point(15, 66);
            this.ToothNumberTextBox.MaxLength = 2;
            this.ToothNumberTextBox.Name = "ToothNumberTextBox";
            this.ToothNumberTextBox.ReadOnly = true;
            this.ToothNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.ToothNumberTextBox.TabIndex = 8;
            this.ToothNumberTextBox.Text = "N/A";
            this.ToothNumberTextBox.TextChanged += new System.EventHandler(this.ToothNumberTextBox_TextChanged);
            // 
            // InvalidText
            // 
            this.InvalidText.AutoSize = true;
            this.InvalidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidText.ForeColor = System.Drawing.Color.Red;
            this.InvalidText.Location = new System.Drawing.Point(15, 93);
            this.InvalidText.Name = "InvalidText";
            this.InvalidText.Size = new System.Drawing.Size(129, 13);
            this.InvalidText.TabIndex = 9;
            this.InvalidText.Text = "Invalid Tooth Number";
            this.InvalidText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InvalidText.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(18, 130);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditTreatmentWindow
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 165);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InvalidText);
            this.Controls.Add(this.ToothNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTreatmentWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit Treatment";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditTreatmentWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToothNumberTextBox;
        private System.Windows.Forms.Label InvalidText;
        private System.Windows.Forms.Button DeleteButton;
    }
}