using GlobalDentalUI.Controller;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm(SessionInfo Session, MainWindow MainForm)
        {
            InitializeComponent();
            this.Session = Session;
            this.MainForm = MainForm;
        }

        public SessionInfo Session { get; set; }
        public MainWindow MainForm { get; set; }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var RegisterResult = Session.Register(email);
            Enabled = false;
            if (RegisterResult != "")
            {
                MessageBox.Show(RegisterResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Enabled = true;
            }
            else
            {
                MessageBox.Show("Registration Successful", "Registered", MessageBoxButtons.OK);
                MainForm.updateLoginButtons();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
