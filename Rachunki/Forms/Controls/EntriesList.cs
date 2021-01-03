using Rachunki.Model;
using System.Windows.Forms;

namespace Rachunki.Forms.Controls
{
    public partial class EntriesList : UserControl
    {
        public EntriesList() { }

        public void IntializeList(string label, Bill[] entries)
        {
            InitializeComponent();
            ListLabel.Text = label;
            EntriesListView.BeginUpdate();
            EntriesListView.Items.Clear();
            foreach(Bill entry in entries)
            {
                var row = new string[] { entry.Label, entry.PaymentDate, entry.Value.ToString(), entry.IsPaid == 1 ? "Tak" : "Nie" };
                ListViewItem item = new ListViewItem(row);
                if(entry.IsPaid == 0)
                {
                    item.ForeColor = System.Drawing.Color.Red;
                    item.Font = new System.Drawing.Font(item.Font.FontFamily, item.Font.Size, System.Drawing.FontStyle.Bold);
                }
                EntriesListView.Items.Add(item);
            }
            EntriesListView.EndUpdate();
        }

        private void EntriesListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            sender.GetType();
        }
    }
}
