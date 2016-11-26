using System;
using System.Windows.Forms;
using GlobalDentalUI.Controller;
using GlobalDentalUI.Model;

namespace GlobalDentalUI
{
    public partial class CreateEditViewPatient : Form
    {
        public CreateEditViewPatient(DentalOutreachProgram DOP, MainWindow MainForm)
        {
            InitializeComponent();

            PatientID = null;

            PatientIDTextBox.Text = "N/A (New Patient)";

            this.DOP = DOP;
            this.MainForm = MainForm;
        }

        public CreateEditViewPatient(DentalOutreachProgram DOP, MainWindow MainForm, int ID)
        {
            InitializeComponent();

            PatientID = ID;

            this.DOP = DOP;

            var foundPatient = this.DOP.GetPatient(ID);

            if (foundPatient != null)
            {
                FirstNameTextBox.Text = foundPatient.FirstName;
                LastNameTextBox.Text = foundPatient.LastName;
                DOBPicker.Value = foundPatient.Birthdate.ToLocalTime();
                MaleButton.Checked = foundPatient.PatientGender == Patient.Gender.Male;
                FemaleButton.Checked = foundPatient.PatientGender == Patient.Gender.Female;
                RegionTextBox.Text = foundPatient.Region;
                CountryTextBox.Text = foundPatient.Country;
                PatientIDTextBox.Text = foundPatient.PatientID.ToString();
            }
            else
            {
                // Invalid Patient ID - Create a new patient
                PatientIDTextBox.Text = "N/A (New Patient)";
                PatientID = null;
            }

            this.MainForm = MainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private DentalOutreachProgram DOP { get; set; }
        private int? PatientID { get; set; }

        private MainWindow MainForm { get; set; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var newGender = Patient.Gender.Male;

            if (FemaleButton.Checked)
            {
                newGender = Patient.Gender.Female;
            }

            if (PatientID == null)
            {
                MainForm.SetSelectedPatient(DOP.AddPatient(DOBPicker.Value, FirstNameTextBox.Text, LastNameTextBox.Text, RegionTextBox.Text, CountryTextBox.Text, newGender).PatientID);
            }
            else
            {
                DOP.UpdatePatient((int)PatientID, DOBPicker.Value, FirstNameTextBox.Text, LastNameTextBox.Text, RegionTextBox.Text, CountryTextBox.Text, newGender);
            }

            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateEditViewPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
