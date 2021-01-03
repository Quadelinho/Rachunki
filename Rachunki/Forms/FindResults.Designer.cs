namespace Rachunki.Forms
{
    partial class FindResults
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
            this.entriesList = new Rachunki.Forms.Controls.EntriesList();
            this.SuspendLayout();
            // 
            // entriesList
            // 
            this.entriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesList.Location = new System.Drawing.Point(-2, 2);
            this.entriesList.Name = "entriesList";
            this.entriesList.Size = new System.Drawing.Size(310, 208);
            this.entriesList.TabIndex = 0;
            // 
            // FindResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 210);
            this.Controls.Add(this.entriesList);
            this.MinimizeBox = false;
            this.Name = "FindResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wyniki wyszukiwania";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EntriesList entriesList;
    }
}