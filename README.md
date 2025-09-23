# Інструкція запуску вікна покупки запчастин

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
Додайте файл `appsettings.json` до `...PartsPage\bin\Debug\net9.0-windows\`:

**Для LocalDB (рекомендовано):**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Computer_Parts_Store_DB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

##Крок 6: Запуск solution
Запустіть `PartsPage.sln` в папці `PartsPage`

Результат: Відкритий solutionпроекту, який можна запустити кнопкою звеху або натиснувши `F5`
