using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class ProductCompareForm : Form
    {
        public ProductCompareForm()
        {
            InitializeComponent();
            LoadComparisonData();
        }

        private void LoadComparisonData()
        {
            dataGridViewCompare.Rows.Add("Назва", "Intel Core i5-12400F", "AMD Ryzen 5 5600X", "Intel Core i7-12700K");
            dataGridViewCompare.Rows.Add("Артикул", "ART001", "ART002", "ART003");
            dataGridViewCompare.Rows.Add("Ціна", "8500 грн", "9200 грн", "15000 грн");
            dataGridViewCompare.Rows.Add("Ядра/Потоки", "6/12", "6/12", "12/20");
            dataGridViewCompare.Rows.Add("Базова частота", "2.5 ГГц", "3.7 ГГц", "3.6 ГГц");
            dataGridViewCompare.Rows.Add("Макс. частота", "4.4 ГГц", "4.6 ГГц", "5.0 ГГц");
            dataGridViewCompare.Rows.Add("Кеш", "18 МБ", "32 МБ", "25 МБ");
            dataGridViewCompare.Rows.Add("TDP", "65W", "65W", "125W");
            dataGridViewCompare.Rows.Add("Сокет", "LGA1700", "AM4", "LGA1700");
            dataGridViewCompare.Rows.Add("Підтримка пам'яті", "DDR4/DDR5", "DDR4", "DDR4/DDR5");
            dataGridViewCompare.Rows.Add("На складі", "15 шт.", "8 шт.", "5 шт.");
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}