using System;
using System.IO;
using System.Linq;
using Computer_Parts_Store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Computer_Parts_Store.Data
{
    public static class DatabaseInitializer
    {
        public static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            return configuration.GetConnectionString("DefaultConnection");
        }

        public static void InitializeDatabase()
        {
            try
            {
                Console.WriteLine("Ініціалізація бази даних...");

                var connectionString = GetConnectionString();
                Console.WriteLine($"Підключення: {connectionString}");

                var options = new DbContextOptionsBuilder<Computer_Parts_StoreContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                using var context = new Computer_Parts_StoreContext(options);

                Console.WriteLine("Застосування міграцій...");
                context.Database.Migrate();

                Console.WriteLine("Перевірка наявності даних...");

                if (!context.Products.Any())
                {
                    Console.WriteLine("Додавання тестових даних...");
                    SeedTestData(context);
                    Console.WriteLine("Тестові дані успішно додано!");
                }
                else
                {
                    Console.WriteLine("Дані вже існують в базі");
                    Console.WriteLine($"Знайдено {context.Products.Count()} товарів");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Внутрішня помилка: {ex.InnerException.Message}");
                }
            }
        }

        private static void SeedTestData(Computer_Parts_StoreContext context)
        {
            try
            {
                // Створення категорій
                if (!context.Categories.Any())
                {
                    Console.WriteLine("Створення категорій...");
                    var categories = new[]
                    {
                        new Category { Name = "Процесори (CPU)" },
                        new Category { Name = "Відеокарти (GPU)" },
                        new Category { Name = "Материнські плати" },
                        new Category { Name = "Оперативна пам'ять (RAM)" },
                        new Category { Name = "SSD накопичувачі" },
                        new Category { Name = "HDD накопичувачі" },
                        new Category { Name = "Блоки живлення (PSU)" },
                        new Category { Name = "Корпуси" },
                        new Category { Name = "Повітряне охолодження" },
                        new Category { Name = "Рідинне охолодження" },
                        new Category { Name = "Кулери" },
                        new Category { Name = "Монітори" },
                        new Category { Name = "Клавіатури" },
                        new Category { Name = "Миші" }
                    };

                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                    Console.WriteLine("Категорії додано успішно");
                }

                // Додавання товарів для кожної категорії
                var cpuCat = context.Categories.First(c => c.Name.Contains("Процесори"));
                var gpuCat = context.Categories.First(c => c.Name.Contains("Відеокарти"));
                var mbCat = context.Categories.First(c => c.Name.Contains("Материнські"));
                var ramCat = context.Categories.First(c => c.Name.Contains("Оперативна"));
                var ssdCat = context.Categories.First(c => c.Name.Contains("SSD"));
                var hddCat = context.Categories.First(c => c.Name.Contains("HDD"));
                var psuCat = context.Categories.First(c => c.Name.Contains("Блоки живлення"));
                var caseCat = context.Categories.First(c => c.Name.Contains("Корпуси"));
                var airCoolCat = context.Categories.First(c => c.Name.Contains("Повітряне"));
                var liquidCoolCat = context.Categories.First(c => c.Name.Contains("Рідинне"));
                var fansCat = context.Categories.First(c => c.Name.Contains("Кулери"));
                var monitorCat = context.Categories.First(c => c.Name.Contains("Монітори"));
                var keyboardCat = context.Categories.First(c => c.Name.Contains("Клавіатури"));
                var mouseCat = context.Categories.First(c => c.Name.Contains("Миші"));

                AddCpuProducts(context, cpuCat.Id);
                AddGpuProducts(context, gpuCat.Id);
                AddMotherboardProducts(context, mbCat.Id);
                AddRamProducts(context, ramCat.Id);
                AddSsdProducts(context, ssdCat.Id);
                AddHddProducts(context, hddCat.Id);
                AddPsuProducts(context, psuCat.Id);
                AddCaseProducts(context, caseCat.Id);
                AddAirCoolingProducts(context, airCoolCat.Id);
                AddLiquidCoolingProducts(context, liquidCoolCat.Id);
                AddFanProducts(context, fansCat.Id);
                AddMonitorProducts(context, monitorCat.Id);
                AddKeyboardProducts(context, keyboardCat.Id);
                AddMouseProducts(context, mouseCat.Id);

                Console.WriteLine("Всі товари успішно додано!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при додаванні даних: {ex.Message}");
                throw;
            }
        }

        // Методи для додавання товарів по категоріях
        private static void AddCpuProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("Додаємо товари для: Процесори");

            var products = new[]
            {
                new Product
                {
                    Name = "AMD Ryzen 5 5600X",
                    Article = "RYZEN5-5600X",
                    Price = 7500m,
                    Description = "6 ядер, 12 потоків, 3.7-4.6 GHz, AM4",
                    StockQuantity = 15,
                    Manufacturer = "AMD",
                    Model = "Ryzen 5 5600X",
                    Specification = "6 cores, 12 threads",
                    Color = "Silver",
                    Dimensions = "40x40mm",
                    Weight = 0.1m,
                    WarrantyMonths = 36,
                    CategoryId = categoryId
                },
                new Product
                {
                    Name = "Intel Core i5-12400F",
                    Article = "I5-12400F",
                    Price = 6800m,
                    Description = "6 ядер, 12 потоків, 2.5-4.4 GHz, LGA1700",
                    StockQuantity = 20,
                    Manufacturer = "Intel",
                    Model = "Core i5-12400F",
                    Specification = "6 cores, 12 threads",
                    Color = "Silver",
                    Dimensions = "45x45mm",
                    Weight = 0.12m,
                    WarrantyMonths = 36,
                    CategoryId = categoryId
                }
            };

            foreach (var product in products)
            {
                if (!context.Products.Any(p => p.Article == product.Article))
                {
                    context.Products.Add(product);
                }
            }
            context.SaveChanges();
        }

        public static void DisplayDatabaseInfo()
        {
            try
            {
                var connectionString = GetConnectionString();
                var options = new DbContextOptionsBuilder<Computer_Parts_StoreContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                using var context = new Computer_Parts_StoreContext(options);

                Console.WriteLine("\n=== ІНФОРМАЦІЯ ПРО БАЗУ ===");
                Console.WriteLine($"Категорій: {context.Categories.Count()}");
                Console.WriteLine($"Товарів: {context.Products.Count()}");

                Console.WriteLine("\n=== КАТЕГОРІЇ ТА КІЛЬКІСТЬ ТОВАРІВ ===");
                foreach (var category in context.Categories.OrderBy(c => c.Name))
                {
                    var productCount = context.Products.Count(p => p.CategoryId == category.Id);
                    Console.WriteLine($"- {category.Name}: {productCount} Шт");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при отриманні інформації: {ex.Message}");
            }
        }
    }
}