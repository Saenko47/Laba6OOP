using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class Facility
    {
        public Employee[] employees;
        public string name;
        public Facility()
        {
            this.employees = new Employee[0];
            this.name = "Default Facility";
        }
        public Facility(Employee[] employees, string name)
        {
            this.employees = employees ?? new Employee[0];
            this.name = name ?? "Default Facility";
        }
        public Employee[] Employees
        {
            get { return employees; }
            set
            {
                employees = value ?? new Employee[0];
            }
        }
        public Employee this[int index]{
            get { return employees[index]; }
            set { employees[index] = value; }
            }
          
        public static Employee[] EmployeeMerch(Worker[] workers, Engineer[] engineers)
        {
            Employee[] employees = new Employee[workers.Length + engineers.Length];
            for (int k = 0; k < workers.Length; ++k)
            {
                employees[k] = workers[k];
            }
            for (int k = 0; k < engineers.Length; ++k)
            {
                employees[workers.Length + k] = engineers[k];
            }
            return employees;
        }
        public  Employee[] SortByExp()
        {

            Employee temp;
            for (int i = 0; i < employees.Length; ++i)
            {
                for (int k = 0; k < employees.Length - 1 - i; ++k)
                {
                    if (employees[k].YearsOfExperience > employees[k + 1].YearsOfExperience)
                    {
                        temp = employees[k];
                        employees[k] = employees[k + 1];
                        employees[k + 1] = temp;
                    }
                }
            }
            return employees;
        }
        public void ShowByExp(int n)
        {
            foreach (Employee e in employees)
            {
                if (e.YearsOfExperience > n)
                {
                    Console.WriteLine($"{e.Name} has more than {n} years of experience.");
                }
            }
        }
        public void ShowByChild()
        {
            foreach (Employee e in employees)
            {
                if (e.isHaveChild)
                {
                    Console.WriteLine($"{e.Name} has children.");
                }
            }
        }
        public int GetSalRaise(int n, Employee[] employee)
        {
            int exp = employee[n].YearsOfExperience;
            int salary = employee[n].salary;
            if (exp >= 10) salary += (salary * 20) / 100;
            else if (exp >= 5) salary += (salary * 15) / 100;
            else if (exp == 1) salary += (salary * 10) / 100;
            return salary;
        }
        public void WhoWillGetRaiseOfSalary()
        {
          for(int k = 0;k<employees.Length; ++k)
            {
                Console.WriteLine($"{employees[k].Name} will get a raise of salary. New salary: {GetSalRaise(k, employees)},(before:{employees[k].salary})");
                employees[k].salary = GetSalRaise(k, employees);
            }
        }
        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Facility Name: {name}");
            sb.AppendLine("Employees:");
            foreach (Employee employee in employees)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString();
        }
    }
}
