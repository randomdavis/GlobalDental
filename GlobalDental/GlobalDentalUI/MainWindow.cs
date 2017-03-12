using System;
using System.Drawing;
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

            CurrentDOP = null;
            Programs = new DOPs();
            Session = new SessionInfo();

            SelectedPatient = null;
            Text = Title;
            editPatientToolStripMenuItem.Enabled = false;
            ProgressNotesView.Enabled = false;
            OdontogramLayoutPanel.Enabled = false;
            ShortcutButtonTable.Enabled = false;
            newPatientToolStripMenuItem.Enabled = false;
            selectPatientToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = Session.loggedIn;

            Create_Odontogram();
            OdontogramLayoutPanel.Enabled = false;
        }

        public void setCurrentDOP(DentalOutreachProgram DOP)
        {
            Enabled = false;
            CurrentDOP = DOP;
            newPatientToolStripMenuItem.Enabled = true;
            selectPatientToolStripMenuItem.Enabled = true;
            DeselectPatient();
            Enabled = true;
        }

        public void unsetCurrentDOP()
        {
            Enabled = false;
            CurrentDOP = null;
            newPatientToolStripMenuItem.Enabled = false;
            selectPatientToolStripMenuItem.Enabled = false;
            DeselectPatient();
            Enabled = true;
        }

        public void Create_Odontogram()
        {
            if(CurrentDOP != null)
            {
                OdontogramLayoutPanel.Enabled = true;
                OdontogramLayoutPanel.Controls.Clear();

                for (int i = 1; i <= 16; i++)
                {
                    OdontogramLayoutPanel.Controls.Add(ToothPanel(i));
                }
                for (int i = 32; i >= 17; i--)
                {
                    OdontogramLayoutPanel.Controls.Add(ToothPanel(i));
                }
            }
            else
            {

            }
        }

        private Panel ToothPanel(int number)
        {
            var newPanel = new Panel();
            newPanel.Dock = DockStyle.Fill;
            var checkBox = new CheckBox();
            checkBox.Text = number.ToString();
            checkBox.Dock = DockStyle.Top;

            newPanel.Controls.Add(new OdontogramPanel(this, SelectedPatient, number));

            newPanel.Controls.Add(checkBox);

            return newPanel;
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(CurrentDOP, this);
            CreatePatientDialog.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        public SessionInfo Session { get; set; }
        public DOPs Programs { get; set; }
        public DentalOutreachProgram CurrentDOP { get; set; }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void selectPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var SelectPatientDialog = new PatientSearch(CurrentDOP, this);
            SelectPatientDialog.Show();
        }

        public void UpdateTreatmentPlanList()
        {
            TreatmentPlanDataTable.Rows.Clear();

            if(SelectedPatient != null)
            {
                foreach (Model.Treatment Treatment in SelectedPatient.TreatmentsList)
                {
                    string id = Treatment.ID.ToString();
                    string date = Treatment.DateAndTime.ToLocalTime().ToString();
                    string type = Treatment.Type.ToString();
                    string status = Treatment.Status.ToString();
                    string toothNumber;
                    string surfaces;
                    string code;

                    if (Treatment.ToothNumber != null)
                    {
                        toothNumber = Treatment.ToothNumber.ToString();
                        surfaces = Treatment.SurfacesString();
                        code = Treatment.Code();
                    }
                    else
                    {
                        toothNumber = "N/A";
                        surfaces = "N/A";
                        code = Treatment.Code(false);
                    }

                    TreatmentPlanDataTable.Rows.Add(id, date, toothNumber, surfaces, code, type, status);
                }
            }
            Create_Odontogram();
        }

        public void DeselectPatient()
        {
            SelectedPatient = null;
            Text = Title;
            UpdateTreatmentPlanList();
            editPatientToolStripMenuItem.Enabled = false;
            ProgressNotesView.Enabled = false;
            Create_Odontogram();
            OdontogramLayoutPanel.Enabled = false;
            ShortcutButtonTable.Enabled = false;
            NotesTextBox.Text = "";
        }

        public void SetSelectedPatient(int ID)
        {
            SelectedPatient = CurrentDOP.GetPatient(ID);
            Text = Title + " - Patient " + SelectedPatient.LastName + ", " + SelectedPatient.FirstName + " (" + SelectedPatient.PatientID.ToString() + ")";
            editPatientToolStripMenuItem.Enabled = true;
            ProgressNotesView.Enabled = true;
            ShortcutButtonTable.Enabled = true;
            UpdateTreatmentPlanList();
            NotesTextBox.Text = SelectedPatient.TreatmentNotes;
        }

        private Model.Patient SelectedPatient { get; set; }
        private string Title { get; set; }

        private void editPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(CurrentDOP, this, SelectedPatient.PatientID);
            CreatePatientDialog.Show();
        }

        private void closeChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeselectPatient();
        }

        private void MissingButton_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);
                if (cb.Checked == true)
                {
                    cb.Checked = false;
                    int toothNumber = Convert.ToInt32(cb.Text);
                    CurrentDOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Extraction, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Existing, toothNumber);
                }

                i++;
            }
            UpdateTreatmentPlanList();
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedPatient != null)
            {
                SelectedPatient.TreatmentNotes = NotesTextBox.Text;
            }
        }

        private void FluorideButton_Click(object sender, EventArgs e)
        {
            CurrentDOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Fluoride, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, 0);
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);
                if (cb.Checked == true)
                {
                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void ProphyButton_Click(object sender, EventArgs e)
        {
            CurrentDOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Prophylaxis, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, 0);
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);
                if (cb.Checked == true)
                {
                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void ExtractionButton_Click(object sender, EventArgs e)
        {
            
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);
                if (cb.Checked == true)
                {
                    int toothNumber = Convert.ToInt32(cb.Text);
                    CurrentDOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Extraction, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, toothNumber);
                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void AmalgamButton_Click(object sender, EventArgs e)
        {
            TreatmentShortcutWithSurface(Model.Treatment.TreatmentType.Amalgam);
        }

        private void TreatmentShortcutWithSurface(Model.Treatment.TreatmentType Type)
        {
            selectedSurfaces = null;
            SurfaceSelection ss = new SurfaceSelection(this);
            ss.ShowDialog();

            if (selectedSurfaces != null)
            {
                foreach (Panel p in OdontogramLayoutPanel.Controls)
                {
                    CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);
                    
                    if (cb.Checked == true)
                    {
                        int toothNumber = Convert.ToInt32(cb.Text);
                        CurrentDOP.AddTreatment(SelectedPatient.PatientID, Type, selectedSurfaces, Model.Treatment.TreatmentStatus.Planned, toothNumber);
                        cb.Checked = false;
                    }
                }
                UpdateTreatmentPlanList();
            }
            else
            {
                throw new Exception("No surfaces were selected");
            }
        }

        public Model.Treatment.TreatmentSurfaces selectedSurfaces { get; set; }

        private void CompositeButton_Click(object sender, EventArgs e)
        {
            TreatmentShortcutWithSurface(Model.Treatment.TreatmentType.Composite);
        }

        private void SealantsButton_Click(object sender, EventArgs e)
        {
            TreatmentShortcutWithSurface(Model.Treatment.TreatmentType.Sealants);
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);

                if (cb.Checked)
                {
                    int toothNumber = Convert.ToInt32(cb.Text);

                    CurrentDOP.CompleteTreatmentsOnTooth(SelectedPatient.PatientID, toothNumber);

                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void ExistingOtherButton_Click(object sender, EventArgs e)
        {
            foreach (Panel p in OdontogramLayoutPanel.Controls)
            {
                CheckBox cb = (CheckBox)(p.Controls[p.Controls.Count - 1]);

                if (cb.Checked == true)
                {
                    int toothNumber = Convert.ToInt32(cb.Text);

                    CurrentDOP.ExistingOtherOnTooth(SelectedPatient.PatientID, toothNumber);

                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Programs != null)
            {
                Programs.Serialize();
            }
        }

        private void TreatmentPlanDataTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void TreatmentPlanDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TreatmentPlanDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var EditTreatmentDialog = new EditTreatmentWindow(CurrentDOP, this, Convert.ToInt32(TreatmentPlanDataTable.Rows[e.RowIndex].Cells["ID"].Value), SelectedPatient.PatientID);
            EditTreatmentDialog.Show();
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SyncDialog = new SyncForm(Session, this);
            SyncDialog.Show();
        }

        public void updateLoginButtons()
        {
            logOutToolStripMenuItem.Enabled = Session.loggedIn;
            logInLogOutToolStripMenuItem.Enabled = !Session.loggedIn;
        }

        private void logInLogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var LoginDialog = new LogInForm(Session, this);
            LoginDialog.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var RegisterDialog = new RegisterForm(Session, this);
            RegisterDialog.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.LogOut();
            updateLoginButtons();
        }

        private void selectDentalOutreachProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DOPSelectDialog = new DOPSelectForm(this);
            DOPSelectDialog.Show();
        }

        private void createDentalOutreachProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DOPCreateDialog = new DOPCreateForm(this);
            DOPCreateDialog.Show();
        }
    }
}
