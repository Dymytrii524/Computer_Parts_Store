using Microsoft.EntityFrameworkCore;
using Computer_Parts_Store.Data;
using Computer_Parts_Store.Models;

namespace PartsPage
{
    public partial class PageParts : Form
    {
        public PageParts()
        {
            InitializeComponent();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);

            string imagePath = Path.Combine(Application.StartupPath, "IMG", "0.png");
            if (File.Exists(imagePath))
            {
                imageList.Images.Add(Image.FromFile(imagePath));
            }
            else
            {
                Bitmap placeholder = new Bitmap(64, 64);
                using (Graphics g = Graphics.FromImage(placeholder))
                {
                    g.Clear(Color.Indigo);
                    g.DrawRectangle(Pens.Black, 0, 0, 63, 63);
                }
                imageList.Images.Add(placeholder);
            }

            listView1.LargeImageList = imageList;
            listView1.SmallImageList = imageList;
        }

        private void ListLoad(List<Product> parts)
        {
            try
            {
                using (var context = new Computer_Parts_StoreContext())
                {
                    if (parts == null)
                        parts = context.Products.Include(p => p.Category).ToList();

                    listView1.Items.Clear();

                    foreach (var part in parts)
                    {
                        var item = new ListViewItem(part.Name);
                        item.SubItems.Add(part.Category != null ? $"{part.Category.Name}" : "N/A");
                        item.SubItems.Add(part.Article != null ? $"{part.Article}" : "N/A");
                        item.SubItems.Add(part.Price != null ? $"{part.Price}" : "N/A");
                        item.SubItems.Add(part.Description != null ? $"{part.Description}" : "N/A");
                        item.SubItems.Add(part.StockQuantity != null ? $"{part.StockQuantity}" : "N/A");
                        item.SubItems.Add(part.Manufacturer != null ? $"{part.Manufacturer}" : "N/A");
                        item.SubItems.Add(part.Model != null ? $"{part.Model}" : "N/A");
                        item.SubItems.Add(part.Specification != null ? $"{part.Specification}" : "N/A");
                        item.SubItems.Add(part.Color != null ? $"{part.Color}" : "N/A");
                        item.SubItems.Add(part.Dimensions != null ? $"{part.Dimensions}" : "N/A");
                        item.SubItems.Add(part.Weight != null ? $"{part.Weight}" : "N/A");
                        item.SubItems.Add(part.WarrantyMonths != null ? $"{part.WarrantyMonths}" : "N/A");
                        item.ImageIndex = 0;
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PageParts_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("Article", 200);
            listView1.Columns.Add("Price", 200);
            listView1.Columns.Add("Desc", 200);
            listView1.Columns.Add("Quantity", 10);
            listView1.Columns.Add("Manufacturer", 200);
            listView1.Columns.Add("Model", 200);
            listView1.Columns.Add("Specification", 200);
            listView1.Columns.Add("Color", 200);
            listView1.Columns.Add("Dimensions", 200);
            listView1.Columns.Add("Weight", 200);
            listView1.Columns.Add("Warranty", 200);

            ListLoad(null);
            SetView(View.LargeIcon);
        }
        private void SetView(View view)
        {
            listView1.View = view;

            button1.Enabled = true;
            button2.Enabled = true;

            switch (view)
            {
                case View.LargeIcon:
                    button1.Enabled = false;
                    break;
                case View.Details:
                    button2.Enabled = false;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e) => SetView(View.LargeIcon);
        private void button2_Click(object sender, EventArgs e) => SetView(View.Details);
    }
}
