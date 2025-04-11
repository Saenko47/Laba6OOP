using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    abstract class Person
    {
        public string name;
        public DateTime dateOfBirth;
        public Person()
        {
            this.name = "No name";
            this.dateOfBirth = DateTime.Now;
        }
        public Person(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public abstract string ToString();
    }
}
