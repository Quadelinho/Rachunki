using System.Windows.Forms;

namespace Rachunki.Forms.Controls
{
    public partial class TextValueEditor : UserControl, IGettable
    {
        public TextValueEditor()
        {
            InitializeComponent();
        }

        public string GetValue()
        {
            return ValueTextBox.Text;
        }
    }
}
