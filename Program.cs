using Computer_Parts_Store.Data;
using System;

namespace Computer_Parts_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== 🚀 ІНІЦІАЛІЗАЦІЯ БАЗИ ДАНИХ КОМП'ЮТЕРНОГО МАГАЗИНУ ===");
            Console.WriteLine("Створення бази даних з обраними категоріями компонентів\n");

            try
            {
                DatabaseInitializer.InitializeDatabase();
                DatabaseInitializer.DisplayDatabaseInfo();

                Console.WriteLine("\nБаза даних успішно створена!");
                Console.WriteLine("Містить всі обрані компоненти:");
                Console.WriteLine(" - Процесори, відеокарти, материнські плати");
                Console.WriteLine(" - Оперативна пам'ять, SSD, HDD");
                Console.WriteLine(" - Блоки живлення, корпуси");
                Console.WriteLine(" - Системи охолодження (повітряні та рідинні)");
                Console.WriteLine(" - Кулери та вентилятори");
                Console.WriteLine(" - Монітори, клавіатури, миші");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}