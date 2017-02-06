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
    public partial class LogInForm : Form
    {
        public LogInForm(DentalOutreachProgram DOP, MainWindow MainForm)
        {
            InitializeComponent();
            this.DOP = DOP;
            this.MainForm = MainForm;
        }

        public DentalOutreachProgram DOP { get; set; }
        public MainWindow MainForm { get; set; }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var LoginResult = DOP.LogIn(email);
            if (LoginResult != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to use the server's stored data?", "Login Successful", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MainForm.DOP = LoginResult;
                    MainForm.Create_Odontogram();
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
