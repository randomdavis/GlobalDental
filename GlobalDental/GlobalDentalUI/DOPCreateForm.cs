using GlobalDentalClasses.Controller;
using System;
using System.Windows.Forms;

namespace GlobalDentalUI
{
    public partial class DOPCreateForm : Form
    {
        public DOPCreateForm(MainWindow MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.MainForm.Enabled = false;
            CreateButton.Enabled = false;
        }

        public MainWindow MainForm { get; set; }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainForm.Enabled = true;
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var newDOP = new DentalOutreachProgram(startDatePicker.Value,
                endDatePicker.Value, RegionTextBox.Text, CountryTextBox.Text, NameTextBox.Text);

            MainForm.Programs.Programs.Add(newDOP);
            MainForm.unsetCurrentDOP();
            MainForm.setCurrentDOP(newDOP);
            MainForm.DeselectPatient();
            MainForm.Enabled = true;
            Close();
        }

        private void setCreateButtonEnabled()
        {
            CreateButton.Enabled = NameTextBox.Text.Length > 0 && CountryTextBox.Text.Length > 0 && RegionTextBox.Text.Length > 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setCreateButtonEnabled();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            setCreateButtonEnabled();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            setCreateButtonEnabled();
        }
    }
}
