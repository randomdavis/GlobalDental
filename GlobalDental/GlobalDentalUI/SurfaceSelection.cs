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
    public partial class SurfaceSelection : Form
    {
        public SurfaceSelection(MainWindow MainForm)
        {
            InitializeComponent();

            this.MainForm = MainForm;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var surfaces = new Model.Treatment.TreatmentSurfaces(false, BuccalCheckBox.Checked, DistalCheckBox.Checked, LingualCheckBox.Checked, MesialCheckBox.Checked, OcclusalCheckBox.Checked);
            if(surfaces.Buccal == false && surfaces.Distal == false && surfaces.Lingual == false && surfaces.Mesial == false && surfaces.Occlusal == false)
            {
                MessageBox.Show("At least one surface must be selected");
                return;
            }
            else
            {
                MainForm.selectedSurfaces = surfaces;
                Close();
            }
        }

        private MainWindow MainForm { get; set; }
    }
}
