# Інструкція запуску вікна покупки запчастин

## Крок 1: Клонування проекту
```bash
git clone https://github.com/YOUR_USERNAME/Computer_Parts_Store.git
cd Computer_Parts_Store
```

## Крок 2: Додавання бази даних
Інструкція додавання лежить у гілці DataBase

## Крок 3: Налаштування бази даних
Додайте файл `appsettings.json` до `...PartsPage\bin\Debug\net9.0-windows\`:

**Для LocalDB (рекомендовано):**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Computer_Parts_Store_DB;Trusted_Connection=true;MultipleActiveResultSets=true"
  }
}
```

##Крок 4: Запуск solution
Запустіть `PartsPage.sln` в папці `PartsPage`

Результат: Відкритий проект, який можна запустити кнопкою звеху або натиснувши `F5`
