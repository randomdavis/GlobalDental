using GlobalDentalClasses.Controller;
using System;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class SyncForm : Form
    {
        public SyncForm(SessionInfo Session, MainWindow MainForm)
        {
            InitializeComponent();

            this.Session = Session;
            this.MainForm = MainForm;
        }

        private MainWindow MainForm { get; set; }
        private SessionInfo Session { get; set; }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            SyncProgressBar.Enabled = true;
            SyncProgressBar.Value = 50;
            Cancel.Enabled = false;
            var syncWorked = Session.Sync(MainForm.Programs);
            Cancel.Enabled = true;
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
            SyncButton.Enabled = Session.loggedIn;
        }
    }
}
