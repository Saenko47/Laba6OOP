using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaOOP6
{
    abstract class Person
    {
        const string pattern = @"^([А-ЯЁ][а-яё]+)(\s[А-Яа-яЁё]+)*$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        public string name;
        public DateTime dateOfBirth;
        public Person()
        {
            this.name = "No name";
            this.dateOfBirth = DateTime.Now;
        }
        public Person(string name, DateTime dateOfBirth)
        {
            this.name = (Regex.IsMatch(name, pattern)) ? name : throw new Exception("Wrong name format"); 
            this.dateOfBirth = (Regex.IsMatch(dateOfBirth.ToString("yyyy,MM,dd"), datepattern) ? dateOfBirth : throw new Exception("Invalid dateOfBirth format.")) ;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = (Regex.IsMatch(value, pattern)) ? value : throw new Exception("Wrong name format") ; }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfBirth format.")); }
        }
        public abstract string ToString();
    }
}
