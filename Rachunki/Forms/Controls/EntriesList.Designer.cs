namespace Rachunki.Forms.Controls
{
    partial class EntriesList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntriesListView = new System.Windows.Forms.ListView();
            this.LabelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListLabel = new System.Windows.Forms.Label();
            this.IsPaidColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // EntriesListView
            // 
            this.EntriesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LabelColumn,
            this.PaymentDateColumn,
            this.ValueColumn,
            this.IsPaidColumn});
            this.EntriesListView.HideSelection = false;
            this.EntriesListView.Location = new System.Drawing.Point(0, 20);
            this.EntriesListView.Name = "EntriesListView";
            this.EntriesListView.Size = new System.Drawing.Size(441, 173);
            this.EntriesListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.EntriesListView.TabIndex = 0;
            this.EntriesListView.UseCompatibleStateImageBehavior = false;
            this.EntriesListView.View = System.Windows.Forms.View.Details;
            this.EntriesListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.EntriesListView_DrawItem);
            // 
            // LabelColumn
            // 
            this.LabelColumn.Text = "Etykieta";
            this.LabelColumn.Width = 75;
            // 
            // PaymentDateColumn
            // 
            this.PaymentDateColumn.Text = "Data opłaty";
            this.PaymentDateColumn.Width = 106;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Kwota do zapłaty";
            this.ValueColumn.Width = 123;
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListLabel.Location = new System.Drawing.Point(0, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(46, 17);
            this.ListLabel.TabIndex = 1;
            this.ListLabel.Text = "label1";
            // 
            // IsPaidColumn
            // 
            this.IsPaidColumn.Text = "Zapłacone?";
            this.IsPaidColumn.Width = 148;
            // 
            // EntriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.EntriesListView);
            this.Name = "EntriesList";
            this.Size = new System.Drawing.Size(441, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView EntriesListView;
        private System.Windows.Forms.ColumnHeader LabelColumn;
        private System.Windows.Forms.ColumnHeader PaymentDateColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.ColumnHeader IsPaidColumn;
    }
}
