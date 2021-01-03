using Rachunki.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rachunki.Forms
{
    public partial class WarningsList : Form
    {
        public WarningsList()
        {
            InitializeComponent();
            SystemSounds.Beep.Play();
        }

        public void InitializeEntriesLists(Bill[] unpaidBills, Bill[] incommingBills)
        {
            OverdueEntriesList.IntializeList("Przeterminowane rachunki (nieopłacone)", unpaidBills);
            IncommingBillsEntriesList.IntializeList("Rachunki do opłacenia w najbliższym tygodniu", incommingBills);
        }
    }
}
