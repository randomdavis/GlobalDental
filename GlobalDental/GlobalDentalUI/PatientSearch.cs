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
    public partial class PatientSearch : Form
    {
        public PatientSearch(GlobalDentalUI.Controller.DentalOutreachProgram DOP, MainWindow MainForm)
        {
            InitializeComponent();

            this.DOP = DOP;
            this.MainForm = MainForm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length > 0)
            {
                PatientList = new List<GlobalDentalUI.Model.Patient>();

                var searchText = SearchTextBox.Text;

                if (SearchTypeDropdown.SelectedIndex == 0)
                {
                    int PatientID;
                    try
                    {
                        PatientID = Convert.ToInt32(searchText);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("\"" + searchText + "\"" + " is not a valid Patient ID");
                        return;
                    }

                    var foundPatient = DOP.GetPatient(PatientID);

                    if (foundPatient != null)
                    {
                        PatientList.Add(foundPatient);
                    }
                }
                else if (searchText.Length > 0)
                {
                    PatientList = DOP.SearchPatients(searchText);
                }
                else
                {
                    PatientList = DOP.Patients;
                }

                Populate_List();
            }
            else
            {
                PatientList = DOP.Patients;
                Populate_List();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private GlobalDentalUI.Controller.DentalOutreachProgram DOP { get; set; }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (SelectedPatientID != null)
            {
                MainForm.SetSelectedPatient((int)SelectedPatientID);
                Close();
            }
            else
            {
                OpenButton.Enabled = false;
            }
        }

        private void PatientIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Populate_List()
        {
            PatientSearchResults.Rows.Clear();
            foreach (var Patient in PatientList)
            {
                PatientSearchResults.Rows.Add(Patient.FirstName, Patient.LastName, Patient.Birthdate.ToLocalTime().ToShortDateString(), Patient.PatientID.ToString());
            }

            foreach (DataGridViewRow Row in PatientSearchResults.Rows)
            {
                if (Row.Selected)
                {
                    SelectPatientAtRow(Row);
                    break;
                }
            }
        }

        private void PatientSearch_Load(object sender, EventArgs e)
        {
            SearchTypeDropdown.Items.Clear();
            SearchTypeDropdown.Items.Add("ID");
            SearchTypeDropdown.Items.Add("Name");
            SearchTypeDropdown.SelectedIndex = 1;
            OpenButton.Enabled = false;
            PatientSearchResults.Rows.Clear();
            PatientList = DOP.Patients;
            Populate_List();
        }

        private List<GlobalDentalUI.Model.Patient> PatientList { get; set; }

        private void SearchTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void PatientSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private MainWindow MainForm { get; set; }
        private int? SelectedPatientID { get; set; }

        private void PatientSearchResults_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void PatientSearchResults_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectPatientAtRow(DataGridViewRow Row)
        {
            var SelectedID = Row.Cells[3].Value;

            int ID;

            try
            {
                ID = Convert.ToInt32(SelectedID);
            }
            catch (Exception)
            {
                throw new Exception("Selected row had invalid patient ID of " + SelectedID.ToString());
            }

            SelectedPatientID = ID;

            OpenButton.Enabled = true;
        }

        private void PatientSearchResults_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Selected == false)
            {
                OpenButton.Enabled = false;
                SelectedPatientID = null;
            }
            else if (e.Row.Selected == true)
            {
                SelectPatientAtRow(e.Row);
            }
        }
    }
}
