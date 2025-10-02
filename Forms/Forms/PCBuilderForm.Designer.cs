namespace Computer_Parts_Store.Forms
{
    partial class PCBuilderForm
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
            this.panelComponents = new System.Windows.Forms.Panel();
            this.lblComponents = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cmbCPU = new System.Windows.Forms.ComboBox();
            this.lblGPU = new System.Windows.Forms.Label();
            this.cmbGPU = new System.Windows.Forms.ComboBox();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.cmbMotherboard = new System.Windows.Forms.ComboBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.lblPSU = new System.Windows.Forms.Label();
            this.cmbPSU = new System.Windows.Forms.ComboBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.cmbCase = new System.Windows.Forms.ComboBox();
            this.lblCooling = new System.Windows.Forms.Label();
            this.cmbCooling = new System.Windows.Forms.ComboBox();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtBuildSummary = new System.Windows.Forms.RichTextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClearBuild = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelComponents.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(386, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Конструктор збірки комп'ютера";
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
            // panelComponents
            // 
            this.panelComponents.BackColor = System.Drawing.Color.White;
            this.panelComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelComponents.Controls.Add(this.cmbCooling);
            this.panelComponents.Controls.Add(this.lblCooling);
            this.panelComponents.Controls.Add(this.cmbCase);
            this.panelComponents.Controls.Add(this.lblCase);
            this.panelComponents.Controls.Add(this.cmbPSU);
            this.panelComponents.Controls.Add(this.lblPSU);
            this.panelComponents.Controls.Add(this.cmbStorage);
            this.panelComponents.Controls.Add(this.lblStorage);
            this.panelComponents.Controls.Add(this.cmbRAM);
            this.panelComponents.Controls.Add(this.lblRAM);
            this.panelComponents.Controls.Add(this.cmbMotherboard);
            this.panelComponents.Controls.Add(this.lblMotherboard);
            this.panelComponents.Controls.Add(this.cmbGPU);
            this.panelComponents.Controls.Add(this.lblGPU);
            this.panelComponents.Controls.Add(this.cmbCPU);
            this.panelComponents.Controls.Add(this.lblCPU);
            this.panelComponents.Controls.Add(this.lblComponents);
            this.panelComponents.Location = new System.Drawing.Point(20, 90);
            this.panelComponents.Name = "panelComponents";
            this.panelComponents.Size = new System.Drawing.Size(900, 660);
            this.panelComponents.TabIndex = 1;
            // 
            // lblComponents
            // 
            this.lblComponents.AutoSize = true;
            this.lblComponents.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblComponents.Location = new System.Drawing.Point(15, 15);
            this.lblComponents.Name = "lblComponents";
            this.lblComponents.Size = new System.Drawing.Size(239, 25);
            this.lblComponents.TabIndex = 0;
            this.lblComponents.Text = "Виберіть комплектуючі:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCPU.Location = new System.Drawing.Point(20, 60);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(85, 20);
            this.lblCPU.TabIndex = 1;
            this.lblCPU.Text = "Процесор:";
            // 
            // cmbCPU
            // 
            this.cmbCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCPU.FormattingEnabled = true;
            this.cmbCPU.Location = new System.Drawing.Point(20, 85);
            this.cmbCPU.Name = "cmbCPU";
            this.cmbCPU.Size = new System.Drawing.Size(850, 25);
            this.cmbCPU.TabIndex = 2;
            this.cmbCPU.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGPU.Location = new System.Drawing.Point(20, 125);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(95, 20);
            this.lblGPU.TabIndex = 3;
            this.lblGPU.Text = "Відеокарта:";
            // 
            // cmbGPU
            // 
            this.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGPU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGPU.FormattingEnabled = true;
            this.cmbGPU.Location = new System.Drawing.Point(20, 150);
            this.cmbGPU.Name = "cmbGPU";
            this.cmbGPU.Size = new System.Drawing.Size(850, 25);
            this.cmbGPU.TabIndex = 4;
            this.cmbGPU.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMotherboard.Location = new System.Drawing.Point(20, 190);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(145, 20);
            this.lblMotherboard.TabIndex = 5;
            this.lblMotherboard.Text = "Материнська плата:";
            // 
            // cmbMotherboard
            // 
            this.cmbMotherboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotherboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMotherboard.FormattingEnabled = true;
            this.cmbMotherboard.Location = new System.Drawing.Point(20, 215);
            this.cmbMotherboard.Name = "cmbMotherboard";
            this.cmbMotherboard.Size = new System.Drawing.Size(850, 25);
            this.cmbMotherboard.TabIndex = 6;
            this.cmbMotherboard.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRAM.Location = new System.Drawing.Point(20, 255);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(148, 20);
            this.lblRAM.TabIndex = 7;
            this.lblRAM.Text = "Оперативна пам'ять:";
            // 
            // cmbRAM
            // 
            this.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(20, 280);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(850, 25);
            this.cmbRAM.TabIndex = 8;
            this.cmbRAM.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStorage.Location = new System.Drawing.Point(20, 320);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(112, 20);
            this.lblStorage.TabIndex = 9;
            this.lblStorage.Text = "Накопичувач:";
            // 
            // cmbStorage
            // 
            this.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(20, 345);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(850, 25);
            this.cmbStorage.TabIndex = 10;
            this.cmbStorage.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblPSU
            // 
            this.lblPSU.AutoSize = true;
            this.lblPSU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPSU.Location = new System.Drawing.Point(20, 385);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(125, 20);
            this.lblPSU.TabIndex = 11;
            this.lblPSU.Text = "Блок живлення:";
            // 
            // cmbPSU
            // 
            this.cmbPSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPSU.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPSU.FormattingEnabled = true;
            this.cmbPSU.Location = new System.Drawing.Point(20, 410);
            this.cmbPSU.Name = "cmbPSU";
            this.cmbPSU.Size = new System.Drawing.Size(850, 25);
            this.cmbPSU.TabIndex = 12;
            this.cmbPSU.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCase.Location = new System.Drawing.Point(20, 450);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(69, 20);
            this.lblCase.TabIndex = 13;
            this.lblCase.Text = "Корпус:";
            // 
            // cmbCase
            // 
            this.cmbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCase.FormattingEnabled = true;
            this.cmbCase.Location = new System.Drawing.Point(20, 475);
            this.cmbCase.Name = "cmbCase";
            this.cmbCase.Size = new System.Drawing.Size(850, 25);
            this.cmbCase.TabIndex = 14;
            this.cmbCase.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // lblCooling
            // 
            this.lblCooling.AutoSize = true;
            this.lblCooling.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCooling.Location = new System.Drawing.Point(20, 515);
            this.lblCooling.Name = "lblCooling";
            this.lblCooling.Size = new System.Drawing.Size(163, 20);
            this.lblCooling.TabIndex = 15;
            this.lblCooling.Text = "Система охолодження:";
            // 
            // cmbCooling
            // 
            this.cmbCooling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCooling.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCooling.FormattingEnabled = true;
            this.cmbCooling.Location = new System.Drawing.Point(20, 540);
            this.cmbCooling.Name = "cmbCooling";
            this.cmbCooling.Size = new System.Drawing.Size(850, 25);
            this.cmbCooling.TabIndex = 16;
            this.cmbCooling.SelectedIndexChanged += new System.EventHandler(this.Component_SelectedIndexChanged);
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.Controls.Add(this.btnClearBuild);
            this.panelSummary.Controls.Add(this.btnAddToCart);
            this.panelSummary.Controls.Add(this.lblTotalPriceValue);
            this.panelSummary.Controls.Add(this.lblTotalPrice);
            this.panelSummary.Controls.Add(this.txtBuildSummary);
            this.panelSummary.Controls.Add(this.lblSummary);
            this.panelSummary.Location = new System.Drawing.Point(940, 90);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(440, 660);
            this.panelSummary.TabIndex = 2;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Location = new System.Drawing.Point(15, 15);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(174, 25);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Ваша конфігурація:";
            // 
            // txtBuildSummary
            // 
            this.txtBuildSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuildSummary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuildSummary.Location = new System.Drawing.Point(15, 55);
            this.txtBuildSummary.Name = "txtBuildSummary";
            this.txtBuildSummary.ReadOnly = true;
            this.txtBuildSummary.Size = new System.Drawing.Size(410, 450);
            this.txtBuildSummary.TabIndex = 1;
            this.txtBuildSummary.Text = "";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 520);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(140, 25);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Загальна ціна:";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(15, 550);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(87, 30);
            this.lblTotalPriceValue.TabIndex = 3;
            this.lblTotalPriceValue.Text = "0.00 грн";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(15, 595);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(200, 45);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "🛒 Додати до кошика";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnClearBuild
            // 
            this.btnClearBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClearBuild.FlatAppearance.BorderSize = 0;
            this.btnClearBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBuild.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearBuild.ForeColor = System.Drawing.Color.White;
            this.btnClearBuild.Location = new System.Drawing.Point(225, 595);
            this.btnClearBuild.Name = "btnClearBuild";
            this.btnClearBuild.Size = new System.Drawing.Size(200, 45);
            this.btnClearBuild.TabIndex = 5;
            this.btnClearBuild.Text = "🗑️ Очистити збірку";
            this.btnClearBuild.UseVisualStyleBackColor = false;
            this.btnClearBuild.Click += new System.EventHandler(this.btnClearBuild_Click);
            // 
            // PCBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 780);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelComponents);
            this.Controls.Add(this.panelHeader);
            this.Name = "PCBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Збірка комп'ютера";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelComponents.ResumeLayout(false);
            this.panelComponents.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelComponents;
        private System.Windows.Forms.Label lblComponents;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.ComboBox cmbCPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.ComboBox cmbGPU;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.ComboBox cmbMotherboard;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.ComboBox cmbPSU;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.ComboBox cmbCase;
        private System.Windows.Forms.Label lblCooling;
        private System.Windows.Forms.ComboBox cmbCooling;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.RichTextBox txtBuildSummary;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClearBuild;
    }
}