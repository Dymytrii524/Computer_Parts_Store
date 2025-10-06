﻿using Computer_Parts_Store.Data;
using Computer_Parts_Store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Computer_Parts_Store.Forms
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
            LoadImages();
            LoadCategories();
            LoadProducts(null);
        }
        private void LoadImages()
        {
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
                    g.Clear(Color.SteelBlue);
                    g.DrawRectangle(Pens.Black, 0, 0, 63, 63);
                }
                imageList.Images.Add(placeholder);
            }

            listView1.LargeImageList = imageList;
            listView1.SmallImageList = imageList;
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Add("Всі категорії");
            cmbCategory.Items.Add("Процесори");
            cmbCategory.Items.Add("Відеокарти");
            cmbCategory.Items.Add("Материнські плати");
            cmbCategory.Items.Add("Оперативна пам'ять");
            cmbCategory.Items.Add("Накопичувачі");
            cmbCategory.Items.Add("Блоки живлення");
            cmbCategory.Items.Add("Корпуси");
            cmbCategory.Items.Add("Системи охолодження");
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadProducts(List<Product>? parts)
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
        private void SearchProducts()
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                using (var context = new Computer_Parts_StoreContext())
                {
                    var query = context.Products.Include(p => p.Category).AsQueryable();

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query = query.Where(p => p.Name.Contains(searchText));
                    }

                    if (priceMin.Value != 0 && priceMax.Value != 0)
                    {
                        query = query.Where(p => p.Price >= priceMin.Value && p.Price <= priceMax.Value);
                    }

                    switch (cmbCategory.SelectedItem.ToString())
                    {
                        case "Процесори":
                            query = query.Where(p => p.Category.Name == "Процесори");
                            break;
                        case "Відеокарти":
                            query = query.Where(p => p.Category.Name == "Відеокарти");
                            break;
                        case "Материнські плати":
                            query = query.Where(p => p.Category.Name == "Материнські плати");
                            break;
                        case "Оперативна пам'ять":
                            query = query.Where(p => p.Category.Name == "Оперативна пам'ять");
                            break;
                        case "Накопичувачі":
                            query = query.Where(p => p.Category.Name == "Накопичувачі");
                            break;
                        case "Блоки живлення":
                            query = query.Where(p => p.Category.Name == "Блоки живлення");
                            break;
                        case "Корпуси":
                            query = query.Where(p => p.Category.Name == "Корпуси");
                            break;
                        case "Системи охолодження":
                            query = query.Where(p => p.Category.Name == "Системи охолодження");
                            break;
                    }

                    LoadProducts(query.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    var compareForm = new ProductCompareForm(product1, product2);
                    compareForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error comparing products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Назва", 200);
            listView1.Columns.Add("Категорія", 150);
            listView1.Columns.Add("Артикул", 200);
            listView1.Columns.Add("Ціна", 200);
            listView1.Columns.Add("Опис", 200);
            listView1.Columns.Add("Кількість", 10);
            listView1.Columns.Add("Виробник", 200);
            listView1.Columns.Add("Модель", 200);
            listView1.Columns.Add("Специфікація", 200);
            listView1.Columns.Add("Колір", 200);
            listView1.Columns.Add("Розмір", 200);
            listView1.Columns.Add("Вага", 200);
            listView1.Columns.Add("Гарантія", 200);

            LoadProducts(null);
            SetView(View.Details);
        }

        private void button1_Click(object sender, EventArgs e) => SetView(View.LargeIcon);
        private void button2_Click(object sender, EventArgs e) => SetView(View.Details);

        private void btnApplyFilter_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Фільтр застосовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearFilter_Click(object? sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            txtSearch.Clear();
            LoadProducts(null);
        }
        private void FilterChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void PriceChanged(object sender, EventArgs e)
        {
            if (priceMin.Value > priceMax.Value)
                priceMax.Value = priceMin.Value;
            SearchProducts();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 2)
                btnCompare.Enabled = true;
            else
                btnCompare.Enabled = false;
        }

        private void btnCompare_Click(object? sender, EventArgs e)
        {
            Compare();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                try
                {
                    using (var context = new Computer_Parts_StoreContext())
                    {
                        var selectedItem = listView1.SelectedItems[0];
                        string productName = selectedItem.Text;
                        var product = context.Products
                            .Include(p => p.Category)
                            .FirstOrDefault(p => p.Name == productName);
                        if (product == null)
                        {
                            return;
                        }
                        var detailsForm = new ProductDetailsForm(product);
                        detailsForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}