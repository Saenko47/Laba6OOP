using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    class GenEmployee
    {
        static Random rnd = new Random();

        private static string[] names = new string[]
        {
        "Александр", "Максим", "Дмитрий", "Артем", "Иван",
    "Михаил", "Кирилл", "Андрей", "Егор", "Сергей",
    "Никита", "Тимофей", "Алексей", "Владимир", "Олег",
    "Илья", "Роман", "Павел", "Юрий", "Борис",
    "Виктор", "Степан", "Григорий", "Фёдор", "Константин"
        };
        public Worker []GenerateWorker(int i)
        {
            Worker [] workers = new Worker[i];
            for (int j = 0; j < i; j++)
            {
                int year = rnd.Next(1950, 2005);
                int month = rnd.Next(1, 13);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = rnd.Next(1, daysInMonth + 1);
                DateTime dateOfBirth = new DateTime(year, month, day);
                DateTime dateOfJoin = dateOfBirth.AddYears(rnd.Next(18, DateTime.Now.Year - dateOfBirth.Year));
                workers[j] = new Worker(names[rnd.Next(0, names.Length)], dateOfBirth, dateOfJoin);
            }
            return workers;
        }
        public Engineer[] GenerateEngineer(int i)
        {
            Engineer[] engineers = new Engineer[i];
            for (int j = 0; j < i; j++)
            {
                int year = rnd.Next(1950, 2005);
                int month = rnd.Next(1, 13);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int day = rnd.Next(1, daysInMonth + 1);
                DateTime dateOfBirth = new DateTime(year, month, day);
                DateTime dateOfJoin = dateOfBirth.AddYears(rnd.Next(18, DateTime.Now.Year-dateOfBirth.Year));
                engineers[j] = new Engineer(names[rnd.Next(0, names.Length)], dateOfBirth, dateOfJoin);
            }
            return engineers;
        }
    }
}
