using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Computer_Parts_Store.Models;

namespace Computer_Parts_Store.Forms
{
    // Клас для елемента кошика
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public partial class ShoppingCartForm : Form
    {
        // Список товарів у кошику
        private List<CartItem> cartItems = new List<CartItem>();

        public ShoppingCartForm()
        {
            InitializeComponent();
            UpdateCartDisplay();
        }

        // Публічний метод для додавання товару до кошика
        public void AddToCart(Product product, int quantity = 1)
        {
            if (product == null)
            {
                MessageBox.Show("Помилка: товар не знайдено!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Кількість товару повинна бути більше нуля!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевіряємо, чи товар вже є в кошику
            var existingItem = cartItems.FirstOrDefault(item => item.Product.Article == product.Article);

            if (existingItem != null)
            {
                // Якщо товар вже є, збільшуємо кількість
                existingItem.Quantity += quantity;
                MessageBox.Show($"Кількість товару '{product.Name}' оновлено до {existingItem.Quantity}",
                    "Товар оновлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Додаємо новий товар
                cartItems.Add(new CartItem
                {
                    Product = product,
                    Quantity = quantity
                });
                MessageBox.Show($"Товар '{product.Name}' додано до кошика!",
                    "Товар додано", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateCartDisplay();
        }

        // Оновлення відображення кошика
        private void UpdateCartDisplay()
        {
            dataGridViewCart.Rows.Clear();

            foreach (var item in cartItems)
            {
                decimal total = item.Product.Price * item.Quantity;
                dataGridViewCart.Rows.Add(
                    item.Product.Name,
                    item.Product.Article,
                    item.Product.Price.ToString("F2"),
                    item.Quantity,
                    total.ToString("F2"),
                    "Видалити"
                );
            }

            UpdateSummary();
        }

        // Оновлення підсумкової інформації
        private void UpdateSummary()
        {
            int totalItems = cartItems.Sum(item => item.Quantity);
            decimal totalPrice = cartItems.Sum(item => item.Product.Price * item.Quantity);

            lblItemsCountValue.Text = totalItems.ToString();
            lblTotalPriceValue.Text = totalPrice.ToString("F2");
        }

        // Обробка кліку на кнопку видалення товару
        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCart.Columns["colRemove"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Ви впевнені, що хочете видалити цей товар з кошика?",
                    "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cartItems.RemoveAt(e.RowIndex);
                    UpdateCartDisplay();
                }
            }
        }

        // Обробка зміни кількості товару
        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCart.Columns["colQuantity"].Index && e.RowIndex >= 0)
            {
                try
                {
                    var cell = dataGridViewCart.Rows[e.RowIndex].Cells["colQuantity"];
                    int newQuantity = Convert.ToInt32(cell.Value);

                    if (newQuantity <= 0)
                    {
                        MessageBox.Show("Кількість повинна бути більше нуля!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cell.Value = cartItems[e.RowIndex].Quantity;
                        return;
                    }

                    cartItems[e.RowIndex].Quantity = newQuantity;
                    UpdateCartDisplay();
                }
                catch
                {
                    UpdateCartDisplay();
                }
            }
        }

        // Очищення кошика
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Кошик вже порожній!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Ви впевнені, що хочете очистити кошик?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cartItems.Clear();
                UpdateCartDisplay();
            }
        }

        // Оформлення замовлення
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Кошик порожній!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = cartItems.Sum(item => item.Product.Price * item.Quantity);

            var result = MessageBox.Show(
                $"Оформити замовлення на суму {totalAmount:F2} грн?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Замовлення успішно оформлено!", "Успіх",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartItems.Clear();
                UpdateCartDisplay();
            }
        }

        // Закриття форми
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
