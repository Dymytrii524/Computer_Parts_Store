using Forms;
using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            LoadOrderDetails();
            lblOrderDateValue.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void LoadOrderDetails()
        {
            // Завантаження товарів з кошика
            dataGridViewOrder.Rows.Add("Intel Core i5-12400F", "1", "8500.00", "8500.00");
            dataGridViewOrder.Rows.Add("NVIDIA RTX 3060", "1", "12000.00", "12000.00");

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewOrder.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["colTotal"].Value);
                }
            }
            lblTotalAmountValue.Text = total.ToString("F2");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            // Перевірка заповнення обов'язкових полів
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Введіть прізвище!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Введіть ім'я!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Введіть по батькові!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleName.Focus();
                return;
            }

            // Підтвердження замовлення
            DialogResult result = MessageBox.Show(
                "Підтвердити замовлення?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Зберегти замовлення в базу даних
                MessageBox.Show("Замовлення успішно оформлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Відкрити форму чеку
                ReceiptForm receiptForm = new ReceiptForm();
                receiptForm.ShowDialog();

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Скасувати оформлення замовлення?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}