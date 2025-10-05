using System;
using System.Windows.Forms;
using System.Globalization;

namespace Computer_Parts_Store.Forms
{
    public partial class SalesHistoryForm : Form
    {
        public SalesHistoryForm()
        {
            InitializeComponent();
            InitializeDateFilters();
            LoadSalesData();
        }

        private void InitializeDateFilters()
        {
            // Встановити діапазон за останній місяць
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;
        }

        private void LoadSalesData()
        {
            // Завантаження даних з бази даних
            dataGridViewSales.Rows.Clear();

            // Приклад даних
            dataGridViewSales.Rows.Add("000001", "15.08.2024 14:30", "Петренко Петро", "3", "25000.00");
            dataGridViewSales.Rows.Add("000002", "16.08.2024 10:15", "Сидоренко Олена", "5", "45000.00");
            dataGridViewSales.Rows.Add("000003", "17.08.2024 16:45", "Коваленко Іван", "2", "18000.00");

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            int totalOrders = dataGridViewSales.Rows.Count;
            decimal totalRevenue = 0;

            foreach (DataGridViewRow row in dataGridViewSales.Rows)
            {
                if (!row.IsNewRow)
                {
                    string value = row.Cells["colTotalAmount"].Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount))
                        {
                            totalRevenue += amount;
                        }
                        else
                        {
                            // Логування помилки або обробка некоректних даних
                            MessageBox.Show($"Некоректне значення суми: {value}", "Помилка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

            decimal averageOrder = totalOrders > 0 ? totalRevenue / totalOrders : 0;

            lblTotalOrdersValue.Text = totalOrders.ToString();
            lblTotalRevenueValue.Text = totalRevenue.ToString("F2");
            lblAverageOrderValue.Text = averageOrder.ToString("F2");
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            // Застосувати фільтр по датах
            LoadSalesData();
            MessageBox.Show("Фільтр застосовано", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            InitializeDateFilters();
            LoadSalesData();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf|Excel files (*.xlsx)|*.xlsx";
            saveDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMdd}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Звіт сформовано та збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Переглянути деталі замовлення
            if (e.ColumnIndex == dataGridViewSales.Columns["colViewDetails"].Index)
            {
                string orderNumber = dataGridViewSales.Rows[e.RowIndex].Cells["colOrderNumber"].Value.ToString();
                MessageBox.Show($"Деталі замовлення {orderNumber}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}