using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    class GenProduct
    {
        static Random rnd = new Random();
        private static string[] productMilkNames = new string[] {
            "молоко", "кефир", "ряженка", "йогурт", "сметана", "сливки", "творог", "сыр", "маскарпоне", "моцарелла", "брынза", "айран", "мацони", "простокваша", "топлёное молоко", "сгущёнка", "масло сливочное", "сырок глазированный", "плавленый сыр", "снежок"
        };
        private static string[] milkNames = new string[]
        {
            "Активия", "Даниссимо", "Простоквашино", "Великолукский молочный комбинат", "Молочная река", "Чудо", "Скала", "Растишка", "Бурёнка", "Тёплый край", "Яготинське", "Сметанка", "Татарка", "Радуга", "Деревенское молоко", "Село Лаврово", "Молоко из деревни", "Кавказский бренд", "Греческий йогурт", "Заречное молоко"
        };
        private static string[] productNames = { "Хліб", "Масло", "Крупа", "Сир", "Шоколад", "Ковбаса", "Олія", "Чай", "Кава", "Цукор" };
        public static Product[] GenerateProducts(int k)
        {
            Product[] products = new Product[k];
            for (int i = 0; i < k; ++i)
            {
                try
                {
                    
                    int year = rnd.Next(2024, 2026);
                    int month = rnd.Next(1, 13);
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    int day = rnd.Next(1, daysInMonth + 1);
                    DateTime dateOfRelease = new DateTime(year, month, day);

                   
                    DateTime expirationDate = dateOfRelease.AddMonths(rnd.Next(1, 4)).AddDays(rnd.Next(0, 30));
                    string? name = productNames[rnd.Next(0, productNames.Length)];
                    if(name == null) name = "Defoult name";

                    products[i] = new Product(
                       name,
                        dateOfRelease,
                        expirationDate,
                        rnd.Next(5, 500)
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Проблема з продуктом {i}: {ex.Message}");
                    continue;
                }
            }
            return products;
        }
        public static MilkProduct[] GenerateMilkProduct(int k)
        {
            MilkProduct[] products = new MilkProduct[k];
            for(int i= 0;i<k; ++i)
            {
                try
                {
                    int year = rnd.Next(2024, 2026);
                    int month = rnd.Next(1, 13);
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    int day = rnd.Next(1, daysInMonth + 1);
                    DateTime dateOfRealease = new DateTime(year, month, day);
                    
                    DateTime expirationDate = dateOfRealease.AddMonths(rnd.Next(1, 4)).AddDays(rnd.Next(0, 30));
                    string? name = productMilkNames[rnd.Next(0, productMilkNames.Length)];
                    string? nameOfProducer = milkNames[rnd.Next(0, milkNames.Length)];
                    if (name == null) name = "Defoult name";
                    if (nameOfProducer == null) nameOfProducer = "Defoult name of producer";
                    products[i] = new MilkProduct(name, dateOfRealease, expirationDate, rnd.Next(5, 500), nameOfProducer, rnd.Next(1, 100));
                }
                catch (Exception ex) {
                    Console.WriteLine($"There problem with product {i}: {ex}");
                    continue;
                }
            }
            return products;
        }
    }
}
