using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class MilkProduct : Product
    {
        const string pattern = @"^([А-ЯЁ][а-яё]+)(\s[А-Яа-яЁё]+)*$";
        public string? nameOfProducer;
        public int massOfMilk;

        public MilkProduct() : base()
        {
            this.nameOfProducer = null;
            this.massOfMilk = 0;
        }

        public MilkProduct(string name, DateTime dateOfRelease, DateTime dateOfExpire, decimal price, string nameOfProducer, int massOfMilk)
            : base(name, dateOfRelease, dateOfExpire, price)
        {
            this.nameOfProducer = (Regex.IsMatch(nameOfProducer, pattern)) ? nameOfProducer : null;
            this.massOfMilk = (massOfMilk > 0) ? massOfMilk : 0;
        }

        public string NameOfProducer
        {
            get { return this.nameOfProducer; }
            set { this.nameOfProducer = (Regex.IsMatch(value, pattern)) ? value : null; }
        }

        public int MassOfMilk
        {
            get { return this.massOfMilk; }
            set { this.massOfMilk = (value > 0) ? value : 0; }
        }
    
    public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Виробник: {NameOfProducer}\n" +
                   $"Масова частка молока: {MassOfMilk}%";
        }
    }
}
