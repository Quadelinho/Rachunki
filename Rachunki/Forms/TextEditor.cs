using Rachunki.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rachunki.Forms
{
    public partial class TextEditor : Form
    {
        public string Value { get; set; }
        public TextEditor()
        {
            this.SuspendLayout();
            InitializeComponent();
        }

        public void SetEditor(EditorType type)
        {
            ControlPanel.Controls.Clear();
            Control editor = null;
            switch(type)
            {
                case EditorType.Int:
                    editor = new NumericEditor();
                    ((NumericUpDown)editor.Controls[0]).DecimalPlaces = 0;
                    break;
                case EditorType.Decimal:
                    editor = new NumericEditor();
                    ((NumericUpDown)editor.Controls[0]).DecimalPlaces = 2;
                    break;
                case EditorType.Date:
                    editor = new DateValueEditor();
                    break;
                case EditorType.Text:
                default:
                    editor = new TextValueEditor();
                    break;
            }
            editor.Dock = DockStyle.Fill;
            ControlPanel.Controls.Add(editor/*new TextValueEditor() { Dock = DockStyle.Fill }*/);
            this.ResumeLayout();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Value = ((IGettable)ControlPanel.Controls[0]).GetValue();
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
