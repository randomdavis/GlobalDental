using GlobalDentalUI.Controller;
using System;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class LogInForm : Form
    {
        public LogInForm(SessionInfo Session, MainWindow MainForm)
        {
            InitializeComponent();
            this.Session = Session;
            this.MainForm = MainForm;
        }

        public SessionInfo Session { get; set; }
        public MainWindow MainForm { get; set; }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var LoginResult = Session.LogIn(email);
            if (LoginResult != null)
            {
                MainForm.updateLoginButtons();
                DialogResult dialogResult = MessageBox.Show("Do you want to use the server's stored data?", "Login Successful", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MainForm.Programs.Programs = LoginResult;
                    MainForm.unsetCurrentDOP();
                    MainForm.Create_Odontogram();
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Could not log in with that email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
