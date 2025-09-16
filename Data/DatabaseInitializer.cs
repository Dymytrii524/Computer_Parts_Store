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
                Console.WriteLine("����������� ���� �����...");

                var connectionString = GetConnectionString();
                Console.WriteLine($"ϳ���������: {connectionString}");

                var options = new DbContextOptionsBuilder<Computer_Parts_StoreContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                using var context = new Computer_Parts_StoreContext(options);

                Console.WriteLine("������������ �������...");
                context.Database.Migrate();

                Console.WriteLine("�������� �������� �����...");

                if (!context.Products.Any())
                {
                    Console.WriteLine("��������� �������� �����...");
                    SeedTestData(context);
                    Console.WriteLine("������ ��� ������ ������!");
                }
                else
                {
                    Console.WriteLine("��� ��� ������� � ���");
                    Console.WriteLine($"�������� {context.Products.Count()} ������");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"�������: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"�������� �������: {ex.InnerException.Message}");
                }
            }
        }

        private static void SeedTestData(Computer_Parts_StoreContext context)
        {
            try
            {
                // ��������� ��������
                if (!context.Categories.Any())
                {
                    Console.WriteLine("��������� ��������...");
                    var categories = new[]
                    {
                        new Category { Name = "��������� (CPU)" },
                        new Category { Name = "³�������� (GPU)" },
                        new Category { Name = "���������� �����" },
                        new Category { Name = "���������� ���'��� (RAM)" },
                        new Category { Name = "SSD ������������" },
                        new Category { Name = "HDD ������������" },
                        new Category { Name = "����� �������� (PSU)" },
                        new Category { Name = "�������" },
                        new Category { Name = "�������� �����������" },
                        new Category { Name = "г����� �����������" },
                        new Category { Name = "������" },
                        new Category { Name = "�������" },
                        new Category { Name = "���������" },
                        new Category { Name = "����" }
                    };

                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                    Console.WriteLine("������� ������ ������");
                }

                // ��������� ������ ��� ����� �������
                var cpuCat = context.Categories.First(c => c.Name.Contains("���������"));
                var gpuCat = context.Categories.First(c => c.Name.Contains("³��������"));
                var mbCat = context.Categories.First(c => c.Name.Contains("����������"));
                var ramCat = context.Categories.First(c => c.Name.Contains("����������"));
                var ssdCat = context.Categories.First(c => c.Name.Contains("SSD"));
                var hddCat = context.Categories.First(c => c.Name.Contains("HDD"));
                var psuCat = context.Categories.First(c => c.Name.Contains("����� ��������"));
                var caseCat = context.Categories.First(c => c.Name.Contains("�������"));
                var airCoolCat = context.Categories.First(c => c.Name.Contains("��������"));
                var liquidCoolCat = context.Categories.First(c => c.Name.Contains("г�����"));
                var fansCat = context.Categories.First(c => c.Name.Contains("������"));
                var monitorCat = context.Categories.First(c => c.Name.Contains("�������"));
                var keyboardCat = context.Categories.First(c => c.Name.Contains("���������"));
                var mouseCat = context.Categories.First(c => c.Name.Contains("����"));

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

                Console.WriteLine("�� ������ ������ ������!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������� ��� �������� �����: {ex.Message}");
                throw;
            }
        }

        // ������ ��� ��������� ������ �� ���������
        private static void AddCpuProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ���������");

            var products = new[]
            {
                new Product
                {
                    Name = "AMD Ryzen 5 5600X",
                    Article = "RYZEN5-5600X",
                    Price = 7500m,
                    Description = "6 ����, 12 ������, 3.7-4.6 GHz, AM4",
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
                    Description = "6 ����, 12 ������, 2.5-4.4 GHz, LGA1700",
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

                Console.WriteLine("\n=== �������ֲ� ��� ���� ===");
                Console.WriteLine($"��������: {context.Categories.Count()}");
                Console.WriteLine($"������: {context.Products.Count()}");

                Console.WriteLine("\n=== ������в� �� ʲ��ʲ��� ����в� ===");
                foreach (var category in context.Categories.OrderBy(c => c.Name))
                {
                    var productCount = context.Products.Count(p => p.CategoryId == category.Id);
                    Console.WriteLine($"- {category.Name}: {productCount} ��");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������� ��� �������� ����������: {ex.Message}");
            }
        }
    }
}