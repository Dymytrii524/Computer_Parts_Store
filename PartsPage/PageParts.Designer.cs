namespace PartsPage
{
    partial class PageParts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            name = new CheckBox();
            desc = new CheckBox();
            manufacturer = new CheckBox();
            model = new CheckBox();
            category = new CheckBox();
            article = new CheckBox();
            spec = new CheckBox();
            color = new CheckBox();
            priceMin = new NumericUpDown();
            priceMax = new NumericUpDown();
            price = new CheckBox();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)priceMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceMax).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(192, 192, 255);
            listView1.Location = new Point(12, 82);
            listView1.MaximumSize = new Size(100, 100);
            listView1.MinimumSize = new Size(1880, 928);
            listView1.Name = "listView1";
            listView1.Size = new Size(1880, 928);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(39, 38);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(57, 27);
            button2.Name = "button2";
            button2.Size = new Size(37, 38);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(671, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(1382, 8);
            label1.Name = "label1";
            label1.Size = new Size(466, 67);
            label1.TabIndex = 4;
            label1.Text = "PARTS PAGE TEST";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Checked = true;
            name.CheckState = CheckState.Checked;
            name.Location = new Point(110, 56);
            name.Name = "name";
            name.Size = new Size(58, 19);
            name.TabIndex = 5;
            name.Text = "Name";
            name.UseVisualStyleBackColor = true;
            name.CheckedChanged += CheckedChanged;
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(185, 56);
            desc.Name = "desc";
            desc.Size = new Size(51, 19);
            desc.TabIndex = 6;
            desc.Text = "Desc";
            desc.UseVisualStyleBackColor = true;
            desc.CheckedChanged += CheckedChanged;
            // 
            // manufacturer
            // 
            manufacturer.AutoSize = true;
            manufacturer.Location = new Point(256, 57);
            manufacturer.Name = "manufacturer";
            manufacturer.Size = new Size(98, 19);
            manufacturer.TabIndex = 7;
            manufacturer.Text = "Manufacturer";
            manufacturer.UseVisualStyleBackColor = true;
            manufacturer.CheckedChanged += CheckedChanged;
            // 
            // model
            // 
            model.AutoSize = true;
            model.Location = new Point(369, 57);
            model.Name = "model";
            model.Size = new Size(60, 19);
            model.TabIndex = 8;
            model.Text = "Model";
            model.UseVisualStyleBackColor = true;
            model.CheckedChanged += CheckedChanged;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Location = new Point(449, 56);
            category.Name = "category";
            category.Size = new Size(74, 19);
            category.TabIndex = 9;
            category.Text = "Category";
            category.UseVisualStyleBackColor = true;
            category.CheckedChanged += CheckedChanged;
            // 
            // article
            // 
            article.AutoSize = true;
            article.Location = new Point(552, 57);
            article.Name = "article";
            article.Size = new Size(60, 19);
            article.TabIndex = 10;
            article.Text = "Article";
            article.UseVisualStyleBackColor = true;
            article.CheckedChanged += CheckedChanged;
            // 
            // spec
            // 
            spec.AutoSize = true;
            spec.Location = new Point(649, 56);
            spec.Name = "spec";
            spec.Size = new Size(51, 19);
            spec.TabIndex = 11;
            spec.Text = "Spec";
            spec.UseVisualStyleBackColor = true;
            spec.CheckedChanged += CheckedChanged;
            // 
            // color
            // 
            color.AutoSize = true;
            color.Location = new Point(726, 57);
            color.Name = "color";
            color.Size = new Size(55, 19);
            color.TabIndex = 12;
            color.Text = "Color";
            color.UseVisualStyleBackColor = true;
            color.CheckedChanged += CheckedChanged;
            // 
            // priceMin
            // 
            priceMin.Enabled = false;
            priceMin.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceMin.Location = new Point(813, 28);
            priceMin.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            priceMin.Name = "priceMin";
            priceMin.Size = new Size(77, 23);
            priceMin.TabIndex = 15;
            priceMin.TextAlign = HorizontalAlignment.Center;
            priceMin.ValueChanged += PriceChanged;
            // 
            // priceMax
            // 
            priceMax.Enabled = false;
            priceMax.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            priceMax.Location = new Point(906, 28);
            priceMax.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            priceMax.Name = "priceMax";
            priceMax.Size = new Size(77, 23);
            priceMax.TabIndex = 16;
            priceMax.TextAlign = HorizontalAlignment.Center;
            priceMax.ValueChanged += PriceChanged;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(868, 57);
            price.Name = "price";
            price.Size = new Size(52, 19);
            price.TabIndex = 17;
            price.Text = "Price";
            price.UseVisualStyleBackColor = true;
            price.CheckedChanged += price_CheckedChanged;
            // 
            // sqlConnection1
            // 
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // PageParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1334, 582);
            Controls.Add(price);
            Controls.Add(priceMax);
            Controls.Add(priceMin);
            Controls.Add(color);
            Controls.Add(spec);
            Controls.Add(article);
            Controls.Add(category);
            Controls.Add(model);
            Controls.Add(manufacturer);
            Controls.Add(desc);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "PageParts";
            ShowIcon = false;
            Text = "Parts Page";
            WindowState = FormWindowState.Maximized;
            Load += PageParts_Load;
            ((System.ComponentModel.ISupportInitialize)priceMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private CheckBox name;
        private CheckBox desc;
        private CheckBox manufacturer;
        private CheckBox model;
        private CheckBox category;
        private CheckBox article;
        private CheckBox spec;
        private CheckBox color;
        private NumericUpDown priceMin;
        private NumericUpDown priceMax;
        private CheckBox price;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
