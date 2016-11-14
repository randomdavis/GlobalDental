using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalDentalUI.Controller;

namespace GlobalDentalUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DOP = new DentalOutreachProgram();
            DOP.AddPatient(DateTime.Now, "Johnny", "Appleseed", "Oregon", "USA", "John is kill\no", Model.Patient.Gender.Male);
            DOP.AddPatient(DateTime.Now, "Thompy", "Tearres", "Jefferton", "USA", "Tommy Boy", Model.Patient.Gender.Male);
            SelectedPatient = null;
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(DOP);
            CreatePatientDialog.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private DentalOutreachProgram DOP { get; set; }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void selectPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectPatientDialog = new PatientSearch(DOP);
            SelectPatientDialog.Show();
        }

        private GlobalDentalUI.Model.Patient SelectedPatient { get; set; }
    }
}
