using System;
using System.Windows.Forms;

namespace Computer_Parts_Store_Client.Forms
{
    public partial class PrebuiltComputersForm : Form
    {
        public PrebuiltComputersForm()
        {
            InitializeComponent();
            LoadPrebuiltComputers();
        }

        private void LoadPrebuiltComputers()
        {
            // Завантаження готових конфігурацій з бази даних
            // Приклад даних:
            dataGridViewPrebuilt.Rows.Add(
                "Офісний ПК",
                "Intel Core i3, 8GB RAM, 256GB SSD",
                "15000.00",
                "В наявності"
            );

            dataGridViewPrebuilt.Rows.Add(
                "Ігровий ПК Стартовий",
                "AMD Ryzen 5, RTX 3060, 16GB RAM, 512GB SSD",
                "35000.00",
                "В наявності"
            );

            dataGridViewPrebuilt.Rows.Add(
                "Ігровий ПК Преміум",
                "Intel Core i7, RTX 4070, 32GB RAM, 1TB SSD",
                "65000.00",
                "В наявності"
            );
        }

        private void dataGridViewPrebuilt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Переглянути деталі
            if (e.ColumnIndex == dataGridViewPrebuilt.Columns["colViewDetails"].Index)
            {
                string pcName = dataGridViewPrebuilt.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                MessageBox.Show($"Деталі конфігурації: {pcName}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Додати до кошика
            else if (e.ColumnIndex == dataGridViewPrebuilt.Columns["colAddToCart"].Index)
            {
                MessageBox.Show("Готовий ПК додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}