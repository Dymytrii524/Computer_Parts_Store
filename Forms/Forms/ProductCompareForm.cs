using System;
using System.Windows.Forms;
using Computer_Parts_Store.Models;

namespace Computer_Parts_Store.Forms
{
    public partial class ProductCompareForm : Form
    {
        private readonly Product product1;
        private readonly Product product2;

        public ProductCompareForm(Product p1, Product p2)
        {
            InitializeComponent();
            product1 = p1;
            product2 = p2;
            InitializeComparison();
        }

        private void InitializeComparison()
        {
            comparisonGrid.Columns.Add("Property", "Property");
            comparisonGrid.Columns.Add("Product1", product1.Name);
            comparisonGrid.Columns.Add("Product2", product2.Name);

            AddRow("Категорія", product1.Category?.Name, product2.Category?.Name);
            AddRow("Артикул", product1.Article, product2.Article);
            AddRow("Ціна", product1.Price.ToString() + " грн", product2.Price.ToString() + " грн");
            AddRow("Опис", product1.Description, product2.Description);
            AddRow("Кількість", product1.StockQuantity.ToString(), product2.StockQuantity.ToString());
            AddRow("Виробник", product1.Manufacturer, product2.Manufacturer);
            AddRow("Модель", product1.Model, product2.Model);
            AddRow("Специфікація", product1.Specification, product2.Specification);
            AddRow("Колір", product1.Color, product2.Color);
            AddRow("Розмір", product1.Dimensions, product2.Dimensions);
            AddRow("Вага", product1.Weight?.ToString(), product2.Weight?.ToString());
            AddRow("Гарантія", product1.WarrantyMonths?.ToString() + " місяців", product2.WarrantyMonths?.ToString() + " місяців");

            Highlight();
        }

        private void AddRow(string property, string value1, string value2)
        {
            int id = comparisonGrid.Rows.Add(property, value1 ?? "N/A", value2 ?? "N/A");

            comparisonGrid.Rows[id].Tag = new { Value1 = value1, Value2 = value2 };
        }

        private void Highlight()
        {
            foreach (DataGridViewRow row in comparisonGrid.Rows)
            {
                if (row.Tag != null)
                {
                    var values = (dynamic)row.Tag;
                    string value1 = values.Value1 ?? "";
                    string value2 = values.Value2 ?? "";

                    if (value1.Equals(value2, StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}