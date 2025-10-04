namespace Computer_Parts_Store.Forms
{
    partial class ProductDetailsForm
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
            this.panelProductInfo = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblArticleValue = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSelectQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Деталі товару";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(700, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelProductInfo
            // 
            this.panelProductInfo.BackColor = System.Drawing.Color.White;
            this.panelProductInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductInfo.Controls.Add(this.btnAddToCart);
            this.panelProductInfo.Controls.Add(this.lblSelectQuantity);
            this.panelProductInfo.Controls.Add(this.numericQuantity);
            this.panelProductInfo.Controls.Add(this.txtDescription);
            this.panelProductInfo.Controls.Add(this.lblDescription);
            this.panelProductInfo.Controls.Add(this.lblQuantityValue);
            this.panelProductInfo.Controls.Add(this.lblQuantity);
            this.panelProductInfo.Controls.Add(this.lblPriceValue);
            this.panelProductInfo.Controls.Add(this.lblPrice);
            this.panelProductInfo.Controls.Add(this.lblCategoryValue);
            this.panelProductInfo.Controls.Add(this.lblCategory);
            this.panelProductInfo.Controls.Add(this.lblArticleValue);
            this.panelProductInfo.Controls.Add(this.lblArticle);
            this.panelProductInfo.Controls.Add(this.lblProductName);
            this.panelProductInfo.Location = new System.Drawing.Point(30, 100);
            this.panelProductInfo.Name = "panelProductInfo";
            this.panelProductInfo.Size = new System.Drawing.Size(740, 650);
            this.panelProductInfo.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(20, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(700, 40);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Назва товару";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblArticle.ForeColor = System.Drawing.Color.Gray;
            this.lblArticle.Location = new System.Drawing.Point(20, 75);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(71, 20);
            this.lblArticle.TabIndex = 1;
            this.lblArticle.Text = "Артикул:";
            // 
            // lblArticleValue
            // 
            this.lblArticleValue.AutoSize = true;
            this.lblArticleValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblArticleValue.Location = new System.Drawing.Point(100, 75);
            this.lblArticleValue.Name = "lblArticleValue";
            this.lblArticleValue.Size = new System.Drawing.Size(72, 20);
            this.lblArticleValue.TabIndex = 2;
            this.lblArticleValue.Text = "ART0001";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblCategory.Location = new System.Drawing.Point(20, 105);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Категорія:";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoryValue.Location = new System.Drawing.Point(110, 105);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(87, 20);
            this.lblCategoryValue.TabIndex = 4;
            this.lblCategoryValue.Text = "Процесори";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(20, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 25);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Ціна:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblPriceValue.Location = new System.Drawing.Point(20, 180);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(160, 37);
            this.lblPriceValue.TabIndex = 6;
            this.lblPriceValue.Text = "0.00 грн";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblQuantity.ForeColor = System.Drawing.Color.Gray;
            this.lblQuantity.Location = new System.Drawing.Point(20, 235);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 20);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "На складі:";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantityValue.Location = new System.Drawing.Point(110, 235);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(53, 20);
            this.lblQuantityValue.TabIndex = 8;
            this.lblQuantityValue.Text = "0 шт.";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(20, 280);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(52, 21);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Опис:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(20, 310);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(700, 200);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numericQuantity.Location = new System.Drawing.Point(170, 530);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(100, 29);
            this.numericQuantity.TabIndex = 11;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSelectQuantity
            // 
            this.lblSelectQuantity.AutoSize = true;
            this.lblSelectQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectQuantity.Location = new System.Drawing.Point(20, 535);
            this.lblSelectQuantity.Name = "lblSelectQuantity";
            this.lblSelectQuantity.Size = new System.Drawing.Size(144, 20);
            this.lblSelectQuantity.TabIndex = 12;
            this.lblSelectQuantity.Text = "Виберіть кількість:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(20, 580);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(700, 50);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "🛒 Додати до кошика";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.panelProductInfo);
            this.Controls.Add(this.panelHeader);
            this.Name = "ProductDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Деталі товару";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelProductInfo.ResumeLayout(false);
            this.panelProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelProductInfo;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblArticleValue;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label lblSelectQuantity;
        private System.Windows.Forms.Button btnAddToCart;
    }
}