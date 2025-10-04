using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm()
        {
            InitializeComponent();
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            // Завантаження деталей товару з бази даних
            // Приклад даних:
            lblProductName.Text = "Intel Core i5-12400F";
            lblArticleValue.Text = "ART001";
            lblCategoryValue.Text = "Процесори";
            lblPriceValue.Text = "8500.00 грн";
            lblQuantityValue.Text = "15 шт.";

            txtDescription.Text = "6-ядерний процесор Intel Core i5 12-го покоління з тактовою частотою до 4.4 ГГц. " +
                                 "Підтримка DDR4/DDR5 пам'яті, PCIe 5.0. Ідеально підходить для ігор та повсякденних завдань. " +
                                 "TDP: 65W. Сокет: LGA1700.\n\n" +
                                 "Основні характеристики:\n" +
                                 "- Кількість ядер: 6\n" +
                                 "- Кількість потоків: 12\n" +
                                 "- Базова частота: 2.5 ГГц\n" +
                                 "- Максимальна частота: 4.4 ГГц\n" +
                                 "- Кеш L3: 18 МБ\n" +
                                 "- Технологічний процес: 10 нм\n" +
                                 "- Інтегрована графіка: Немає\n" +
                                 "- Підтримка пам'яті: DDR4-3200, DDR5-4800";

            // Встановити максимальну кількість
            numericQuantity.Maximum = 15;
            numericQuantity.Minimum = 1;
            numericQuantity.Value = 1;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericQuantity.Value;

            // Перевірка наявності на складі
            if (quantity > 15)
            {
                MessageBox.Show("Недостатня кількість товару на складі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Додано {quantity} од. товару до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}