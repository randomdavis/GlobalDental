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
    public partial class DOPSelectForm : Form
    {
        public DOPSelectForm(MainWindow MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        public MainWindow MainForm { get; set; }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedDOP = MainForm.Programs.Programs[DOPsList.CurrentRow.Index];
            MainForm.setCurrentDOP(selectedDOP);
            MainForm.Enabled = true;
            Close();
        }

        private void DOPSelectForm_Load(object sender, EventArgs e)
        {
            DOPsList.Rows.Clear();
            Populate_List();
        }

        private void Populate_List()
        {
            DOPsList.Rows.Clear();
            foreach (var DOP in MainForm.Programs.Programs)
            {
                DOPsList.Rows.Add(DOP.Name,
                    DOP.StartDate.ToLocalTime().ToShortDateString(),
                    DOP.EndDate.ToLocalTime().ToShortDateString(),
                    DOP.Country,
                    DOP.Region);
            }
        }

        private void DOPsList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void DOPSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Enabled = true;
        }
    }
}
