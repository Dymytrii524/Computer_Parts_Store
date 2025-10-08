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
                return; using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Windows.Forms;
                using Computer_Parts_Store.Models;

namespace Computer_Parts_Store.Forms
    {
        public partial class ShoppingCartForm : Form
        {
            private List<CartItem> _cartItems = new List<CartItem>();

            public ShoppingCartForm()
            {
                InitializeComponent();
            }

            /// <summary>
            ///  Метод для додавання товару в кошик
            /// </summary>
            public void AddToCart(CartItem item)
            {
                // Перевірка, чи вже є товар з таким артикулом
                var existingItem = _cartItems.FirstOrDefault(i => i.Article == item.Article);
                if (existingItem != null)
                {
                    existingItem.Quantity += item.Quantity;
                }
                else
                {
                    _cartItems.Add(item);
                }

                RefreshCart();
            }

            /// <summary>
            ///  Оновлення відображення таблиці та підсумків
            /// </summary>
            private void RefreshCart()
            {
                dataGridViewCart.Rows.Clear();

                foreach (var item in _cartItems)
                {
                    dataGridViewCart.Rows.Add(
                        item.Name,
                        item.Article,
                        item.Price.ToString("0.00"),
                        item.Quantity,
                        item.Total.ToString("0.00")
                    );
                }

                lblItemsCountValue.Text = _cartItems.Sum(i => i.Quantity).ToString();
                lblTotalPriceValue.Text = _cartItems.Sum(i => i.Total).ToString("0.00");
            }

            /// <summary>
            ///  Видалення товару з кошика (кнопка в таблиці)
            /// </summary>
            private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == dataGridViewCart.Columns["colRemove"].Index && e.RowIndex >= 0)
                {
                    string article = dataGridViewCart.Rows[e.RowIndex].Cells["colArticle"].Value.ToString();
                    _cartItems.RemoveAll(i => i.Article == article);
                    RefreshCart();
                }
            }

            /// <summary>
            ///  Зміна кількості вручну в таблиці
            /// </summary>
            private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewCart.Columns["colQuantity"].Index)
                {
                    var row = dataGridViewCart.Rows[e.RowIndex];
                    string article = row.Cells["colArticle"].Value.ToString();

                    if (int.TryParse(row.Cells["colQuantity"].Value?.ToString(), out int newQty) && newQty > 0)
                    {
                        var item = _cartItems.FirstOrDefault(i => i.Article == article);
                        if (item != null)
                        {
                            item.Quantity = newQty;
                            RefreshCart();
                        }
                    }
                }
            }

            /// <summary>
            /// Закрити форму
            /// </summary>
            private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            /// <summary>
            /// Оформити замовлення
            /// </summary>
            private void btnCheckout_Click(object sender, EventArgs e)
            {
                if (_cartItems.Count == 0)
                {
                    MessageBox.Show("Кошик порожній!");
                    return;
                }

                MessageBox.Show($"Замовлення оформлено!\nДо сплати: {lblTotalPriceValue.Text} грн");
                _cartItems.Clear();
                RefreshCart();
            }

            /// <summary>
            /// Очистити кошик
            /// </summary>
            private void btnClearCart_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Очистити кошик?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _cartItems.Clear();
                    RefreshCart();
                }
            }
        }
    }
