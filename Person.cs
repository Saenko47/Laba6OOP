using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaOOP6
{
    abstract class Person
    {
        const string phonepattern = @"^\+380-\d{2}-\d{2}-\d{2}-\d{2}";
        const string pattern = @"^([А-ЯЁ][а-яё]+)(\s[А-Яа-яЁё]+)*$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        public string? name;
        public DateTime dateOfBirth;
        public bool isHaveChild;
        string? phoneNumb;
        public Person()
        {
            this.name = null;
            this.dateOfBirth = DateTime.Now;
            this. isHaveChild = false;
            this.phoneNumb = null;
        }
        public Person(string name, DateTime dateOfBirth, bool isHaveChild,string phoneNumb)
        {
            this.name = (Regex.IsMatch(name, pattern)) ? name : null; 
            this.dateOfBirth = (Regex.IsMatch(dateOfBirth.ToString("yyyy,MM,dd"), datepattern) ? dateOfBirth : throw new Exception("Invalid dateOfBirth format.")) ;
            this.isHaveChild = isHaveChild;
            this.phoneNumb = Regex.IsMatch(phoneNumb, phonepattern) ? phoneNumb : null ;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = (Regex.IsMatch(value, pattern)) ? value : null; }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfBirth format.")); }
        }
       public bool IsHaveChild
        {
            get { return this.isHaveChild; }
            set { this.isHaveChild = value; }
            }
        public string PhoneNumb
        {
            get { return phoneNumb; }
            set { phoneNumb = Regex.IsMatch(value, phonepattern) ? value : null; }
        }

        public abstract string ToString();
    }
}
