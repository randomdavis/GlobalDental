using System;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class SurfaceSelection : Form
    {
        public SurfaceSelection(MainWindow MainForm)
        {
            InitializeComponent();

            this.MainForm = MainForm;
            this.MainForm.Enabled = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var surfaces = new GlobalDentalUI.Model.Treatment.TreatmentSurfaces(false, BuccalCheckBox.Checked, DistalCheckBox.Checked, LingualCheckBox.Checked, MesialCheckBox.Checked, OcclusalCheckBox.Checked);
            if(surfaces.Buccal == false && surfaces.Distal == false && surfaces.Lingual == false && surfaces.Mesial == false && surfaces.Occlusal == false)
            {
                MessageBox.Show("At least one surface must be selected");
                return;
            }
            else
            {
                MainForm.selectedSurfaces = surfaces;
                MainForm.Enabled = true;
                Close();
            }
        }

        private MainWindow MainForm { get; set; }
    }
}
