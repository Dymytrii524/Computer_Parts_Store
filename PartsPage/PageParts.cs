using Computer_Parts_Store.Data;
using Computer_Parts_Store.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProductSearch();
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            ProductSearch();
        }
        private void PriceChanged(object sender, EventArgs e)
        {
            if (priceMin.Value > priceMax.Value)
                priceMax.Value = priceMin.Value;
            ProductSearch();
        }

        private void price_CheckedChanged(object sender, EventArgs e)
        {
            if (price.Checked)
            {
                priceMin.Enabled = true;
                priceMax.Enabled = true;
            }
            else
            {
                priceMin.Enabled = false;
                priceMax.Enabled = false;
                priceMin.Value = 0;
                priceMax.Value = 0;
            }
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 2)
                btnCompare.Enabled = true;
            else
                btnCompare.Enabled = false;
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            Compare();
        }
        private void ProductSearch()
        {
            try
            {
                string searchText = textBox1.Text.Trim();

                using (var context = new Computer_Parts_StoreContext())
                {
                    var query = context.Products.Include(p => p.Category).AsQueryable();

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query = query.Where(p =>
                            (name.Checked && p.Name.Contains(searchText)) ||
                            (desc.Checked && p.Description != null && p.Description.Contains(searchText)) ||
                            (manufacturer.Checked && p.Manufacturer != null && p.Manufacturer.Contains(searchText)) ||
                            (model.Checked && p.Model != null && p.Model.Contains(searchText)) ||
                            (category.Checked && p.Category != null && p.Category.Name.Contains(searchText)) ||
                            (article.Checked && p.Article != null && p.Article.Contains(searchText)) ||
                            (spec.Checked && p.Specification != null && p.Specification.Contains(searchText)) ||
                            (color.Checked && p.Color != null && p.Color.Contains(searchText))
                        );
                    }

                    if (price.Checked)
                    {
                        query = query.Where(p => p.Price >= priceMin.Value && p.Price <= priceMax.Value);
                    }

                    ListLoad(query.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Compare()
        {
            try
            {
                using (var context = new Computer_Parts_StoreContext())
                {
                    var i1 = listView1.SelectedItems[0];
                    var i2 = listView1.SelectedItems[1];

                    string productName1 = i1.Text;
                    string productName2 = i2.Text;

                    var product1 = context.Products
                        .Include(p => p.Category)
                        .FirstOrDefault(p => p.Name == productName1);

                    var product2 = context.Products
                        .Include(p => p.Category)
                        .FirstOrDefault(p => p.Name == productName2);

                    if (product1 == null || product2 == null)
                    {
                        MessageBox.Show("One or both selected products could not be found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (product1.Category?.Name != product2.Category?.Name)
                    {
                        MessageBox.Show("Cannot compare products from different categories.", "oops.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var compareForm = new Compare(product1, product2);
                    compareForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error comparing products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
