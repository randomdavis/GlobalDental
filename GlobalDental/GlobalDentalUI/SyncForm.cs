using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class SyncForm : Form
    {
        public SyncForm(GlobalDentalUI.Controller.DentalOutreachProgram DOP, MainWindow MainForm)
        {
            InitializeComponent();

            this.DOP = DOP;
            this.MainForm = MainForm;
        }

        private MainWindow MainForm { get; set; }
        private Controller.DentalOutreachProgram DOP { get; set; }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            SyncProgressBar.Enabled = true;
            SyncProgressBar.Value = 50;
            CancelButton.Enabled = false;
            var syncWorked = DOP.Sync();
            CancelButton.Enabled = true;
            if (syncWorked)
            {
                SyncProgressBar.Value = 100;
                MessageBox.Show("Sync Complete");
            }
            else
            {
                SyncProgressBar.Value = 0;
                MessageBox.Show("Sync Failed");
            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            SyncProgressBar.Enabled = false;
        }
    }
}
