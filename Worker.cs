using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace LabaOOP6
{
    internal class Worker : Employee
    {
        public enum QualificationLevel { Unqualified, Junior, Mid, Senior, Expert }
        const string pattern = @"^([А-ЯЁ][а-яё]+)(\s[А-Яа-яЁё]+)*$";
        public string? job;
        public QualificationLevel Qualification;

        public Worker() { 
            this.job = null;
            this.Qualification = QualificationLevel.Unqualified;
        }
        
            
        
        public Worker(string name, DateTime dateOfBirth, DateTime dateOfJoining, string job,bool isHaveChild,string phoneNumb, QualificationLevel qual,int salary) : base(name, dateOfBirth, dateOfJoining, isHaveChild, phoneNumb, salary) {
            this.job = (Regex.IsMatch(job, pattern)) ? job : "no job";
            this.Qualification = qual;
        }
        public override string ToString()
        {
          return "worker" + " " + base.ToString() + " " +
            $"job: {job}\n"+$"{Qualification}"+ "-------------------------------------------------------------------------------------------------------------------------------------------------";

        }

    }
}
