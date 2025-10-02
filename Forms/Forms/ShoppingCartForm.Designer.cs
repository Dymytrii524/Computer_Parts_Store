namespace Computer_Parts_Store.Forms
{
    partial class ShoppingCartForm
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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lblItemsCountValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.panelSummary.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(103, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Кошик";
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
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colArticle,
            this.colPrice,
            this.colQuantity,
            this.colTotal,
            this.colRemove});
            this.dataGridViewCart.Location = new System.Drawing.Point(20, 90);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowTemplate.Height = 40;
            this.dataGridViewCart.Size = new System.Drawing.Size(1000, 660);
            this.dataGridViewCart.TabIndex = 1;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            this.dataGridViewCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellValueChanged);
            // 
            // colName
            // 
            this.colName.HeaderText = "Назва товару";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 350;
            // 
            // colArticle
            // 
            this.colArticle.HeaderText = "Артикул";
            this.colArticle.Name = "colArticle";
            this.colArticle.ReadOnly = true;
            this.colArticle.Width = 100;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Ціна (грн)";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 120;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Кількість";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Сума (грн)";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 120;
            // 
            // colRemove
            // 
            this.colRemove.HeaderText = "Видалити";
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "Видалити";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 110;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.Controls.Add(this.btnClearCart);
            this.panelSummary.Controls.Add(this.btnCheckout);
            this.panelSummary.Controls.Add(this.lblTotalPriceValue);
            this.panelSummary.Controls.Add(this.lblTotalPrice);
            this.panelSummary.Controls.Add(this.lblItemsCountValue);
            this.panelSummary.Controls.Add(this.lblItemsCount);
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Location = new System.Drawing.Point(1040, 90);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(340, 660);
            this.panelSummary.TabIndex = 2;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.Location = new System.Drawing.Point(15, 20);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(165, 25);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Підсумок замовлення";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblItemsCount.Location = new System.Drawing.Point(15, 70);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(128, 20);
            this.lblItemsCount.TabIndex = 1;
            this.lblItemsCount.Text = "Кількість товарів:";
            // 
            // lblItemsCountValue
            // 
            this.lblItemsCountValue.AutoSize = true;
            this.lblItemsCountValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemsCountValue.Location = new System.Drawing.Point(15, 95);
            this.lblItemsCountValue.Name = "lblItemsCountValue";
            this.lblItemsCountValue.Size = new System.Drawing.Size(19, 21);
            this.lblItemsCountValue.TabIndex = 2;
            this.lblItemsCountValue.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 140);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 20);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "До сплати (грн):";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(15, 165);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(75, 32);
            this.lblTotalPriceValue.TabIndex = 4;
            this.lblTotalPriceValue.Text = "0.00";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(15, 550);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(300, 50);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "✓ Оформити замовлення";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(15, 605);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(300, 40);
            this.btnClearCart.TabIndex = 6;
            this.btnClearCart.Text = "🗑️ Очистити кошик";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.panelHeader);
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кошик покупок";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label lblItemsCountValue;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClearCart;
    }
}