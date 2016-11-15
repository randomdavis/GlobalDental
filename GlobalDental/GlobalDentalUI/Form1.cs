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
            Title = "Global Dental © 2016 Random Davis";
            InitializeComponent();
            DOP = new DentalOutreachProgram();
            Model.Patient testpatient = DOP.AddPatient(DateTime.Now, "Johnny", "Appleseed", "Oregon", "USA", "John is kill\no", Model.Patient.Gender.Male);
            DOP.AddPatient(DateTime.Now, "Thompy", "Tearres", "Jefferton", "USA", "Tommy Boy", Model.Patient.Gender.Male);
            SelectedPatient = null;
            Text = Title;

            DOP.AddTreatment(testpatient.PatientID, Model.Treatment.TreatmentType.Amalgam, new Model.Treatment.TreatmentSurfaces(false, true, false, true, false, true), Model.Treatment.TreatmentStatus.Planned, 15);
            DOP.AddTreatment(testpatient.PatientID, Model.Treatment.TreatmentType.Composite, new Model.Treatment.TreatmentSurfaces(false, false, true, false, true, false), Model.Treatment.TreatmentStatus.Planned, 4);
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(DOP, this);
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
            var SelectPatientDialog = new PatientSearch(DOP, this);
            SelectPatientDialog.Show();
        }

        private void UpdateTreatmentPlanList()
        {
            TreatmentPlanDataTable.Rows.Clear();
            foreach (Model.Treatment Treatment in SelectedPatient.TreatmentsList)
            {
                TreatmentPlanDataTable.Rows.Add(Treatment.DateAndTime.ToLocalTime().ToString(), 
                    Treatment.TreatmentTooth.Number.USAToothNumber.ToString(), Treatment.SurfacesString(),
                    Treatment.Code(), Treatment.Type.ToString(), Treatment.Status.ToString());
            }
        }

        public void SetSelectedPatient(int ID)
        {
            SelectedPatient = DOP.GetPatient(ID);
            Text = Title + " - Patient " + SelectedPatient.LastName + ", " + SelectedPatient.FirstName + " (" + SelectedPatient.PatientID.ToString() + ")";
            UpdateTreatmentPlanList();
        }

        private Model.Patient SelectedPatient { get; set; }
        private string Title { get; set; }
    }
}
