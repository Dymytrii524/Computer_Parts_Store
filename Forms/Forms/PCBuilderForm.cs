using System;
using System.Windows.Forms;

namespace Computer_Parts_Store.Forms
{
    public partial class PCBuilderForm : Form
    {
        private decimal totalPrice = 0;

        public PCBuilderForm()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            // Завантаження комплектуючих з бази даних
            cmbCPU.Items.Add("-- Оберіть процесор --");
            cmbGPU.Items.Add("-- Оберіть відеокарту --");
            cmbMotherboard.Items.Add("-- Оберіть материнську плату --");
            cmbRAM.Items.Add("-- Оберіть оперативну пам'ять --");
            cmbStorage.Items.Add("-- Оберіть накопичувач --");
            cmbPSU.Items.Add("-- Оберіть блок живлення --");
            cmbCase.Items.Add("-- Оберіть корпус --");
            cmbCooling.Items.Add("-- Оберіть систему охолодження --");

            cmbCPU.SelectedIndex = 0;
            cmbGPU.SelectedIndex = 0;
            cmbMotherboard.SelectedIndex = 0;
            cmbRAM.SelectedIndex = 0;
            cmbStorage.SelectedIndex = 0;
            cmbPSU.SelectedIndex = 0;
            cmbCase.SelectedIndex = 0;
            cmbCooling.SelectedIndex = 0;
        }

        private void Component_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBuildSummary();
        }

        private void UpdateBuildSummary()
        {
            txtBuildSummary.Clear();
            totalPrice = 0;

            txtBuildSummary.AppendText("=== КОНФІГУРАЦІЯ ПК ===\n\n");

            if (cmbCPU.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Процесор: {cmbCPU.Text}\n");

            if (cmbGPU.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Відеокарта: {cmbGPU.Text}\n");

            if (cmbMotherboard.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Материнська плата: {cmbMotherboard.Text}\n");

            if (cmbRAM.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Оперативна пам'ять: {cmbRAM.Text}\n");

            if (cmbStorage.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Накопичувач: {cmbStorage.Text}\n");

            if (cmbPSU.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Блок живлення: {cmbPSU.Text}\n");

            if (cmbCase.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Корпус: {cmbCase.Text}\n");

            if (cmbCooling.SelectedIndex > 0)
                txtBuildSummary.AppendText($"Система охолодження: {cmbCooling.Text}\n");

            lblTotalPriceValue.Text = $"{totalPrice:F2} грн";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbCPU.SelectedIndex == 0)
            {
                MessageBox.Show("Виберіть принаймні процесор для збірки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Збірку додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearBuild_Click(object sender, EventArgs e)
        {
            cmbCPU.SelectedIndex = 0;
            cmbGPU.SelectedIndex = 0;
            cmbMotherboard.SelectedIndex = 0;
            cmbRAM.SelectedIndex = 0;
            cmbStorage.SelectedIndex = 0;
            cmbPSU.SelectedIndex = 0;
            cmbCase.SelectedIndex = 0;
            cmbCooling.SelectedIndex = 0;

            UpdateBuildSummary();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}