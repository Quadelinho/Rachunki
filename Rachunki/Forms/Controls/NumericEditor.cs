using System.Windows.Forms;

namespace Rachunki.Forms.Controls
{
    public partial class NumericEditor : UserControl, IGettable
    {
        public NumericEditor()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            return numericUpDown.Text;
        }
    }
}
