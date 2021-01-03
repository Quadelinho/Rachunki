namespace Rachunki.Forms
{
    partial class Finder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioButtonForLabel = new System.Windows.Forms.RadioButton();
            this.radioButtonForDate = new System.Windows.Forms.RadioButton();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDateType = new System.Windows.Forms.GroupBox();
            this.radioButtonOlder = new System.Windows.Forms.RadioButton();
            this.radioButtonNewer = new System.Windows.Forms.RadioButton();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.checkBoxPaid);
            this.groupBoxSearch.Controls.Add(this.groupBoxDateType);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxLabel);
            this.groupBoxSearch.Controls.Add(this.radioButtonForDate);
            this.groupBoxSearch.Controls.Add(this.radioButtonForLabel);
            this.groupBoxSearch.Location = new System.Drawing.Point(2, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(317, 286);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Wybierz sposób wyszukiwania";
            // 
            // radioButtonForLabel
            // 
            this.radioButtonForLabel.AutoSize = true;
            this.radioButtonForLabel.Checked = true;
            this.radioButtonForLabel.Location = new System.Drawing.Point(10, 33);
            this.radioButtonForLabel.Name = "radioButtonForLabel";
            this.radioButtonForLabel.Size = new System.Drawing.Size(210, 21);
            this.radioButtonForLabel.TabIndex = 0;
            this.radioButtonForLabel.TabStop = true;
            this.radioButtonForLabel.Text = "Znajdź wszystkie dla etykiety";
            this.radioButtonForLabel.UseVisualStyleBackColor = true;
            this.radioButtonForLabel.CheckedChanged += new System.EventHandler(this.radioButtonForLabel_CheckedChanged);
            // 
            // radioButtonForDate
            // 
            this.radioButtonForDate.AutoSize = true;
            this.radioButtonForDate.Location = new System.Drawing.Point(10, 104);
            this.radioButtonForDate.Name = "radioButtonForDate";
            this.radioButtonForDate.Size = new System.Drawing.Size(189, 21);
            this.radioButtonForDate.TabIndex = 1;
            this.radioButtonForDate.Text = "Znajdź wszytskie dla daty";
            this.radioButtonForDate.UseVisualStyleBackColor = true;
            this.radioButtonForDate.CheckedChanged += new System.EventHandler(this.radioButtonForDate_CheckedChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLabel.Location = new System.Drawing.Point(137, 61);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(170, 22);
            this.textBoxLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Szukana etykieta:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(59, 131);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // groupBoxDateType
            // 
            this.groupBoxDateType.Controls.Add(this.radioButtonNewer);
            this.groupBoxDateType.Controls.Add(this.radioButtonOlder);
            this.groupBoxDateType.Location = new System.Drawing.Point(14, 168);
            this.groupBoxDateType.Name = "groupBoxDateType";
            this.groupBoxDateType.Size = new System.Drawing.Size(293, 82);
            this.groupBoxDateType.TabIndex = 5;
            this.groupBoxDateType.TabStop = false;
            this.groupBoxDateType.Text = "Rodzaj wyszukiwania";
            // 
            // radioButtonOlder
            // 
            this.radioButtonOlder.AutoSize = true;
            this.radioButtonOlder.Checked = true;
            this.radioButtonOlder.Location = new System.Drawing.Point(7, 22);
            this.radioButtonOlder.Name = "radioButtonOlder";
            this.radioButtonOlder.Size = new System.Drawing.Size(122, 21);
            this.radioButtonOlder.TabIndex = 0;
            this.radioButtonOlder.TabStop = true;
            this.radioButtonOlder.Text = "Znajdź starsze";
            this.radioButtonOlder.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewer
            // 
            this.radioButtonNewer.AutoSize = true;
            this.radioButtonNewer.Location = new System.Drawing.Point(7, 50);
            this.radioButtonNewer.Name = "radioButtonNewer";
            this.radioButtonNewer.Size = new System.Drawing.Size(123, 21);
            this.radioButtonNewer.TabIndex = 1;
            this.radioButtonNewer.TabStop = true;
            this.radioButtonNewer.Text = "Znajdź nowsze";
            this.radioButtonNewer.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Checked = true;
            this.checkBoxPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPaid.Location = new System.Drawing.Point(10, 259);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(190, 21);
            this.checkBoxPaid.TabIndex = 6;
            this.checkBoxPaid.Text = "Pokaż tylko niezapłacone";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(234, 297);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "Szukaj";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 332);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.groupBoxSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Szukaj rachunków";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxDateType.ResumeLayout(false);
            this.groupBoxDateType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonForDate;
        private System.Windows.Forms.RadioButton radioButtonForLabel;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDateType;
        private System.Windows.Forms.RadioButton radioButtonNewer;
        private System.Windows.Forms.RadioButton radioButtonOlder;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonCancel;
    }
}