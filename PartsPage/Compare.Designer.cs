namespace PartsPage
{
    partial class Compare
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
            comparisonGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)comparisonGrid).BeginInit();
            SuspendLayout();
            // 
            // comparisonGrid
            // 
            comparisonGrid.AllowUserToAddRows = false;
            comparisonGrid.AllowUserToDeleteRows = false;
            comparisonGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comparisonGrid.BackgroundColor = SystemColors.ButtonHighlight;
            comparisonGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comparisonGrid.Dock = DockStyle.Fill;
            comparisonGrid.Location = new Point(0, 0);
            comparisonGrid.Name = "comparisonGrid";
            comparisonGrid.ReadOnly = true;
            comparisonGrid.RowHeadersVisible = false;
            comparisonGrid.Size = new Size(784, 336);
            comparisonGrid.TabIndex = 0;
            // 
            // Compare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 336);
            Controls.Add(comparisonGrid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Compare";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Compare";
            ((System.ComponentModel.ISupportInitialize)comparisonGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView comparisonGrid;
    }
}