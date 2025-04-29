//Створити базовий клас «Продукт» з полями: назва, дата випуску,
//термін використання, пропонована ціна за одиницю товару. Визначити методи,
//що дозволять змінювати значення полів, віртуальний метод для аналізу
//годності товару. Створити породжений клас «Молочний продукт» з
//додатковими полями: назва виробника, масова частка молока.
//Ієрархія класів: службовець, особа, робітник, інженер. Варіант запиту:
//кількість співробітників зі стажем щонайменше заданого, відсортованих у
//порядку зростання стажу роботи.
using System.Text.RegularExpressions;

namespace LabaOOP6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MilkProduct[] milp = GenProduct.GenerateMilkProduct(45);
            foreach (MilkProduct product in milp)
            {
                Console.WriteLine($"{product}\n");
            }
            //    Worker[] workers = GenEmployee.GenerateWorker(40);
            //    Engineer[] engineers = GenEmployee.GenerateEngineer(40);
            //    Employee[] employees = Facility.EmployeeMerch(workers, engineers);
            //    Facility fac1 = new Facility(employees, "fdsf");
            //    fac1.SortByExp();
            //    Console.WriteLine(fac1.ToString());
            //    fac1.WhoWillGetRaiseOfSalary();
        }
    }
}
