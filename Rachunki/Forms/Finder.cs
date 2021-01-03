using Rachunki.Controller;
using Rachunki.Model;
using System;
using System.Windows.Forms;

namespace Rachunki.Forms
{
    public partial class Finder : Form
    {
        public Bill[] FoundBills { get; private set; }
        public Finder()
        {
            InitializeComponent();
            InitializeControlsState();
        }

        public void InitializeControlsState()
        {
            textBoxLabel.Enabled = radioButtonForLabel.Checked;
            dateTimePicker.Enabled = radioButtonForDate.Checked;
            groupBoxDateType.Enabled = radioButtonForDate.Checked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FoundBills = new Bill[0];
            //Do the search
            BillsProcessor processor = new BillsProcessor();
            if (radioButtonForLabel.Checked)
            {
                FoundBills = processor.FindBills(textBoxLabel.Text, checkBoxPaid.Checked);
            }
            else
            {
                FoundBills = processor.FindBills(dateTimePicker.Value.ToShortDateString(), radioButtonNewer.Checked, checkBoxPaid.Checked);
            }

            DialogResult = DialogResult.OK;
        }

        private void radioButtonForLabel_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLabel.Enabled = radioButtonForLabel.Checked;
        }

        private void radioButtonForDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = radioButtonForDate.Checked;
            groupBoxDateType.Enabled = radioButtonForDate.Checked;
        }
    }
}
