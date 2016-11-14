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
        public PatientSearch(GlobalDentalUI.Controller.DentalOutreachProgram DOP)
        {
            InitializeComponent();

            this.DOP = DOP;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length > 0)
            {
                //SearchButton.Enabled = true;
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

                    if (foundPatient == null)
                    {
                        return;
                    }
                    else
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
                    return;
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
    }
}
