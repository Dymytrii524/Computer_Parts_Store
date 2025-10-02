using Forms;
using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
            LoadCartItems();
            UpdateSummary();
        }

        private void LoadCartItems()
        {
            // Завантаження товарів з кошика
            // Приклад даних:
            dataGridViewCart.Rows.Add("Intel Core i5-12400F", "ART001", "8500.00", "1", "8500.00");
            dataGridViewCart.Rows.Add("NVIDIA RTX 3060", "ART002", "12000.00", "1", "12000.00");
        }

        private void UpdateSummary()
        {
            int itemsCount = 0;
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                if (!row.IsNewRow)
                {
                    itemsCount += Convert.ToInt32(row.Cells["colQuantity"].Value);
                    totalPrice += Convert.ToDecimal(row.Cells["colTotal"].Value);
                }
            }

            lblItemsCountValue.Text = itemsCount.ToString();
            lblTotalPriceValue.Text = totalPrice.ToString("F2");
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Видалити товар
            if (e.ColumnIndex == dataGridViewCart.Columns["colRemove"].Index)
            {
                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете видалити цей товар?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridViewCart.Rows.RemoveAt(e.RowIndex);
                    UpdateSummary();
                    MessageBox.Show("Товар видалено з кошика", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Оновити суму при зміні кількості
            if (e.ColumnIndex == dataGridViewCart.Columns["colQuantity"].Index)
            {
                DataGridViewRow row = dataGridViewCart.Rows[e.RowIndex];
                decimal price = Convert.ToDecimal(row.Cells["colPrice"].Value);
                int quantity = Convert.ToInt32(row.Cells["colQuantity"].Value);
                row.Cells["colTotal"].Value = (price * quantity).ToString("F2");
                UpdateSummary();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.Rows.Count == 0 || (dataGridViewCart.Rows.Count == 1 && dataGridViewCart.Rows[0].IsNewRow))
            {
                MessageBox.Show("Кошик порожній!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете очистити кошик?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataGridViewCart.Rows.Clear();
                UpdateSummary();
                MessageBox.Show("Кошик очищено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}