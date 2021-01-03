using Rachunki.Model;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

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
                var row = new string[] { entry.Label, entry.PaymentDate, entry.Value.ToString() };
                EntriesListView.Items.Add(new ListViewItem(row));
            }
            EntriesListView.EndUpdate();
        }
    }
}
