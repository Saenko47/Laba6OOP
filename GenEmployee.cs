using System;
using System.Collections.Generic;
using System.Globalization;
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
        private static string[] jobForWorkers = new string[]
        {
           "Слесарь", "Электрик", "Сварщик", "Водитель", "Маляр", "Плотник", "Штукатур", "Токарь", "Каменщик", "Столяр"
        };
        private static string[] jobForEngineers = new string[]
       {
           "Інженер механік", "Інженер електрик", "Інженер будівельник", "Інженер програміст", "Інженер з автоматизації", "Інженер хімік", "Інженер проєктувальник", "Інженер з охорони праці", "Інженер конструктор", "Інженер технолог"
       };

        public static Engineer[] GenerateEngineer(int i)
        {
            Engineer[] engineers = new Engineer[i];
            for (int j = 0; j < i; j++)
            {
                try
                {
                    
                    int year = rnd.Next(1950, 2005);
                    int month = rnd.Next(1, 13);
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    int day = rnd.Next(1, daysInMonth + 1);
                    DateTime dateOfBirth = new DateTime(year, month, day);
                   bool isHaveChild= (rnd.Next(1, 1001) % 2 == 0) ? true : false;
                    DateTime dateOfJoin = dateOfBirth.AddYears(rnd.Next(18, DateTime.Now.Year - dateOfBirth.Year));
                    string? name = names[rnd.Next(0, names.Length)];
                    string? phoneNumb = $"+380-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}";
                    string? job = jobForEngineers[rnd.Next(0, jobForEngineers.Length)];
                    if (string.IsNullOrEmpty(name)) name = "no name";
                    if (string.IsNullOrEmpty(job)) job = "no job";
                    if (string.IsNullOrEmpty(phoneNumb)) phoneNumb = "no phoneNumb";
                    Engineer.QualificationLevel qual = (Engineer.QualificationLevel)rnd.Next(1, 6);
                    engineers[j] = new Engineer(name, dateOfBirth, dateOfJoin, job, isHaveChild,phoneNumb,qual,rnd.Next(6000,30000));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Theres problem in engineer{j}:{e}");
                    continue;
                }
            }
            return engineers;
        }
        public static Worker[] GenerateWorker(int i)
        {
            Worker[] workers = new Worker[i];
            for (int j = 0; j < i; j++)
            {
                try
                {
                    int year = rnd.Next(1950, 2005);
                    int month = rnd.Next(1, 13);
                    int daysInMonth = DateTime.DaysInMonth(year, month);
                    int day = rnd.Next(1, daysInMonth + 1);
                    DateTime dateOfBirth = new DateTime(year, month, day);
                    DateTime dateOfJoin = dateOfBirth.AddYears(rnd.Next(18, DateTime.Now.Year - dateOfBirth.Year));
                    bool isHaveChild = (rnd.Next(1, 1001) % 2 == 0) ? true : false;
                    string? name = names[rnd.Next(0, names.Length)];
                    string? phoneNumb = $"+380-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}-{rnd.Next(0, 10)}{rnd.Next(0, 10)}";
                    string? job = jobForWorkers[rnd.Next(0, jobForWorkers.Length)];
                    if (string.IsNullOrEmpty(name)) name = "no name"; 
                    if (string.IsNullOrEmpty(job)) job = "no job";                   
                    if (string.IsNullOrEmpty(phoneNumb)) phoneNumb = "no phoneNumb";
                   

                    Worker.QualificationLevel qual = (Worker.QualificationLevel)rnd.Next(1, 7); 
                    workers[j] = new Worker(name, dateOfBirth, dateOfJoin, job, isHaveChild, phoneNumb,qual,rnd.Next(12000,35000));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Theres problem in workers{j}:{e}");
                    continue;
                }
            }
            return workers;
        }
    }
}
