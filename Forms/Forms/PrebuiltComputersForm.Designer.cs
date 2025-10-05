namespace Computer_Parts_Store.Forms
{
    partial class PrebuiltComputersForm
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
            this.dataGridViewPrebuilt = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrebuilt)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(1400, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Готові конфігурації ПК";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1300, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewPrebuilt
            // 
            this.dataGridViewPrebuilt.AllowUserToAddRows = false;
            this.dataGridViewPrebuilt.AllowUserToDeleteRows = false;
            this.dataGridViewPrebuilt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPrebuilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrebuilt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDescription,
            this.colPrice,
            this.colAvailability,
            this.colViewDetails,
            this.colAddToCart});
            this.dataGridViewPrebuilt.Location = new System.Drawing.Point(20, 90);
            this.dataGridViewPrebuilt.Name = "dataGridViewPrebuilt";
            this.dataGridViewPrebuilt.ReadOnly = true;
            this.dataGridViewPrebuilt.RowTemplate.Height = 50;
            this.dataGridViewPrebuilt.Size = new System.Drawing.Size(1360, 660);
            this.dataGridViewPrebuilt.TabIndex = 1;
            this.dataGridViewPrebuilt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrebuilt_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Назва конфігурації";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Опис";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 550;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Ціна (грн)";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 120;
            // 
            // colAvailability
            // 
            this.colAvailability.HeaderText = "Наявність";
            this.colAvailability.Name = "colAvailability";
            this.colAvailability.ReadOnly = true;
            this.colAvailability.Width = 120;
            // 
            // colViewDetails
            // 
            this.colViewDetails.HeaderText = "Деталі";
            this.colViewDetails.Name = "colViewDetails";
            this.colViewDetails.ReadOnly = true;
            this.colViewDetails.Text = "Переглянути";
            this.colViewDetails.UseColumnTextForButtonValue = true;
            this.colViewDetails.Width = 130;
            // 
            // colAddToCart
            // 
            this.colAddToCart.HeaderText = "Додати";
            this.colAddToCart.Name = "colAddToCart";
            this.colAddToCart.ReadOnly = true;
            this.colAddToCart.Text = "У кошик";
            this.colAddToCart.UseColumnTextForButtonValue = true;
            this.colAddToCart.Width = 130;
            // 
            // PrebuiltComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.dataGridViewPrebuilt);
            this.Controls.Add(this.panelHeader);
            this.Name = "PrebuiltComputersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Готові конфігурації ПК";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrebuilt)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewPrebuilt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailability;
        private System.Windows.Forms.DataGridViewButtonColumn colViewDetails;
        private System.Windows.Forms.DataGridViewButtonColumn colAddToCart;
    }
}