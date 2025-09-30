﻿using System;
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

            return configuration.GetConnectionString("DefaultConnection") ?? string.Empty;
        }

        public static void InitializeDatabase()
        {
            try
            {
                Console.WriteLine("������������ ���� �����...");

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
                    Console.WriteLine("������ ���� ������ ������!");
                }
                else
                {
                    Console.WriteLine("���� ��� ������� � ���");
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
                        new Category { Name = "��������" },
                        new Category { Name = "���������" },
                        new Category { Name = "����" }
                    };

                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                    Console.WriteLine("������� ������ ������");
                }

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
                var monitorCat = context.Categories.First(c => c.Name.Contains("��������"));
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
                Console.WriteLine($"������� ��� ��������� �����: {ex.Message}");
                throw;
            }
        }

        private static void AddCpuProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ���������");

            var products = new[]
            {
                new Product { Name = "AMD Ryzen 5 5600X", Article = "RYZEN5-5600X", Price = 7500m, Description = "6 ����, 12 ������, 3.7-4.6 GHz, AM4", StockQuantity = 15, Manufacturer = "AMD", Model = "Ryzen 5 5600X", Specification = "6 cores, 12 threads", Color = "Silver", Dimensions = "40x40mm", Weight = 0.1m, WarrantyMonths = 36, CategoryId = categoryId },
                new Product { Name = "Intel Core i5-12400F", Article = "I5-12400F", Price = 6800m, Description = "6 ����, 12 ������, 2.5-4.4 GHz, LGA1700", StockQuantity = 20, Manufacturer = "Intel", Model = "Core i5-12400F", Specification = "6 cores, 12 threads", Color = "Silver", Dimensions = "45x45mm", Weight = 0.12m, WarrantyMonths = 36, CategoryId = categoryId }
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

        private static void AddGpuProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ³��������");

            var products = new[]
            {
                new Product { Name = "NVIDIA GeForce RTX 4060", Article = "RTX4060-8G", Price = 14500m, Description = "8GB GDDR6, 3072 ����, PCIe 4.0", StockQuantity = 8, Manufacturer = "NVIDIA", Model = "RTX 4060", Specification = "8GB GDDR6", Color = "Black", Dimensions = "240x110mm", Weight = 0.8m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "AMD Radeon RX 7600", Article = "RX7600-8G", Price = 13200m, Description = "8GB GDDR6, 2048 ����, PCIe 4.0", StockQuantity = 6, Manufacturer = "AMD", Model = "Radeon RX 7600", Specification = "8GB GDDR6", Color = "Black", Dimensions = "230x100mm", Weight = 0.7m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddMotherboardProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ���������� �����");

            var products = new[]
            {
                new Product { Name = "ASUS TUF GAMING B550-PLUS", Article = "B550-TUF", Price = 5200m, Description = "AMD B550, Socket AM4, ATX", StockQuantity = 12, Manufacturer = "ASUS", Model = "TUF GAMING B550-PLUS", Specification = "AMD B550", Color = "Black", Dimensions = "305x244mm", Weight = 1.2m, WarrantyMonths = 36, CategoryId = categoryId },
                new Product { Name = "Gigabyte B760 GAMING X", Article = "B760-GIGA", Price = 4800m, Description = "Intel B760, LGA1700, ATX", StockQuantity = 10, Manufacturer = "Gigabyte", Model = "B760 GAMING X", Specification = "Intel B760", Color = "Black", Dimensions = "305x244mm", Weight = 1.1m, WarrantyMonths = 36, CategoryId = categoryId }
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

        private static void AddRamProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ���������� ���'���");

            var products = new[]
            {
                new Product { Name = "Kingston FURY Beast 16GB DDR4", Article = "KF416-16", Price = 2800m, Description = "DDR4 3200MHz, CL16, 2x8GB", StockQuantity = 25, Manufacturer = "Kingston", Model = "FURY Beast", Specification = "16GB DDR4", Color = "Black", Dimensions = "133x30mm", Weight = 0.05m, WarrantyMonths = 36, CategoryId = categoryId },
                new Product { Name = "Corsair Vengeance RGB 32GB DDR5", Article = "CMG32-D5", Price = 4200m, Description = "DDR5 5600MHz, CL36, 2x16GB", StockQuantity = 15, Manufacturer = "Corsair", Model = "Vengeance RGB", Specification = "32GB DDR5", Color = "Black", Dimensions = "133x30mm", Weight = 0.06m, WarrantyMonths = 36, CategoryId = categoryId }
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

        private static void AddSsdProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: SSD ������������");

            var products = new[]
            {
                new Product { Name = "Samsung 970 EVO Plus 1TB", Article = "970EVO-1TB", Price = 3800m, Description = "NVMe PCIe 3.0, 3500/3300 MB/s", StockQuantity = 18, Manufacturer = "Samsung", Model = "970 EVO Plus", Specification = "1TB NVMe", Color = "Black", Dimensions = "80x22mm", Weight = 0.01m, WarrantyMonths = 60, CategoryId = categoryId },
                new Product { Name = "WD Black SN850X 2TB", Article = "SN850X-2T", Price = 6200m, Description = "NVMe PCIe 4.0, 7300/6600 MB/s", StockQuantity = 12, Manufacturer = "Western Digital", Model = "Black SN850X", Specification = "2TB NVMe", Color = "Black", Dimensions = "80x22mm", Weight = 0.01m, WarrantyMonths = 60, CategoryId = categoryId }
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

        private static void AddHddProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: HDD ������������");

            var products = new[]
            {
                new Product { Name = "Seagate BarraCuda 2TB", Article = "ST2000DM", Price = 2200m, Description = "HDD 7200RPM, SATA 6Gb/s", StockQuantity = 10, Manufacturer = "Seagate", Model = "BarraCuda", Specification = "2TB HDD", Color = "Silver", Dimensions = "147x102mm", Weight = 0.5m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "WD Blue 4TB", Article = "WD40EZAZ", Price = 3200m, Description = "HDD 5400RPM, SATA 6Gb/s", StockQuantity = 8, Manufacturer = "Western Digital", Model = "Blue", Specification = "4TB HDD", Color = "Blue", Dimensions = "147x102mm", Weight = 0.6m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddPsuProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ����� ��������");

            var products = new[]
            {
                new Product { Name = "be quiet! Pure Power 11 600W", Article = "PP11-600W", Price = 3200m, Description = "600W, 80+ Gold, ���������", StockQuantity = 14, Manufacturer = "be quiet!", Model = "Pure Power 11", Specification = "600W Gold", Color = "Black", Dimensions = "140x150mm", Weight = 2.1m, WarrantyMonths = 60, CategoryId = categoryId },
                new Product { Name = "Corsair RM850x 850W", Article = "CP-9020180", Price = 4500m, Description = "850W, 80+ Gold, �������� ���������", StockQuantity = 9, Manufacturer = "Corsair", Model = "RM850x", Specification = "850W Gold", Color = "Black", Dimensions = "150x160mm", Weight = 2.3m, WarrantyMonths = 60, CategoryId = categoryId }
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

        private static void AddCaseProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: �������");

            var products = new[]
            {
                new Product { Name = "NZXT H510", Article = "NZXT-H510", Price = 4100m, Description = "Mid-Tower, ATX, tempered glass", StockQuantity = 7, Manufacturer = "NZXT", Model = "H510", Specification = "Mid-Tower", Color = "Black", Dimensions = "460x210mm", Weight = 6.7m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "Fractal Design Meshify 2", Article = "FD-C-MES2-01", Price = 5200m, Description = "Mid-Tower, ATX, mesh front panel", StockQuantity = 5, Manufacturer = "Fractal Design", Model = "Meshify 2", Specification = "Mid-Tower", Color = "Black", Dimensions = "475x215mm", Weight = 7.2m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddAirCoolingProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: �������� �����������");

            var products = new[]
            {
                new Product { Name = "DeepCool AK620", Article = "AK620", Price = 1800m, Description = "CPU Cooler, 260W TDP, dual tower", StockQuantity = 9, Manufacturer = "DeepCool", Model = "AK620", Specification = "Dual Tower", Color = "Black", Dimensions = "129x138mm", Weight = 1.2m, WarrantyMonths = 36, CategoryId = categoryId },
                new Product { Name = "Noctua NH-D15", Article = "NH-D15", Price = 3200m, Description = "CPU Cooler, 220W TDP, dual tower", StockQuantity = 6, Manufacturer = "Noctua", Model = "NH-D15", Specification = "Dual Tower", Color = "Brown", Dimensions = "165x150mm", Weight = 1.3m, WarrantyMonths = 72, CategoryId = categoryId }
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

        private static void AddLiquidCoolingProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: г����� �����������");

            var products = new[]
            {
                new Product { Name = "Corsair iCUE H150i Elite", Article = "CW-9060056-WW", Price = 5200m, Description = "360mm AIO, RGB, LCD display", StockQuantity = 8, Manufacturer = "Corsair", Model = "iCUE H150i Elite", Specification = "360mm AIO", Color = "Black", Dimensions = "397x120mm", Weight = 1.5m, WarrantyMonths = 60, CategoryId = categoryId },
                new Product { Name = "NZXT Kraken X73", Article = "RL-KRX73-01", Price = 4800m, Description = "360mm AIO, RGB, CAM software", StockQuantity = 7, Manufacturer = "NZXT", Model = "Kraken X73", Specification = "360mm AIO", Color = "Black", Dimensions = "397x120mm", Weight = 1.4m, WarrantyMonths = 60, CategoryId = categoryId }
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

        private static void AddFanProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ������");

            var products = new[]
            {
                new Product { Name = "Noctua NF-A12x25", Article = "NF-A12x25", Price = 800m, Description = "120mm fan, 2000 RPM, PWM", StockQuantity = 20, Manufacturer = "Noctua", Model = "NF-A12x25", Specification = "120mm PWM", Color = "Brown", Dimensions = "120x120mm", Weight = 0.2m, WarrantyMonths = 72, CategoryId = categoryId },
                new Product { Name = "Corsair iCUE SP120 RGB Elite", Article = "CO-9050105-WW", Price = 600m, Description = "120mm fan, RGB, PWM", StockQuantity = 25, Manufacturer = "Corsair", Model = "SP120 RGB Elite", Specification = "120mm RGB", Color = "Black", Dimensions = "120x120mm", Weight = 0.18m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddMonitorProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ��������");

            var products = new[]
            {
                new Product { Name = "Samsung Odyssey G5 27\"", Article = "ODG5-27", Price = 8900m, Description = "27\", 1440p, 144Hz, 1ms", StockQuantity = 5, Manufacturer = "Samsung", Model = "Odyssey G5", Specification = "27\" 1440p", Color = "Black", Dimensions = "613x461mm", Weight = 5.5m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "LG UltraGear 24GN600-B", Article = "24GN600-B", Price = 6500m, Description = "24\", 1080p, 144Hz, IPS", StockQuantity = 8, Manufacturer = "LG", Model = "UltraGear 24GN600-B", Specification = "24\" 1080p", Color = "Black", Dimensions = "540x420mm", Weight = 3.8m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddKeyboardProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ���������");

            var products = new[]
            {
                new Product { Name = "Razer BlackWidow V3", Article = "RZ03-0354", Price = 3200m, Description = "Mechanical, Green switches, RGB", StockQuantity = 12, Manufacturer = "Razer", Model = "BlackWidow V3", Specification = "Mechanical", Color = "Black", Dimensions = "440x150mm", Weight = 1.2m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "Logitech G Pro X", Article = "920-0092", Price = 3800m, Description = "Mechanical, GX Blue switches, RGB", StockQuantity = 15, Manufacturer = "Logitech", Model = "G Pro X", Specification = "Mechanical", Color = "Black", Dimensions = "435x140mm", Weight = 1.1m, WarrantyMonths = 24, CategoryId = categoryId }
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

        private static void AddMouseProducts(Computer_Parts_StoreContext context, int categoryId)
        {
            Console.WriteLine("������ ������ ���: ����");

            var products = new[]
            {
                new Product { Name = "Logitech G Pro X Superlight", Article = "910-0056", Price = 3800m, Description = "Wireless, 25K DPI, 63g", StockQuantity = 15, Manufacturer = "Logitech", Model = "G Pro X Superlight", Specification = "Wireless", Color = "White", Dimensions = "125x63mm", Weight = 0.063m, WarrantyMonths = 24, CategoryId = categoryId },
                new Product { Name = "Razer DeathAdder V2", Article = "RZ01-0321", Price = 2500m, Description = "Wired, 20K DPI, 82g", StockQuantity = 20, Manufacturer = "Razer", Model = "DeathAdder V2", Specification = "Wired", Color = "Black", Dimensions = "127x61mm", Weight = 0.082m, WarrantyMonths = 24, CategoryId = categoryId }
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
                Console.WriteLine($"������� ��� ��������� ����������: {ex.Message}");
            }
        }
    }
}