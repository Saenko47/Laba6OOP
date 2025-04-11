//Створити базовий клас «Продукт» з полями: назва, дата випуску,
//термін використання, пропонована ціна за одиницю товару. Визначити методи,
//що дозволять змінювати значення полів, віртуальний метод для аналізу
//годності товару. Створити породжений клас «Молочний продукт» з
//додатковими полями: назва виробника, масова частка молока.
//Ієрархія класів: службовець, особа, робітник, інженер. Варіант запиту:
//кількість співробітників зі стажем щонайменше заданого, відсортованих у
//порядку зростання стажу роботи.
namespace LabaOOP6
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
        GenEmployee genEmployee = new GenEmployee();
            Employee[] engineers = genEmployee.GenerateEngineer(10);
            foreach (Employee engineer in engineers)
            {
                Console.WriteLine(engineer.ToString());
            }
            Console.WriteLine("//");
            Employee.SortByExp(engineers);
            foreach (Employee engineer in engineers)
            {
                Console.WriteLine(engineer.ToString());
            }


        }
    }
}
