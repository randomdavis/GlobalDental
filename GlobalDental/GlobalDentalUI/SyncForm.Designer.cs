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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SyncButton = new System.Windows.Forms.Button();
            this.SyncProgressBar = new System.Windows.Forms.ProgressBar();
            this.SyncProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SyncButton
            // 
            this.SyncButton.Location = new System.Drawing.Point(378, 183);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 23);
            this.SyncButton.TabIndex = 2;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SyncButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SyncForm";
            this.ShowInTaskbar = false;
            this.Text = "Sync With Server";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.ProgressBar SyncProgressBar;
        private System.Windows.Forms.Label SyncProgressLabel;
    }
}