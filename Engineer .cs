using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class Engineer: Employee
    {
        public enum QualificationLevel { Trainee, Junior, Middle, Senior, Lead }
        public QualificationLevel Qualification;
        const string pattern = @"^([А-ЯІЄЇ][а-яієї]+)(\s[А-Яа-яІіЄєЇї]+)*$";
        public string? job;


        public Engineer() 
        {
            this.job= null;
        }



        public Engineer(string name, DateTime dateOfBirth, DateTime dateOfJoining, string job,bool isHaveChild,string phoneNumb, QualificationLevel Qualification, int salary ) : base(name, dateOfBirth, dateOfJoining,isHaveChild, phoneNumb, salary)
        {
            this.job = (Regex.IsMatch(job, pattern)) ? job :"no job" ;
            this.Qualification = Qualification;
           
        }
        public override string ToString()
        {
            return "engineer"+ " " + base.ToString() +  " "+
              $"job: {job}\n"+$"{Qualification}" + "-------------------------------------------------------------------------------------------------------------------------------------------------"; ;

        }

    }
}
