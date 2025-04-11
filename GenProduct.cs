using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    class GenProduct
    {
        Random rnd = new Random();
        private string[] productNames = new string[] {
            "молоко", "кефир", "ряженка", "йогурт", "сметана", "сливки", "творог", "сыр", "маскарпоне", "моцарелла", "брынза", "айран", "мацони", "простокваша", "топлёное молоко", "сгущёнка", "масло сливочное", "сырок глазированный", "плавленый сыр", "снежок"
        };
        private string[] milkNames = new string[]
        {
            "Активия", "Даниссимо", "Простоквашино", "Великолукский молочный комбинат", "Молочная река", "Чудо", "Скала", "Растишка", "Бурёнка", "Тёплый край", "Яготинське", "Сметанка", "Татарка", "Радуга", "Деревенское молоко", "Село Лаврово", "Молоко из деревни", "Кавказский бренд", "Греческий йогурт", "Заречное молоко"
        };
        public MilkProduct[] GenerateMilkProduct(int k)
        {
            MilkProduct[] products = new MilkProduct[k];
            for(int i= 0;i<k; ++i)
            {
                try
                {
                    int year = rnd.Next(1950, 2025);
                    int month = rnd.Next(1, 13);
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    int day = rnd.Next(1, daysInMonth + 1);
                    DateTime dateOfRealease = new DateTime(year, month, day);
                    DateTime expirationDate = dateOfRealease.AddMonths(rnd.Next(1, 4)).AddDays(rnd.Next(0, 30));
                    products[i] = new MilkProduct(productNames[rnd.Next(0, productNames.Length)], dateOfRealease, expirationDate, rnd.Next(5, 500), milkNames[rnd.Next(0, milkNames.Length)], rnd.Next(1, 100));
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
