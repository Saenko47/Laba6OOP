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
        public int salary;
      
        public int YearsOfExperience => DateTime.Now.Year - dateOfJoin.Year;
        public Employee() : base()
        {
            this.dateOfJoin = DateTime.Now;
        }
        public Employee(string name, DateTime dateOfBirth, DateTime dateOfJoin,bool isHaveChild,string phoneNumb,int salary) :base(name, dateOfBirth,isHaveChild, phoneNumb)
        {
            this.dateOfJoin = (Regex.IsMatch(dateOfJoin.ToString("yyyy,MM,dd"), datepattern) ? dateOfJoin : throw new Exception("Invalid dateOfJoin format."));
            this.salary = salary>0 ? salary : 0;
            
        }
        public DateTime DateOfJoin
        {
            get { return DateOfJoin; }
            set { this.dateOfJoin = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfJoin format.")); }
        }
        public string ForIsHaveChild()
        {
            return (isHaveChild) ? "Yes" : "Nope";
        }
        public override string ToString()
        {
          return $"{Name}, date of birth:{dateOfBirth} - Joined: {dateOfJoin.ToShortDateString()}, Experience: {YearsOfExperience} years, Does have childern:{ForIsHaveChild()} salary:{salary}";
        }
    }
}
