using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Computer_Parts_Store.Data;
using Computer_Parts_Store.Models;

namespace Computer_Parts_Store
{
    public partial class Form1 : Form
    {
        private Dictionary<string, PictureBox> layers = new();
        private Dictionary<string, Product> selectedProducts = new();
        private Computer_Parts_StoreContext db = new();
        private Dictionary<string, Category> categories = new();
        private Label labelTotalPrice;

        private FlowLayoutPanel categoryPanel;
        private FlowLayoutPanel productListPanel;
        private Button backButton;

        private readonly string[] layerOrder = {
            "case", "motherboard", "ram", "psu", "ssd", "hdd", "cpu", "cooler", "gpu",
            "keyboard", "mouse", "monitor"
        };

        public Form1()
        {
            InitializeComponent();
            this.Text = "Конфігуратор ПК";
            this.Size = new Size(1200, 850);
            this.BackColor = Color.FromArgb(30, 30, 30);

            
            LoadCategories();
            SetupCategoryButtons();
            SetupProductListPanel();
            SetupTotalPriceLabel();
        }

        
        private void LoadCategories()
        {
            categories = db.Categories.ToDictionary(c => c.Name, c => c);
        }

        private void SetupCategoryButtons()
        {
            categoryPanel = new FlowLayoutPanel
            {
                Location = new Point(20, 20),
                Size = new Size(1100, 400),
                AutoScroll = false,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
            };
            this.Controls.Add(categoryPanel);

            foreach (var cat in categories.Values)
            {
                string layerName = MapCategoryToLayer(cat.Name);
                if (!layerOrder.Contains(layerName)) continue;

                Panel panel = new Panel
                {
                    Size = new Size(140, 190),
                    BackColor = Color.FromArgb(50, 50, 50),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(10)
                };

                PictureBox icon = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point((panel.Width - 100) / 2, 15),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                string iconPath = $"Images/Icon/{layerName}.png";
                if (File.Exists(iconPath))
                    icon.Image = Image.FromFile(iconPath);

                Label label = new Label
                {
                    Text = cat.Name,
                    ForeColor = Color.White,
                    Size = new Size(panel.Width, 50),
                    Location = new Point(0, 125),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    AutoSize = false,
                    AutoEllipsis = true
                };

                panel.Controls.Add(icon);
                panel.Controls.Add(label);
                categoryPanel.Controls.Add(panel);

                panel.Click += (s, e) => ShowProductList(cat, layerName);
                icon.Click += (s, e) => ShowProductList(cat, layerName);
                label.Click += (s, e) => ShowProductList(cat, layerName);
            }
        }



        private void SetupProductListPanel()
        {
            productListPanel = new FlowLayoutPanel
            {
                Location = new Point(20, 20),
                Size = new Size(1100, 700),
                AutoScroll = true,
                Visible = false
            };
            this.Controls.Add(productListPanel);

            backButton = new Button
            {
                Text = "← Назад",
                Size = new Size(120, 40),
                Location = new Point((this.ClientSize.Width - 120) / 2, 730),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Visible = false
            };
            backButton.FlatAppearance.BorderSize = 0;

            backButton.Click += (s, e) =>
            {
                productListPanel.Visible = false;
                backButton.Visible = false;
                categoryPanel.Visible = true;
            };
            this.Controls.Add(backButton);
        }

        private void SetupTotalPriceLabel()
        {
            labelTotalPrice = new Label
            {
                Text = "Загальна ціна: 0 грн",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(30, this.Height - 80),
                AutoSize = true
            };
            this.Controls.Add(labelTotalPrice);
        }

        private void ShowProductList(Category category, string layerName)
        {
            categoryPanel.Visible = false;
            productListPanel.Controls.Clear();
            productListPanel.Visible = true;
            backButton.Visible = true;

            var products = db.Products.Where(p => p.CategoryId == category.Id).ToList();

            foreach (var product in products)
            {
                Panel item = new Panel
                {
                    Size = new Size(180, 220),
                    BackColor = Color.FromArgb(60, 60, 60),
                    Margin = new Padding(10)
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(160, 120),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10)
                };

                string safeArticle = product.Article?.Trim();
                string[] extensions = new[] { ".jpg", ".jpeg", ".png" };
                string productImagePath = null;

                foreach (var ext in extensions)
                {
                    string path = Path.Combine(Application.StartupPath, "Images", "Products", $"{safeArticle}{ext}");
                    if (File.Exists(path))
                    {
                        productImagePath = path;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(productImagePath))
                {
                    try
                    {
                        pic.Image = Image.FromFile(productImagePath);
                    }
                    catch
                    {
                        pic.Image = new Bitmap(160, 120);
                    }
                }
                else
                {
                    pic.Image = new Bitmap(160, 120);
                }

                Label name = new Label
                {
                    Text = product.Name,
                    ForeColor = Color.White,
                    Location = new Point(10, 140),
                    Size = new Size(160, 20)
                };

                Label price = new Label
                {
                    Text = $"{product.Price} грн",
                    ForeColor = Color.LightGreen,
                    Location = new Point(10, 160),
                    Size = new Size(160, 20)
                };

                Button select = new Button
                {
                    Text = "Вибрати",
                    Location = new Point(40, 185),
                    Size = new Size(100, 25)
                };

                select.Click += (s, e) =>
                {
                    selectedProducts[layerName] = product;
                    
                    UpdateTotalPrice();
                    productListPanel.Visible = false;
                    backButton.Visible = false;
                    categoryPanel.Visible = true;
                };
                 
                item.Controls.Add(pic);
                item.Controls.Add(name);
                item.Controls.Add(price);
                item.Controls.Add(select);
                productListPanel.Controls.Add(item);
            }
        }

        

        private void UpdateTotalPrice()
        {
            decimal total = selectedProducts.Values.Sum(p => p.Price);
            labelTotalPrice.Text = $"Загальна ціна: {total} грн";
        }

        private string MapCategoryToLayer(string category)
        {
            category = category.Trim().ToLower();

            if (category.Contains("корпус")) return "case";
            if (category.Contains("материн")) return "motherboard";
            if (category.Contains("оперативна")) return "ram";
            if (category.Contains("живлення") || category.Contains("psu")) return "psu";
            if (category.Contains("ssd")) return "ssd";
            if (category.Contains("hdd")) return "hdd";
            if (category.Contains("cpu") || category.Contains("процесор")) return "cpu";
            if (category.Contains("кулер") || category.Contains("охолодження") || category.Contains("рідинне") || category.Contains("повітряне")) return "cooler";
            if (category.Contains("gpu") || category.Contains("відеокарта")) return "gpu";
            if (category.Contains("клавіатура")) return "keyboard";
            if (category.Contains("миша")) return "mouse";
            if (category.Contains("монітор")) return "monitor";
            return "empty";
        }
    }
}
