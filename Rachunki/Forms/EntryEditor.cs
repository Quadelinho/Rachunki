using Rachunki.Model;
using System;
using System.Windows.Forms;

namespace Rachunki.Forms
{
    public partial class EntryEditor : Form
    {
        private Bill billEntry = new Bill();

        public Bill GetBillToSave()
        {
            return billEntry;
        }

        public EntryEditor()
        {
            InitializeComponent();
            PaymentDateDateTimePicker.Value = DateTime.Now;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            billEntry.Frequency = (int)MonthsCounter.Value;
            billEntry.IsPaid = IsPaidRadioTrue.Checked ? 1 : 0;
            billEntry.Label = DescriptionTextBox.Text;
            billEntry.MarkedAsPaidDate = IsPaidRadioTrue.Checked ? DateTime.Now.ToShortDateString() : null;
            billEntry.PaymentDate = PaymentDateDateTimePicker.Value.ToShortDateString();
            billEntry.Value = ValueToPayNumeric.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
