using System;
using System.Windows.Forms;
using Computer_Parts_Store.Models;

namespace Computer_Parts_Store.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private readonly Product product;
        public ProductDetailsForm(Product p)
        {
            InitializeComponent();
            product = p;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            lblProductName.Text = product.Name;
            lblArticleValue.Text = product.Article;
            lblCategoryValue.Text = product.Category.Name;
            lblPriceValue.Text = product.Price.ToString();
            lblQuantityValue.Text = product.StockQuantity.ToString();
            lblColorValue.Text = product.Color;
            lblManufacturerValue.Text = product.Manufacturer;
            lblModelValue.Text = product.Model;
            lblSizeValue.Text = product.Dimensions;
            lblWeightValue.Text = product.Weight?.ToString();
            lblWarrantyValue.Text = product.WarrantyMonths?.ToString();
            lblSpecValue.Text = product.Specification;
            txtDescription.Text = product.Description;

            // Встановити максимальну кількість
            numericQuantity.Maximum = product.StockQuantity;
            numericQuantity.Minimum = 1;
            numericQuantity.Value = 1;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericQuantity.Value;

            // Перевірка наявності на складі
            if (quantity > product.StockQuantity)
            {
                MessageBox.Show("Недостатня кількість товару на складі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Додано {quantity} од. товару до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}