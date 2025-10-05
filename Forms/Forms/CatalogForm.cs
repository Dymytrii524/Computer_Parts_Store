using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
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

        private void LoadProducts()
        {
            // Тут буде завантаження товарів з бази даних
        }

        private void btnApplyFilter_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Фільтр застосовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearFilter_Click(object? sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            txtSearch.Clear();
            txtPriceFrom.Clear();
            txtPriceTo.Clear();
            LoadProducts();
        }

        private void btnCompare_Click(object? sender, EventArgs e)
        {
            ProductCompareForm compareForm = new ProductCompareForm();
            compareForm.ShowDialog();
        }

        private void dataGridViewProducts_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridViewProducts.Columns["colDetails"]?.Index)
            {
                ProductDetailsForm detailsForm = new ProductDetailsForm();
                detailsForm.ShowDialog();
            }
            else if (e.ColumnIndex == dataGridViewProducts.Columns["colAddToCart"]?.Index)
            {
                MessageBox.Show("Товар додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}