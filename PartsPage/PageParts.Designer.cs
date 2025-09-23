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
            label1 = new Label();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
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
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "PageParts";
            ShowIcon = false;
            Text = "Parts Page";
            WindowState = FormWindowState.Maximized;
            Load += PageParts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
