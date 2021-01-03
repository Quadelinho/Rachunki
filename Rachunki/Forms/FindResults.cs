using Rachunki.Model;
using System.Windows.Forms;

namespace Rachunki.Forms
{
    public partial class FindResults : Form
    {
        public Bill[] DataSource { get; set; }

        public FindResults()
        {
            InitializeComponent();
        }

        public void LoadData(Bill[] dataSet)
        {
            entriesList.IntializeList("Znalezione rachunki:", dataSet);
        }
    }
}
