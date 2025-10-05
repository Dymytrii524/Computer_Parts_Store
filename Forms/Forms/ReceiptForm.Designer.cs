namespace Computer_Parts_Store.Forms

{

    partial class ReceiptForm

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

            this.panelReceipt = new System.Windows.Forms.Panel();

            this.lblStoreName = new System.Windows.Forms.Label();

            this.lblStoreInfo = new System.Windows.Forms.Label();

            this.lblSeparator1 = new System.Windows.Forms.Label();

            this.lblOrderNumber = new System.Windows.Forms.Label();

            this.lblOrderDate = new System.Windows.Forms.Label();

            this.lblCustomer = new System.Windows.Forms.Label();

            this.lblSeparator2 = new System.Windows.Forms.Label();

            this.dataGridViewItems = new System.Windows.Forms.DataGridView();

            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblSeparator3 = new System.Windows.Forms.Label();

            this.lblSubtotal = new System.Windows.Forms.Label();

            this.lblTotal = new System.Windows.Forms.Label();

            this.lblThankYou = new System.Windows.Forms.Label();

            this.btnPrint = new System.Windows.Forms.Button();

            this.btnSave = new System.Windows.Forms.Button();

            this.btnClose = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();

            this.panelReceipt.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();

            this.SuspendLayout();

            // 

            // panelHeader

            // 

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));

            this.panelHeader.Controls.Add(this.lblTitle);

            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;

            this.panelHeader.Location = new System.Drawing.Point(0, 0);

            this.panelHeader.Name = "panelHeader";

            this.panelHeader.Size = new System.Drawing.Size(900, 70);

            this.panelHeader.TabIndex = 0;

            // 

            // lblTitle

            // 

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor = System.Drawing.Color.White;

            this.lblTitle.Location = new System.Drawing.Point(20, 17);

            this.lblTitle.Name = "lblTitle";

            this.lblTitle.Size = new System.Drawing.Size(294, 37);

            this.lblTitle.TabIndex = 0;

            this.lblTitle.Text = "✓ Замовлення успішне!";

            // 

            // panelReceipt

            // 

            this.panelReceipt.BackColor = System.Drawing.Color.White;

            this.panelReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelReceipt.Controls.Add(this.lblThankYou);

            this.panelReceipt.Controls.Add(this.lblTotal);

            this.panelReceipt.Controls.Add(this.lblSubtotal);

            this.panelReceipt.Controls.Add(this.lblSeparator3);

            this.panelReceipt.Controls.Add(this.dataGridViewItems);

            this.panelReceipt.Controls.Add(this.lblSeparator2);

            this.panelReceipt.Controls.Add(this.lblCustomer);

            this.panelReceipt.Controls.Add(this.lblOrderDate);

            this.panelReceipt.Controls.Add(this.lblOrderNumber);

            this.panelReceipt.Controls.Add(this.lblSeparator1);

            this.panelReceipt.Controls.Add(this.lblStoreInfo);

            this.panelReceipt.Controls.Add(this.lblStoreName);

            this.panelReceipt.Location = new System.Drawing.Point(50, 100);

            this.panelReceipt.Name = "panelReceipt";

            this.panelReceipt.Size = new System.Drawing.Size(800, 850);

            this.panelReceipt.TabIndex = 1;

            // 

            // lblStoreName

            // 

            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);

            this.lblStoreName.Location = new System.Drawing.Point(0, 20);

            this.lblStoreName.Name = "lblStoreName";

            this.lblStoreName.Size = new System.Drawing.Size(800, 35);

            this.lblStoreName.TabIndex = 0;

            this.lblStoreName.Text = "МАГАЗИН КОМП'ЮТЕРНИХ КОМПЛЕКТУЮЧИХ";

            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 

            // lblStoreInfo

            // 

            this.lblStoreInfo.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblStoreInfo.ForeColor = System.Drawing.Color.Gray;

            this.lblStoreInfo.Location = new System.Drawing.Point(0, 60);

            this.lblStoreInfo.Name = "lblStoreInfo";

            this.lblStoreInfo.Size = new System.Drawing.Size(800, 40);

            this.lblStoreInfo.TabIndex = 1;

            this.lblStoreInfo.Text = "м. Київ, вул. Хрещатик 1\r\nТел: +380 (44) 123-45-67 | Email: shop@computerparts.ua";

            this.lblStoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 

            // lblSeparator1

            // 

            this.lblSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.lblSeparator1.Location = new System.Drawing.Point(50, 110);

            this.lblSeparator1.Name = "lblSeparator1";

            this.lblSeparator1.Size = new System.Drawing.Size(700, 2);

            this.lblSeparator1.TabIndex = 2;

            // 

            // lblOrderNumber

            // 

            this.lblOrderNumber.AutoSize = true;

            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            this.lblOrderNumber.Location = new System.Drawing.Point(50, 130);

            this.lblOrderNumber.Name = "lblOrderNumber";

            this.lblOrderNumber.Size = new System.Drawing.Size(183, 21);

            this.lblOrderNumber.TabIndex = 3;

            this.lblOrderNumber.Text = "Замовлення № 000001";

            // 

            // lblOrderDate

            // 

            this.lblOrderDate.AutoSize = true;

            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblOrderDate.Location = new System.Drawing.Point(50, 160);

            this.lblOrderDate.Name = "lblOrderDate";

            this.lblOrderDate.Size = new System.Drawing.Size(217, 19);

            this.lblOrderDate.TabIndex = 4;

            this.lblOrderDate.Text = "Дата: 01.01.2025 12:00:00";

            // 

            // lblCustomer

            // 

            this.lblCustomer.AutoSize = true;

            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblCustomer.Location = new System.Drawing.Point(50, 185);

            this.lblCustomer.Name = "lblCustomer";

            this.lblCustomer.Size = new System.Drawing.Size(250, 19);

            this.lblCustomer.TabIndex = 5;

            this.lblCustomer.Text = "Покупець: Іванов Іван Іванович";

            // 

            // lblSeparator2

            // 

            this.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.lblSeparator2.Location = new System.Drawing.Point(50, 220);

            this.lblSeparator2.Name = "lblSeparator2";

            this.lblSeparator2.Size = new System.Drawing.Size(700, 2);

            this.lblSeparator2.TabIndex = 6;

            // 

            // dataGridViewItems

            // 

            this.dataGridViewItems.AllowUserToAddRows = false;

            this.dataGridViewItems.AllowUserToDeleteRows = false;

            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;

            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {

            this.colName,

            this.colQuantity,

            this.colPrice,

            this.colTotal});

            this.dataGridViewItems.Location = new System.Drawing.Point(50, 240);

            this.dataGridViewItems.Name = "dataGridViewItems";

            this.dataGridViewItems.ReadOnly = true;

            this.dataGridViewItems.RowHeadersVisible = false;

            this.dataGridViewItems.RowTemplate.Height = 30;

            this.dataGridViewItems.Size = new System.Drawing.Size(700, 450);

            this.dataGridViewItems.TabIndex = 7;

            // 

            // colName

            // 

            this.colName.HeaderText = "Найменування";

            this.colName.Name = "colName";

            this.colName.ReadOnly = true;

            this.colName.Width = 350;

            // 

            // colQuantity

            // 

            this.colQuantity.HeaderText = "К-сть";

            this.colQuantity.Name = "colQuantity";

            this.colQuantity.ReadOnly = true;

            this.colQuantity.Width = 70;

            // 

            // colPrice

            // 

            this.colPrice.HeaderText = "Ціна";

            this.colPrice.Name = "colPrice";

            this.colPrice.ReadOnly = true;

            this.colPrice.Width = 130;

            // 

            // colTotal

            // 

            this.colTotal.HeaderText = "Сума";

            this.colTotal.Name = "colTotal";

            this.colTotal.ReadOnly = true;

            this.colTotal.Width = 130;

            // 

            // lblSeparator3

            // 

            this.lblSeparator3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.lblSeparator3.Location = new System.Drawing.Point(50, 700);

            this.lblSeparator3.Name = "lblSeparator3";

            this.lblSeparator3.Size = new System.Drawing.Size(700, 2);

            this.lblSeparator3.TabIndex = 8;

            // 

            // lblSubtotal

            // 

            this.lblSubtotal.AutoSize = true;

            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.lblSubtotal.Location = new System.Drawing.Point(500, 720);

            this.lblSubtotal.Name = "lblSubtotal";

            this.lblSubtotal.Size = new System.Drawing.Size(154, 20);

            this.lblSubtotal.TabIndex = 9;

            this.lblSubtotal.Text = "Проміжна сума: 0.00 грн";

            // 

            // lblTotal

            // 

            this.lblTotal.AutoSize = true;

            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);

            this.lblTotal.Location = new System.Drawing.Point(500, 750);

            this.lblTotal.Name = "lblTotal";

            this.lblTotal.Size = new System.Drawing.Size(178, 25);

            this.lblTotal.TabIndex = 10;

            this.lblTotal.Text = "ВСЬОГО: 0.00 грн";

            // 

            // lblThankYou

            // 

            this.lblThankYou.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);

            this.lblThankYou.ForeColor = System.Drawing.Color.Gray;

            this.lblThankYou.Location = new System.Drawing.Point(0, 800);

            this.lblThankYou.Name = "lblThankYou";

            this.lblThankYou.Size = new System.Drawing.Size(800, 25);

            this.lblThankYou.TabIndex = 11;

            this.lblThankYou.Text = "Дякуємо за покупку! Гарного дня!";

            this.lblThankYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 

            // btnPrint

            // 

            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));

            this.btnPrint.FlatAppearance.BorderSize = 0;

            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnPrint.ForeColor = System.Drawing.Color.White;

            this.btnPrint.Location = new System.Drawing.Point(50, 970);

            this.btnPrint.Name = "btnPrint";

            this.btnPrint.Size = new System.Drawing.Size(250, 45);

            this.btnPrint.TabIndex = 2;

            this.btnPrint.Text = "🖨️ Роздрукувати";

            this.btnPrint.UseVisualStyleBackColor = false;

            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // 

            // btnSave

            // 

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));

            this.btnSave.FlatAppearance.BorderSize = 0;

            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnSave.ForeColor = System.Drawing.Color.White;

            this.btnSave.Location = new System.Drawing.Point(325, 970);

            this.btnSave.Name = "btnSave";

            this.btnSave.Size = new System.Drawing.Size(250, 45);

            this.btnSave.TabIndex = 3;

            this.btnSave.Text = "💾 Зберегти як PDF";

            this.btnSave.UseVisualStyleBackColor = false;

            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 

            // btnClose

            // 

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));

            this.btnClose.FlatAppearance.BorderSize = 0;

            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnClose.ForeColor = System.Drawing.Color.White;

            this.btnClose.Location = new System.Drawing.Point(600, 970);

            this.btnClose.Name = "btnClose";

            this.btnClose.Size = new System.Drawing.Size(250, 45);

            this.btnClose.TabIndex = 4;

            this.btnClose.Text = "Закрити";

            this.btnClose.UseVisualStyleBackColor = false;

            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 

            // ReceiptForm

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));

            this.ClientSize = new System.Drawing.Size(900, 1030);

            this.Controls.Add(this.btnClose);

            this.Controls.Add(this.btnSave);

            this.Controls.Add(this.btnPrint);

            this.Controls.Add(this.panelReceipt);

            this.Controls.Add(this.panelHeader);

            this.Name = "ReceiptForm";

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Чек замовлення";

            this.panelHeader.ResumeLayout(false);

            this.panelHeader.PerformLayout();

            this.panelReceipt.ResumeLayout(false);

            this.panelReceipt.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();

            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.Panel panelHeader;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelReceipt;

        private System.Windows.Forms.Label lblStoreName;

        private System.Windows.Forms.Label lblStoreInfo;

        private System.Windows.Forms.Label lblSeparator1;

        private System.Windows.Forms.Label lblOrderNumber;

        private System.Windows.Forms.Label lblOrderDate;

        private System.Windows.Forms.Label lblCustomer;

        private System.Windows.Forms.Label lblSeparator2;

        private System.Windows.Forms.DataGridView dataGridViewItems;

        private System.Windows.Forms.DataGridViewTextBoxColumn colName;

        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;

        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;

        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;

        private System.Windows.Forms.Label lblSeparator3;

        private System.Windows.Forms.Label lblSubtotal;

        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Label lblThankYou;

        private System.Windows.Forms.Button btnPrint;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnClose;

    }

}