# Інструкція запуску проекту Computer_Parts_Store з GitHub

## Крок 1: Клонування проекту
```bash
git clone https://github.com/YOUR_USERNAME/Computer_Parts_Store.git
cd Computer_Parts_Store
```

## Крок 2: Відновлення пакетів
```bash
dotnet restore
```
**Результат:** `Restore complete`

## Крок 3: Встановлення EF Core Tools
```bash
dotnet tool install --global dotnet-ef
```
**Результат:** `Tool 'dotnet-ef' was installed successfully` або `Tool 'dotnet-ef' is already installed`

## Крок 4: Перевірка збірки проекту
```bash
dotnet build
```
**Очікуваний результат:**
```
Build succeeded with X warning(s)
→ bin\Debug\net9.0\Computer_Parts_Store.dll
```

**Якщо є помилки збірки:**
- Переконайтесь, що всі файли завантажились правильно
- Перевірте, чи існують всі файли моделей у папці Models/
- Виконайте `dotnet clean` і потім знову `dotnet build`

## Крок 5: Налаштування бази даних
Перевірте файл `appsettings.json`:

**Для LocalDB (рекомендовано):**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Computer_Parts_Store_DB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

## Крок 6: Створення міграцій
```bash
dotnet ef migrations add InitialCreate
```
**Очікуваний результат:**
```
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
```

**Якщо помилка "Build failed":**
- Спочатку виправте помилки збірки з кроку 4
- Переконайтесь, що контекст бази даних існує

## Крок 7: Застосування міграцій до бази даних
```bash
dotnet ef database update
```
**Очікуваний результат:**
```
Build started...
Build succeeded.
Applying migration '20231201_InitialCreate'.
Done.
```

**Якщо помилка підключення:**
- Перевірте рядок підключення в appsettings.json
- Переконайтесь, що SQL Server LocalDB встановлений

## Крок 8: Запуск програми
```bash
dotnet run
```

**Очікуваний результат:**
```
=== 🚀 ІНІЦІАЛІЗАЦІЯ БАЗИ ДАНИХ КОМП'ЮТЕРНОГО МАГАЗИНУ ===
Створення бази даних з обраними категоріями компонентів

Ініціалізація бази даних...
Підключення: Server=(localdb)\mssqllocaldb;Database=Computer_Parts_Store_DB...
Застосування міграцій...
Перевірка наявності даних...
Додавання тестових даних...
Створення категорій...
Категорії додано успішно
Додаємо товари для: Процесори
Додаємо товари для: Відеокарти
...
Всі товари успішно додано!

=== ІНФОРМАЦІЯ ПРО БАЗУ ===
Категорій: 14
Товарів: 28

База даних успішно створена!
Натисніть будь-яку клавішу для виходу...
```

## Можливі проблеми та рішення

### Проблема: "Please select a valid startup item"
**Рішення в Visual Studio:**
- Правий клік на проекті Computer_Parts_Store → "Set as Startup Project"

### Проблема: Попередження про nullable properties
**Це нормально** - попередження не впливають на роботу програми. Приклад:
```
warning CS8618: Non-nullable property 'Name' must contain a non-null value
Build succeeded with 14 warning(s)
```

### Проблема: "The name 'AddXxxProducts' does not exist"
**Рішення:**
- Переконайтесь, що файл DatabaseInitializer.cs містить всі методи
- Виконайте `dotnet clean` і `dotnet build`

### Проблема: Помилка підключення до бази даних
**Рішення:**
1. Перевірте, чи встановлений SQL Server LocalDB
2. Змініть рядок підключення на SQL Server Express
3. Перевірте, чи працює служба SQL Server

## Структура проекту після клонування
```
Computer_Parts_Store/
├── Computer_Parts_Store.csproj
├── Program.cs
├── appsettings.json
├── Models/
│   ├── Category.cs
│   ├── Customer.cs
│   ├── Order.cs
│   ├── OrderItem.cs
│   ├── PrebuiltComputer.cs
│   └── Product.cs
├── Data/
│   ├── Computer_Parts_StoreContext.cs
│   └── DatabaseInitializer.cs
└── Services/
    └── DatabaseService.cs
```

## Корисні команди

```bash
# Перегляд міграцій
dotnet ef migrations list

# Видалення бази даних (для повного перезапуску)
dotnet ef database drop

# Очищення збірки
dotnet clean

# Перегляд інформації про контекст
dotnet ef dbcontext info
```
