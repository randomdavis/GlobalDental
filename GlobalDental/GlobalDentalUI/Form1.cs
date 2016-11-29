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

            DOP = new DentalOutreachProgram();

            try
            {
                DOP = DOP.Deserialize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                DOP = new DentalOutreachProgram();
                Model.Patient testpatient = DOP.AddPatient(DateTime.Now, "Johnny", "Appleseed", "Oregon", "USA", Model.Patient.Gender.Male);
                DOP.AddPatient(DateTime.Now, "Tom", "Peters", "Jefferton", "USA", Model.Patient.Gender.Male);
                DOP.AddPatient(DateTime.Now, "Tommy", "Wiseau", "San Francisco", "USA", Model.Patient.Gender.Male);
                DOP.AddPatient(DateTime.Now, "Lisa", "Wiseau", "San Francisco", "USA", Model.Patient.Gender.Female);
                DOP.AddTreatment(testpatient.PatientID, Model.Treatment.TreatmentType.Amalgam, new Model.Treatment.TreatmentSurfaces(false, true, false, true, false, true), Model.Treatment.TreatmentStatus.Planned, 15);
                DOP.AddTreatment(testpatient.PatientID, Model.Treatment.TreatmentType.Composite, new Model.Treatment.TreatmentSurfaces(false, false, true, false, true, false), Model.Treatment.TreatmentStatus.Planned, 4);
                DOP.Serialize();
            }

            SelectedPatient = null;
            Text = Title;
            editPatientToolStripMenuItem.Enabled = false;
            ProgressNotesView.Enabled = false;
            closeChartToolStripMenuItem.Enabled = false;
            exportDataToolStripMenuItem.Enabled = false;
            OdontogramLayoutPanel.Enabled = false;
            ShortcutButtonTable.Enabled = false;

            Create_Odontogram();
            OdontogramLayoutPanel.Enabled = false;
            
        }

        private void Create_Odontogram()
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

        private Panel ToothPanel(int number)
        {
            var newPanel = new Panel();
            newPanel.Dock = DockStyle.Fill;
            var checkBox = new CheckBox();
            checkBox.Text = number.ToString();
            checkBox.Dock = DockStyle.Top;


            /*string[] surfaces = { "O", "M", "L", "D", "B" };

            foreach (string label in surfaces)
            {
                var newLabel = new Label();
                newLabel.Text = label;
                newLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                newLabel.ForeColor = Color.Black;
                newLabel.Dock = DockStyle.Top;
                newPanel.Controls.Add(newLabel);
            }*/

            newPanel.Controls.Add(new OdontogramPanel(this, DOP, SelectedPatient, number));

            newPanel.Controls.Add(checkBox);

            return newPanel;
        }

        

        public void Update_Odontogram()
        {
            Create_Odontogram();
            /*if (SelectedPatient != null)
            {
                foreach (Model.Treatment Treatment in SelectedPatient.TreatmentsList)
                {
                    if (Treatment.ToothNumber == null || Treatment.ToothNumber < 1 || Treatment.ToothNumber > 32)
                    {
                        continue;
                    }
                    Panel panel = (Panel)OdontogramLayoutPanel.Controls[(int)Treatment.ToothNumber - 1];
                    Color setColor = StatusToColor(Treatment.Status);

                    if (Treatment.Type == Model.Treatment.TreatmentType.Extraction && (Treatment.Status == Model.Treatment.TreatmentStatus.Completed || Treatment.Status == Model.Treatment.TreatmentStatus.Existing))
                    {
                        panel.Enabled = false;
                    }
                    else if (Treatment.Type == Model.Treatment.TreatmentType.Extraction || Treatment.Type == Model.Treatment.TreatmentType.Amalgam || Treatment.Type == Model.Treatment.TreatmentType.Composite || Treatment.Type == Model.Treatment.TreatmentType.Sealants)
                    {
                        if (Treatment.Surfaces.Buccal == true)
                        {
                            panel.Controls[4].ForeColor = setColor;
                        }
                        if (Treatment.Surfaces.Distal == true)
                        {
                            panel.Controls[3].ForeColor = setColor;
                        }
                        if (Treatment.Surfaces.Lingual == true)
                        {
                            panel.Controls[2].ForeColor = setColor;
                        }
                        if (Treatment.Surfaces.Mesial == true)
                        {
                            panel.Controls[1].ForeColor = setColor;
                        }
                        if (Treatment.Surfaces.Occlusal == true)
                        {
                            panel.Controls[0].ForeColor = setColor;
                        }
                    }
                    else if (Treatment.Type == Model.Treatment.TreatmentType.Extraction)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            panel.Controls[i].ForeColor = setColor;
                        }
                    }
                }
            }*/

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(DOP, this);
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

        private DentalOutreachProgram DOP { get; set; }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void selectPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var SelectPatientDialog = new PatientSearch(DOP, this);
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
            Update_Odontogram();
        }

        public void DeselectPatient()
        {
            SelectedPatient = null;
            Text = Title;
            UpdateTreatmentPlanList();
            editPatientToolStripMenuItem.Enabled = false;
            ProgressNotesView.Enabled = false;
            closeChartToolStripMenuItem.Enabled = false;
            Create_Odontogram();
            OdontogramLayoutPanel.Enabled = false;
            ShortcutButtonTable.Enabled = false;
            NotesTextBox.Text = "";
        }

        public void SetSelectedPatient(int ID)
        {
            SelectedPatient = DOP.GetPatient(ID);
            Text = Title + " - Patient " + SelectedPatient.LastName + ", " + SelectedPatient.FirstName + " (" + SelectedPatient.PatientID.ToString() + ")";
            editPatientToolStripMenuItem.Enabled = true;
            ProgressNotesView.Enabled = true;
            ShortcutButtonTable.Enabled = true;
            Create_Odontogram();
            UpdateTreatmentPlanList();
            NotesTextBox.Text = SelectedPatient.TreatmentNotes;
        }

        private Model.Patient SelectedPatient { get; set; }
        private string Title { get; set; }

        private void editPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CreatePatientDialog = new CreateEditViewPatient(DOP, this, SelectedPatient.PatientID);
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
                    DOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Extraction, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Existing, toothNumber);
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
            DOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Fluoride, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, 0);
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
            DOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Prophylaxis, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, 0);
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
                    DOP.AddTreatment(SelectedPatient.PatientID, Model.Treatment.TreatmentType.Extraction, new Model.Treatment.TreatmentSurfaces(true), Model.Treatment.TreatmentStatus.Planned, toothNumber);
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
                        DOP.AddTreatment(SelectedPatient.PatientID, Type, selectedSurfaces, Model.Treatment.TreatmentStatus.Planned, toothNumber);
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

                    DOP.CompleteTreatmentsOnTooth(SelectedPatient.PatientID, toothNumber);

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

                    DOP.ExistingOtherOnTooth(SelectedPatient.PatientID, toothNumber);

                    cb.Checked = false;
                }
            }
            UpdateTreatmentPlanList();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DOP.Serialize();
        }

        private void TreatmentPlanDataTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void TreatmentPlanDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TreatmentPlanDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var EditTreatmentDialog = new EditTreatmentWindow(DOP, this, Convert.ToInt32(TreatmentPlanDataTable.Rows[e.RowIndex].Cells["ID"].Value), SelectedPatient.PatientID);
            EditTreatmentDialog.Show();
        }
    }
}
