namespace GlobalDentalUI
{
    partial class SyncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.SyncButton = new System.Windows.Forms.Button();
            this.SyncProgressBar = new System.Windows.Forms.ProgressBar();
            this.SyncProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(12, 183);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(378, 183);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 23);
            this.SyncButton.TabIndex = 2;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // SyncProgressBar
            // 
            this.SyncProgressBar.Location = new System.Drawing.Point(12, 83);
            this.SyncProgressBar.Name = "SyncProgressBar";
            this.SyncProgressBar.Size = new System.Drawing.Size(441, 29);
            this.SyncProgressBar.TabIndex = 4;
            this.SyncProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SyncProgressLabel
            // 
            this.SyncProgressLabel.AutoSize = true;
            this.SyncProgressLabel.Location = new System.Drawing.Point(176, 136);
            this.SyncProgressLabel.Name = "SyncProgressLabel";
            this.SyncProgressLabel.Size = new System.Drawing.Size(118, 13);
            this.SyncProgressLabel.TabIndex = 5;
            this.SyncProgressLabel.Text = "Not Currently Syncing...";
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 218);
            this.Controls.Add(this.SyncProgressLabel);
            this.Controls.Add(this.SyncProgressBar);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SyncButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SyncForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sync With Server";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SyncForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.ProgressBar SyncProgressBar;
        private System.Windows.Forms.Label SyncProgressLabel;
    }
}