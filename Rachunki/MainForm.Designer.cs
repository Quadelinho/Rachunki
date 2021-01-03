namespace Rachunki
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectComboBox = new System.Windows.Forms.ComboBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EditDescriptionButton = new System.Windows.Forms.Button();
            this.PaymentDateLabel = new System.Windows.Forms.Label();
            this.PaymentDateTextBox = new System.Windows.Forms.TextBox();
            this.PaymentDateButton = new System.Windows.Forms.Button();
            this.NextPaymentDateLabel = new System.Windows.Forms.Label();
            this.NextPaymentDateTextBox = new System.Windows.Forms.TextBox();
            this.NextPaymentDateButton = new System.Windows.Forms.Button();
            this.FreqencyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.FrequencyButton = new System.Windows.Forms.Button();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.DoPaymentButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Find});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Add
            // 
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(125, 24);
            this.Add.Text = "Dodaj rachunek";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(129, 24);
            this.Find.Text = "Znajdź rachunek";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // SelectComboBox
            // 
            this.SelectComboBox.FormattingEnabled = true;
            this.SelectComboBox.Location = new System.Drawing.Point(292, 4);
            this.SelectComboBox.Name = "SelectComboBox";
            this.SelectComboBox.Size = new System.Drawing.Size(138, 24);
            this.SelectComboBox.TabIndex = 1;
            this.SelectComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectComboBox_SelectedIndexChanged);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(268, 316);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(96, 44);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Następny rachunek";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousButton.Location = new System.Drawing.Point(110, 316);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(96, 44);
            this.PreviousButton.TabIndex = 3;
            this.PreviousButton.Text = "Poprzedni rachunek";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(71, 41);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(62, 17);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Etykieta:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(139, 43);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(212, 22);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // EditDescriptionButton
            // 
            this.EditDescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditDescriptionButton.Location = new System.Drawing.Point(358, 41);
            this.EditDescriptionButton.Name = "EditDescriptionButton";
            this.EditDescriptionButton.Size = new System.Drawing.Size(32, 23);
            this.EditDescriptionButton.TabIndex = 6;
            this.EditDescriptionButton.Text = "...";
            this.EditDescriptionButton.UseVisualStyleBackColor = true;
            this.EditDescriptionButton.Click += new System.EventHandler(this.EditDescriptionButton_Click);
            // 
            // PaymentDateLabel
            // 
            this.PaymentDateLabel.AutoSize = true;
            this.PaymentDateLabel.Location = new System.Drawing.Point(22, 82);
            this.PaymentDateLabel.Name = "PaymentDateLabel";
            this.PaymentDateLabel.Size = new System.Drawing.Size(111, 17);
            this.PaymentDateLabel.TabIndex = 4;
            this.PaymentDateLabel.Text = "Data do zapłaty:";
            // 
            // PaymentDateTextBox
            // 
            this.PaymentDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentDateTextBox.Location = new System.Drawing.Point(139, 82);
            this.PaymentDateTextBox.Name = "PaymentDateTextBox";
            this.PaymentDateTextBox.ReadOnly = true;
            this.PaymentDateTextBox.Size = new System.Drawing.Size(212, 22);
            this.PaymentDateTextBox.TabIndex = 5;
            // 
            // PaymentDateButton
            // 
            this.PaymentDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentDateButton.Location = new System.Drawing.Point(358, 80);
            this.PaymentDateButton.Name = "PaymentDateButton";
            this.PaymentDateButton.Size = new System.Drawing.Size(32, 23);
            this.PaymentDateButton.TabIndex = 6;
            this.PaymentDateButton.Text = "...";
            this.PaymentDateButton.UseVisualStyleBackColor = true;
            this.PaymentDateButton.Click += new System.EventHandler(this.PaymentDateButton_Click);
            // 
            // NextPaymentDateLabel
            // 
            this.NextPaymentDateLabel.AutoSize = true;
            this.NextPaymentDateLabel.Location = new System.Drawing.Point(12, 123);
            this.NextPaymentDateLabel.Name = "NextPaymentDateLabel";
            this.NextPaymentDateLabel.Size = new System.Drawing.Size(123, 17);
            this.NextPaymentDateLabel.TabIndex = 4;
            this.NextPaymentDateLabel.Text = "Natępna płatność:";
            // 
            // NextPaymentDateTextBox
            // 
            this.NextPaymentDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPaymentDateTextBox.Location = new System.Drawing.Point(139, 123);
            this.NextPaymentDateTextBox.Name = "NextPaymentDateTextBox";
            this.NextPaymentDateTextBox.ReadOnly = true;
            this.NextPaymentDateTextBox.Size = new System.Drawing.Size(212, 22);
            this.NextPaymentDateTextBox.TabIndex = 5;
            // 
            // NextPaymentDateButton
            // 
            this.NextPaymentDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPaymentDateButton.Location = new System.Drawing.Point(358, 121);
            this.NextPaymentDateButton.Name = "NextPaymentDateButton";
            this.NextPaymentDateButton.Size = new System.Drawing.Size(32, 23);
            this.NextPaymentDateButton.TabIndex = 6;
            this.NextPaymentDateButton.Text = "...";
            this.NextPaymentDateButton.UseVisualStyleBackColor = true;
            // 
            // FreqencyLabel
            // 
            this.FreqencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FreqencyLabel.AutoSize = true;
            this.FreqencyLabel.Location = new System.Drawing.Point(131, 197);
            this.FreqencyLabel.Name = "FreqencyLabel";
            this.FreqencyLabel.Size = new System.Drawing.Size(81, 17);
            this.FreqencyLabel.TabIndex = 4;
            this.FreqencyLabel.Text = "Płatność co";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "miesięcy";
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencyTextBox.Location = new System.Drawing.Point(218, 194);
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.ReadOnly = true;
            this.FrequencyTextBox.Size = new System.Drawing.Size(65, 22);
            this.FrequencyTextBox.TabIndex = 5;
            // 
            // FrequencyButton
            // 
            this.FrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencyButton.Location = new System.Drawing.Point(357, 194);
            this.FrequencyButton.Name = "FrequencyButton";
            this.FrequencyButton.Size = new System.Drawing.Size(32, 23);
            this.FrequencyButton.TabIndex = 6;
            this.FrequencyButton.Text = "...";
            this.FrequencyButton.UseVisualStyleBackColor = true;
            this.FrequencyButton.Click += new System.EventHandler(this.FrequencyButton_Click);
            // 
            // PaidLabel
            // 
            this.PaidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidLabel.ForeColor = System.Drawing.Color.Red;
            this.PaidLabel.Location = new System.Drawing.Point(121, 243);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(164, 29);
            this.PaidLabel.TabIndex = 4;
            this.PaidLabel.Text = "Nieopłacony";
            // 
            // DoPaymentButton
            // 
            this.DoPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoPaymentButton.Location = new System.Drawing.Point(292, 237);
            this.DoPaymentButton.Name = "DoPaymentButton";
            this.DoPaymentButton.Size = new System.Drawing.Size(98, 50);
            this.DoPaymentButton.TabIndex = 7;
            this.DoPaymentButton.Text = "Oznacz jako opłacony";
            this.DoPaymentButton.UseVisualStyleBackColor = true;
            this.DoPaymentButton.Click += new System.EventHandler(this.DoPaymentButton_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(83, 165);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(50, 17);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Kwota:";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTextBox.Location = new System.Drawing.Point(139, 162);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(212, 22);
            this.ValueTextBox.TabIndex = 5;
            // 
            // ValueButton
            // 
            this.ValueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueButton.Location = new System.Drawing.Point(358, 160);
            this.ValueButton.Name = "ValueButton";
            this.ValueButton.Size = new System.Drawing.Size(32, 23);
            this.ValueButton.TabIndex = 6;
            this.ValueButton.Text = "...";
            this.ValueButton.UseVisualStyleBackColor = true;
            this.ValueButton.Click += new System.EventHandler(this.ValueButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 373);
            this.Controls.Add(this.DoPaymentButton);
            this.Controls.Add(this.FrequencyButton);
            this.Controls.Add(this.ValueButton);
            this.Controls.Add(this.NextPaymentDateButton);
            this.Controls.Add(this.PaymentDateButton);
            this.Controls.Add(this.EditDescriptionButton);
            this.Controls.Add(this.FrequencyTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.NextPaymentDateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.FreqencyLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.NextPaymentDateLabel);
            this.Controls.Add(this.PaymentDateTextBox);
            this.Controls.Add(this.PaymentDateLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rachunki";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Add;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ComboBox SelectComboBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button EditDescriptionButton;
        private System.Windows.Forms.Label PaymentDateLabel;
        private System.Windows.Forms.TextBox PaymentDateTextBox;
        private System.Windows.Forms.Button PaymentDateButton;
        private System.Windows.Forms.Label NextPaymentDateLabel;
        private System.Windows.Forms.TextBox NextPaymentDateTextBox;
        private System.Windows.Forms.Button NextPaymentDateButton;
        private System.Windows.Forms.Label FreqencyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.Button FrequencyButton;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.Button DoPaymentButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Button ValueButton;
    }
}

