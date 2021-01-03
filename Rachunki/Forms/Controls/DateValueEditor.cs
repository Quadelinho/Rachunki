using System;
using System.Windows.Forms;

namespace Rachunki.Forms.Controls
{
    public partial class DateValueEditor : UserControl, IGettable
    {
        public DateValueEditor()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
        }

        public string GetValue()
        {
            return dateTimePicker.Text;
        }
    }
}
