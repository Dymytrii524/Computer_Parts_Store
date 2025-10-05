namespace Computer_Parts_Store.Forms
{
    partial class ProductCompareForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewCompare = new System.Windows.Forms.DataGridView();
            this.colCharacteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Порівняння товарів";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1100, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewCompare
            // 
            this.dataGridViewCompare.AllowUserToAddRows = false;
            this.dataGridViewCompare.AllowUserToDeleteRows = false;
            this.dataGridViewCompare.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCharacteristic,
            this.colProduct1,
            this.colProduct2,
            this.colProduct3});
            this.dataGridViewCompare.Location = new System.Drawing.Point(30, 130);
            this.dataGridViewCompare.Name = "dataGridViewCompare";
            this.dataGridViewCompare.ReadOnly = true;
            this.dataGridViewCompare.RowTemplate.Height = 40;
            this.dataGridViewCompare.Size = new System.Drawing.Size(1140, 600);
            this.dataGridViewCompare.TabIndex = 1;
            // 
            // colCharacteristic
            // 
            this.colCharacteristic.HeaderText = "Характеристика";
            this.colCharacteristic.Name = "colCharacteristic";
            this.colCharacteristic.ReadOnly = true;
            this.colCharacteristic.Width = 250;
            // 
            // colProduct1
            // 
            this.colProduct1.HeaderText = "Товар 1";
            this.colProduct1.Name = "colProduct1";
            this.colProduct1.ReadOnly = true;
            this.colProduct1.Width = 280;
            // 
            // colProduct2
            // 
            this.colProduct2.HeaderText = "Товар 2";
            this.colProduct2.Name = "colProduct2";
            this.colProduct2.ReadOnly = true;
            this.colProduct2.Width = 280;
            // 
            // colProduct3
            // 
            this.colProduct3.HeaderText = "Товар 3";
            this.colProduct3.Name = "colProduct3";
            this.colProduct3.ReadOnly = true;
            this.colProduct3.Width = 280;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(30, 95);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(526, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Виберіть до 3 товарів однієї категорії в каталозі для порівняння";
            // 
            // ProductCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGridViewCompare);
            this.Controls.Add(this.panelHeader);
            this.Name = "ProductCompareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Порівняння товарів";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCharacteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct3;
        private System.Windows.Forms.Label lblInfo;
    }
}