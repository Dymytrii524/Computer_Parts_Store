using System;
using System.Windows.Forms;
using Computer_Parts_Store.Data;

namespace Computer_Parts_Store
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            try
            {
                DatabaseInitializer.InitializeDatabase();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації бази даних:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Application.Run(new Form1()); 
           

        }
    }
}
