using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class Employee:Person
    {
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        public DateTime dateOfJoin;
        public int YearsOfExperience => DateTime.Now.Year - dateOfJoin.Year;
        public Employee() : base()
        {
            this.dateOfJoin = DateTime.Now;
        }
        public Employee(string name, DateTime dateOfBirth, DateTime dateOfJoin) :base(name, dateOfBirth)
        {
            this.dateOfJoin = (Regex.IsMatch(dateOfJoin.ToString("yyyy,MM,dd"), datepattern) ? dateOfJoin : throw new Exception("Invalid dateOfJoin format."));
        }
        public DateTime DateOfJoin
        {
            get { return DateOfJoin; }
            set { this.dateOfJoin = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfJoin format.")); }
        }
        public  static void Exp(Employee[] person, int n)
        {
            foreach (Employee e in person)
            {
                if (e.YearsOfExperience > n)
                {
                    Console.WriteLine($"{e.Name} has more than {n} years of experience.");
                }
            }
        }
        public static Employee []SortByExp(Employee[] person)
        {
            
            Employee temp;
            for (int i = 0; i < person.Length; ++i)
            {
                for (int k = 0; k < person.Length - 1 - i; ++k)
                {
                    if (person[k].YearsOfExperience > person[k + 1].YearsOfExperience)
                    {
                        temp = person[k];
                        person[k] = person[k + 1];
                        person[k + 1] = temp;
                    }
                }
            }
            return person;
        }
        public override string ToString()
        {
          return $"{Name}, date of birth:{dateOfBirth} - Joined: {dateOfJoin.ToShortDateString()}, Experience: {YearsOfExperience} years.";
        }
    }
}
