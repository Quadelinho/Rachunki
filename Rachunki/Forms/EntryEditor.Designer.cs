namespace Rachunki.Forms
{
    partial class EntryEditor
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PaymentDateLabel = new System.Windows.Forms.Label();
            this.PaymentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.MonthsCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.IsPaidRadioTrue = new System.Windows.Forms.RadioButton();
            this.IsPaidGroupBox = new System.Windows.Forms.GroupBox();
            this.IsPaidRadioFalse = new System.Windows.Forms.RadioButton();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueToPayNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MonthsCounter)).BeginInit();
            this.IsPaidGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueToPayNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(58, 17);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Etykieta";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(125, 6);
            this.DescriptionTextBox.MaxLength = 100;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(190, 22);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(240, 235);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 235);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // PaymentDateLabel
            // 
            this.PaymentDateLabel.AutoSize = true;
            this.PaymentDateLabel.Location = new System.Drawing.Point(12, 46);
            this.PaymentDateLabel.Name = "PaymentDateLabel";
            this.PaymentDateLabel.Size = new System.Drawing.Size(107, 17);
            this.PaymentDateLabel.TabIndex = 0;
            this.PaymentDateLabel.Text = "Data do zapłaty";
            // 
            // PaymentDateDateTimePicker
            // 
            this.PaymentDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDateDateTimePicker.Location = new System.Drawing.Point(125, 46);
            this.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker";
            this.PaymentDateDateTimePicker.Size = new System.Drawing.Size(190, 22);
            this.PaymentDateDateTimePicker.TabIndex = 4;
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Location = new System.Drawing.Point(12, 84);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(81, 17);
            this.FrequencyLabel.TabIndex = 0;
            this.FrequencyLabel.Text = "Płatność co";
            // 
            // MonthsCounter
            // 
            this.MonthsCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthsCounter.Location = new System.Drawing.Point(125, 84);
            this.MonthsCounter.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MonthsCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MonthsCounter.Name = "MonthsCounter";
            this.MonthsCounter.Size = new System.Drawing.Size(46, 22);
            this.MonthsCounter.TabIndex = 5;
            this.MonthsCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "miesięcy";
            // 
            // IsPaidRadioTrue
            // 
            this.IsPaidRadioTrue.AutoSize = true;
            this.IsPaidRadioTrue.Location = new System.Drawing.Point(15, 21);
            this.IsPaidRadioTrue.Name = "IsPaidRadioTrue";
            this.IsPaidRadioTrue.Size = new System.Drawing.Size(53, 21);
            this.IsPaidRadioTrue.TabIndex = 6;
            this.IsPaidRadioTrue.Text = "Tak";
            this.IsPaidRadioTrue.UseVisualStyleBackColor = true;
            // 
            // IsPaidGroupBox
            // 
            this.IsPaidGroupBox.Controls.Add(this.IsPaidRadioFalse);
            this.IsPaidGroupBox.Controls.Add(this.IsPaidRadioTrue);
            this.IsPaidGroupBox.Location = new System.Drawing.Point(3, 163);
            this.IsPaidGroupBox.Name = "IsPaidGroupBox";
            this.IsPaidGroupBox.Size = new System.Drawing.Size(154, 55);
            this.IsPaidGroupBox.TabIndex = 7;
            this.IsPaidGroupBox.TabStop = false;
            this.IsPaidGroupBox.Text = "Już zapłacono?";
            // 
            // IsPaidRadioFalse
            // 
            this.IsPaidRadioFalse.AutoSize = true;
            this.IsPaidRadioFalse.Checked = true;
            this.IsPaidRadioFalse.Location = new System.Drawing.Point(90, 21);
            this.IsPaidRadioFalse.Name = "IsPaidRadioFalse";
            this.IsPaidRadioFalse.Size = new System.Drawing.Size(50, 21);
            this.IsPaidRadioFalse.TabIndex = 6;
            this.IsPaidRadioFalse.TabStop = true;
            this.IsPaidRadioFalse.Text = "Nie";
            this.IsPaidRadioFalse.UseVisualStyleBackColor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(9, 124);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(115, 17);
            this.ValueLabel.TabIndex = 0;
            this.ValueLabel.Text = "Kwota do zapłaty";
            // 
            // ValueToPayNumeric
            // 
            this.ValueToPayNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueToPayNumeric.DecimalPlaces = 2;
            this.ValueToPayNumeric.Location = new System.Drawing.Point(125, 119);
            this.ValueToPayNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ValueToPayNumeric.Name = "ValueToPayNumeric";
            this.ValueToPayNumeric.Size = new System.Drawing.Size(190, 22);
            this.ValueToPayNumeric.TabIndex = 5;
            this.ValueToPayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EntryEditor
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(327, 268);
            this.Controls.Add(this.IsPaidGroupBox);
            this.Controls.Add(this.ValueToPayNumeric);
            this.Controls.Add(this.MonthsCounter);
            this.Controls.Add(this.PaymentDateDateTimePicker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PaymentDateLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.FrequencyLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj rachunek";
            ((System.ComponentModel.ISupportInitialize)(this.MonthsCounter)).EndInit();
            this.IsPaidGroupBox.ResumeLayout(false);
            this.IsPaidGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueToPayNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label PaymentDateLabel;
        private System.Windows.Forms.DateTimePicker PaymentDateDateTimePicker;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.NumericUpDown MonthsCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IsPaidRadioTrue;
        private System.Windows.Forms.GroupBox IsPaidGroupBox;
        private System.Windows.Forms.RadioButton IsPaidRadioFalse;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.NumericUpDown ValueToPayNumeric;
    }
}