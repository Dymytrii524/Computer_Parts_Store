using System;
using System.Windows.Forms;

namespace Computer_Parts_Store_Client.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            // Завантаження даних замовлення
            lblOrderNumber.Text = "Замовлення № 000001";
            lblOrderDate.Text = $"Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
            lblCustomer.Text = "Покупець: Іванов Іван Іванович";

            // Додати товари
            dataGridViewItems.Rows.Add("Intel Core i5-12400F", "1", "8500.00", "8500.00");
            dataGridViewItems.Rows.Add("NVIDIA RTX 3060", "1", "12000.00", "12000.00");

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["colTotal"].Value);
                }
            }

            lblSubtotal.Text = $"Проміжна сума: {total:F2} грн";
            lblTotal.Text = $"ВСЬОГО: {total:F2} грн";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функція друку буде реалізована пізніше", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveDialog.FileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Чек збережено як PDF", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}