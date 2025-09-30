namespace Computer_Parts_Store.Forms
{
    partial class MainForm
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.btnPCBuilder = new System.Windows.Forms.Button();
            this.btnPrebuilt = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(528, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Магазин комп'ютерних комплектуючих";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(25, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Підберіть ідеальну конфігурацію для вашого ПК";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSalesHistory);
            this.panelMenu.Controls.Add(this.btnCart);
            this.panelMenu.Controls.Add(this.btnPrebuilt);
            this.panelMenu.Controls.Add(this.btnPCBuilder);
            this.panelMenu.Controls.Add(this.btnCatalog);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 600);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCatalog
            // 
            this.btnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCatalog.FlatAppearance.BorderSize = 0;
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCatalog.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.Location = new System.Drawing.Point(0, 20);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(250, 60);
            this.btnCatalog.TabIndex = 0;
            this.btnCatalog.Text = "📦 Каталог товарів";
            this.btnCatalog.UseVisualStyleBackColor = false;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            this.btnCatalog.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnCatalog.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnPCBuilder
            // 
            this.btnPCBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPCBuilder.FlatAppearance.BorderSize = 0;
            this.btnPCBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCBuilder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPCBuilder.ForeColor = System.Drawing.Color.White;
            this.btnPCBuilder.Location = new System.Drawing.Point(0, 90);
            this.btnPCBuilder.Name = "btnPCBuilder";
            this.btnPCBuilder.Size = new System.Drawing.Size(250, 60);
            this.btnPCBuilder.TabIndex = 1;
            this.btnPCBuilder.Text = "🔧 Збірка ПК";
            this.btnPCBuilder.UseVisualStyleBackColor = false;
            this.btnPCBuilder.Click += new System.EventHandler(this.btnPCBuilder_Click);
            this.btnPCBuilder.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnPCBuilder.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnPrebuilt
            // 
            this.btnPrebuilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPrebuilt.FlatAppearance.BorderSize = 0;
            this.btnPrebuilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrebuilt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrebuilt.ForeColor = System.Drawing.Color.White;
            this.btnPrebuilt.Location = new System.Drawing.Point(0, 160);
            this.btnPrebuilt.Name = "btnPrebuilt";
            this.btnPrebuilt.Size = new System.Drawing.Size(250, 60);
            this.btnPrebuilt.TabIndex = 2;
            this.btnPrebuilt.Text = "💻 Готові ПК";
            this.btnPrebuilt.UseVisualStyleBackColor = false;
            this.btnPrebuilt.Click += new System.EventHandler(this.btnPrebuilt_Click);
            this.btnPrebuilt.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnPrebuilt.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(0, 230);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(250, 60);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "🛒 Кошик";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            this.btnCart.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnCart.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSalesHistory.FlatAppearance.BorderSize = 0;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.Location = new System.Drawing.Point(0, 300);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(250, 60);
            this.btnSalesHistory.TabIndex = 4;
            this.btnSalesHistory.Text = "📊 Історія продажів";
            this.btnSalesHistory.UseVisualStyleBackColor = false;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            this.btnSalesHistory.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.btnSalesHistory.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(25, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "🚪 Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.lblInfo);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(950, 600);
            this.panelContent.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(262, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Ласкаво просимо!";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblInfo.Location = new System.Drawing.Point(50, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(850, 400);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Оберіть розділ з меню:\r\n\r\n📦 Каталог товарів - перегляд всього асортименту\r\n🔧 Збірка ПК - створіть власну конфігурацію\r\n💻 Готові ПК - готові збірки від експертів\r\n🛒 Кошик - оформлення замовлення\r\n📊 Історія продажів - звіти та аналітика";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин комп'ютерних комплектуючих";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnPCBuilder;
        private System.Windows.Forms.Button btnPrebuilt;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInfo;
    }
}