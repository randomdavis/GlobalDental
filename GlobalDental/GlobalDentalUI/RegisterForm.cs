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
        public RegisterForm(DentalOutreachProgram DOP, MainWindow MainForm)
        {
            InitializeComponent();
            this.DOP = DOP;
            this.MainForm = MainForm;
        }

        public DentalOutreachProgram DOP { get; set; }
        public MainWindow MainForm { get; set; }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var RegisterResult = DOP.Register(email);
            Enabled = false;
            if (RegisterResult != "")
            {
                MessageBox.Show(RegisterResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registration Successful", "Registered", MessageBoxButtons.OK);
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
