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

        private void CreateNewInstancesOfBills()
        {
            //for each Label create a new instance for the next payment (if not exist)
            BillsProcessor processor = new BillsProcessor();
            processor.CreateNewInstancesOfBills();
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
            }
        }

        private void MakePaidLabelGreen()
        {
            PaidLabel.Text = "Opłacony";
            PaidLabel.ForeColor = System.Drawing.Color.Green;
        }

        private void EditDescriptionButton_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor();
            editor.SetEditor(EditorType.Text);
            editor.StartPosition = FormStartPosition.CenterParent;
            if(editor.ShowDialog() == DialogResult.OK)
            {
                currentlyShownBill.Label = editor.Value;
                BillsProcessor processor = new BillsProcessor();
                processor.UpdateBill(currentlyShownBill);
                PopulateLabelsDropDown();
            }
        }

        private void PaymentDateButton_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor();
            editor.SetEditor(EditorType.Date);
            editor.StartPosition = FormStartPosition.CenterParent;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                currentlyShownBill.PaymentDate = editor.Value;
                BillsProcessor processor = new BillsProcessor();
                processor.UpdateBill(currentlyShownBill);
                PaymentDateTextBox.Text = currentlyShownBill.PaymentDate;
            }
        }

        private void ValueButton_Click(object sender, EventArgs e)
        {
            TextEditor editor = new TextEditor();
            editor.SetEditor(EditorType.Decimal);
            editor.StartPosition = FormStartPosition.CenterParent;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                currentlyShownBill.Value = decimal.Parse(editor.Value);
                BillsProcessor processor = new BillsProcessor();
                processor.UpdateBill(currentlyShownBill);
                ValueTextBox.Text = currentlyShownBill.Value.ToString();
            }
        }

        private void FrequencyButton_Click(object sender, EventArgs e)
        {
            TextEditor editor = InitializeEditor(EditorType.Int);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                currentlyShownBill.Frequency = int.Parse(editor.Value);
                BillsProcessor processor = new BillsProcessor();
                processor.UpdateBill(currentlyShownBill);
                FrequencyTextBox.Text = currentlyShownBill.Frequency.ToString();
            }
        }

        private TextEditor InitializeEditor(EditorType type)
        {
            TextEditor editor = new TextEditor();
            editor.SetEditor(type);
            editor.StartPosition = FormStartPosition.CenterParent;
            return editor;
        }
    }
}
