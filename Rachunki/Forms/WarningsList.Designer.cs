namespace Rachunki.Forms
{
    partial class WarningsList
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
            this.IncommingBillsEntriesList = new Rachunki.Forms.Controls.EntriesList();
            this.OverdueEntriesList = new Rachunki.Forms.Controls.EntriesList();
            this.ListsContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ListsContainer)).BeginInit();
            this.ListsContainer.Panel1.SuspendLayout();
            this.ListsContainer.Panel2.SuspendLayout();
            this.ListsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncommingBillsEntriesList
            // 
            this.IncommingBillsEntriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncommingBillsEntriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncommingBillsEntriesList.Location = new System.Drawing.Point(0, 0);
            this.IncommingBillsEntriesList.Name = "IncommingBillsEntriesList";
            this.IncommingBillsEntriesList.Size = new System.Drawing.Size(441, 193);
            this.IncommingBillsEntriesList.TabIndex = 1;
            // 
            // OverdueEntriesList
            // 
            this.OverdueEntriesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverdueEntriesList.AutoScroll = true;
            this.OverdueEntriesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverdueEntriesList.Location = new System.Drawing.Point(0, 0);
            this.OverdueEntriesList.Name = "OverdueEntriesList";
            this.OverdueEntriesList.Size = new System.Drawing.Size(441, 193);
            this.OverdueEntriesList.TabIndex = 0;
            // 
            // ListsContainer
            // 
            this.ListsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListsContainer.Location = new System.Drawing.Point(0, 0);
            this.ListsContainer.Name = "ListsContainer";
            this.ListsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ListsContainer.Panel1
            // 
            this.ListsContainer.Panel1.Controls.Add(this.OverdueEntriesList);
            // 
            // ListsContainer.Panel2
            // 
            this.ListsContainer.Panel2.Controls.Add(this.IncommingBillsEntriesList);
            this.ListsContainer.Size = new System.Drawing.Size(441, 393);
            this.ListsContainer.SplitterDistance = 196;
            this.ListsContainer.TabIndex = 2;
            // 
            // WarningsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.ListsContainer);
            this.MinimizeBox = false;
            this.Name = "WarningsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uwaga!";
            this.ListsContainer.Panel1.ResumeLayout(false);
            this.ListsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListsContainer)).EndInit();
            this.ListsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EntriesList OverdueEntriesList;
        private Controls.EntriesList IncommingBillsEntriesList;
        private System.Windows.Forms.SplitContainer ListsContainer;
    }
}