using GlobalDentalUI.Controller;
using GlobalDentalUI.Model;
using System;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class EditTreatmentWindow : Form
    {
        public EditTreatmentWindow(DentalOutreachProgram DOP, MainWindow MainForm, int TreatmentID, int PatientID)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.TreatmentID = TreatmentID;
            this.PatientID = PatientID;
            EditingTreatment = DOP.GetTreatment(this.TreatmentID, this.PatientID);
            
            this.DOP = DOP;
            InvalidText.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private MainWindow MainForm { get; set; }
        private int TreatmentID { get; set; }
        private int PatientID { get; set; }

        private Treatment EditingTreatment { get; set; }

        private DentalOutreachProgram DOP { get; set; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int? toothNumberToSet;
            if (ToothNumberTextBox.ReadOnly == true)
            {
                toothNumberToSet = null;
            }
            else
            {
                toothNumberToSet = Convert.ToInt32(ToothNumberTextBox.Text);
            }

            Treatment.TreatmentStatus Status;

            switch (StatusComboBox.Text)
            {
                case "Planned":
                    Status = Treatment.TreatmentStatus.Planned;
                    break;
                case "Completed":
                    Status = Treatment.TreatmentStatus.Completed;
                    break;
                case "Existing":
                    Status = Treatment.TreatmentStatus.Existing;
                    break;
                default:
                    throw new Exception("Unknown status of " + StatusComboBox.Text);
            }

            DOP.UpdateTreatment(PatientID, TreatmentID, Status, toothNumberToSet);

            MainForm.UpdateTreatmentPlanList();

            Close();
        }

        private void ToothNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int enteredNumber;

            try
            {
                enteredNumber = Convert.ToInt32(ToothNumberTextBox.Text);
            }
            catch (Exception)
            {
                enteredNumber = 0;
            }

            if(enteredNumber < 1 || enteredNumber > 32)
            {
                SaveButton.Enabled = false;
                InvalidText.Visible = true;
            }
            else
            {
                SaveButton.Enabled = true;
                InvalidText.Visible = false;
            }

        }

        private void EditTreatmentWindow_Load(object sender, EventArgs e)
        {
            StatusComboBox.SelectedText = EditingTreatment.Status.ToString();
            if (EditingTreatment.ToothNumber != null)
            {
                ToothNumberTextBox.Text = EditingTreatment.ToothNumber.ToString();
                ToothNumberTextBox.ReadOnly = false;
                ToothNumberTextBox.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DOP.DeleteTreatment(PatientID, TreatmentID);
            MainForm.UpdateTreatmentPlanList();
            Close();
        }
    }
}
