using Rachunki.Controller;
using Rachunki.DBContext;
using Rachunki.Forms;
using Rachunki.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rachunki
{
    public partial class MainForm : Form
    {
        private List<Bill> billsForLabel = new List<Bill>();
        Bill currentlyShownBill = null;

        public MainForm()
        {
            InitializeComponent();
            PopulateLabelsDropDown();
        }

        private void ShowWarningsIfNeeded()
        {
            BillsProcessor processor = new BillsProcessor();
            Bill[] unpaidBills = processor.GetUnpaidBills();
            Bill[] incommingBills = processor.GetIncommingBills();
            if(unpaidBills.Length > 0
                || incommingBills.Length > 0)
            {
                WarningsList warningsDialog = new WarningsList();
                warningsDialog.InitializeEntriesLists(unpaidBills, incommingBills);
                warningsDialog.ShowDialog();
            }
        }
        
        private void PopulateLabelsDropDown()
        {
            BillsProcessor processor = new BillsProcessor();
            SelectComboBox.BeginUpdate();
            SelectComboBox.Items.Clear();
            SelectComboBox.Items.AddRange(processor.GetBillsLabels(true));
            SelectComboBox.EndUpdate();
            if (SelectComboBox.Items != null && SelectComboBox.Items.Count > 0)
            {
                SelectComboBox.SelectedIndex = 0;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            EntryEditor editor = new EntryEditor();
            var result = editor.ShowDialog();
            if(result == DialogResult.OK)
            {
                using (var context = new DatabaseContext())
                {
                    context.Bills.Add(editor.GetBillToSave());
                    context.SaveChanges();

                    var updatedBills2 = context.Bills.ToList();
                }
                PopulateLabelsDropDown();
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Finder findDialog = new Finder();
            if(findDialog.ShowDialog() == DialogResult.OK)
            {
                FindResults resultsViewer = new FindResults();
                resultsViewer.LoadData(findDialog.FoundBills);
                resultsViewer.ShowDialog();
            }
        }

        private void SelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillsProcessor processor = new BillsProcessor();
            billsForLabel = processor.GetBillsForLabel(SelectComboBox.Text);

            currentlyShownBill = billsForLabel[0];
            DescriptionTextBox.Text = currentlyShownBill.Label;
            PaymentDateTextBox.Text = currentlyShownBill.PaymentDate;
            NextPaymentDateTextBox.Text = processor.GetNextPaymentDate(currentlyShownBill.PaymentDate, currentlyShownBill.Frequency);
            ValueTextBox.Text = currentlyShownBill.Value.ToString();
            FrequencyTextBox.Text = currentlyShownBill.Frequency.ToString();

            if (currentlyShownBill.IsPaid == 0) //false
            {
                PaidLabel.Text = "Nieopłacony";
                PaidLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                MakePaidLabelGreen();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ShowWarningsIfNeeded();
        }

        private void DoPaymentButton_Click(object sender, EventArgs e)
        {
            BillsProcessor processor = new BillsProcessor();
            if (processor.MarkBillAsPaid(currentlyShownBill.Id))
            {
                MakePaidLabelGreen();
                processor.CreateNextBillInstance(currentlyShownBill.Label);
            }
        }

        private void MakePaidLabelGreen()
        {
            PaidLabel.Text = "Opłacony";
            PaidLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void EditDescriptionButton_Click(object sender, EventArgs e)
        {
            string editedValue = CollectEditedValue(EditorType.Text);
            if (!string.IsNullOrWhiteSpace(editedValue))
            {
                currentlyShownBill.Label = editedValue;
                UpdateCurrentlyShownBillFields();
                PopulateLabelsDropDown();
            }
        }

        private void PaymentDateButton_Click(object sender, EventArgs e)
        {
            string editedValue = CollectEditedValue(EditorType.Date);
            if (!string.IsNullOrWhiteSpace(editedValue))
            {
                currentlyShownBill.PaymentDate = editedValue;
                UpdateCurrentlyShownBillFields();
                PaymentDateTextBox.Text = currentlyShownBill.PaymentDate;
                BillsProcessor processor = new BillsProcessor();
                NextPaymentDateTextBox.Text = processor.GetNextPaymentDate(currentlyShownBill.PaymentDate, currentlyShownBill.Frequency);
            }
        }

        private void ValueButton_Click(object sender, EventArgs e)
        {
            string editedValue = CollectEditedValue(EditorType.Decimal);
            if (!string.IsNullOrWhiteSpace(editedValue))
            {
                currentlyShownBill.Value = decimal.Parse(editedValue);
                UpdateCurrentlyShownBillFields();
                ValueTextBox.Text = currentlyShownBill.Value.ToString();
            }
        }

        private void FrequencyButton_Click(object sender, EventArgs e)
        {
            string editedValue = CollectEditedValue(EditorType.Int);
            if (!string.IsNullOrWhiteSpace(editedValue))
            {
                currentlyShownBill.Frequency = int.Parse(editedValue);
                UpdateCurrentlyShownBillFields();
                FrequencyTextBox.Text = currentlyShownBill.Frequency.ToString();
            }
        }

        private string CollectEditedValue(EditorType type)
        {
            TextEditor editor = new TextEditor();
            editor.SetEditor(type);
            editor.StartPosition = FormStartPosition.CenterParent;
            editor.ShowDialog();
            return editor.Value;
        }

        private void UpdateCurrentlyShownBillFields()
        {
            BillsProcessor processor = new BillsProcessor();
            processor.UpdateBill(currentlyShownBill);
        }
    }
}
