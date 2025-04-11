using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class MilkProduct : Product
    {
        public string nameOfProducer;
        public int massOfMilk;
        public MilkProduct() : base()
        {
            this.massOfMilk = 0;
            this.nameOfProducer = "No name";

        }
        public MilkProduct(string name, DateTime dateOfRelease, DateTime dateOfExpire, decimal price, string nameOfProducer, int massOfMilk) : base(name, dateOfRelease, dateOfExpire, price)
        {
            this.nameOfProducer = nameOfProducer;
            this.massOfMilk = massOfMilk;
        }
        public string NameOfProducer
        {
            get { return this.nameOfProducer; }
            set
            {
                this.nameOfProducer = value;
            }
        }
            public int MassOfMilk
        {
            get { return this.massOfMilk; }
            set { this.massOfMilk = value; }
        }
       
        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Виробник: {NameOfProducer}\n" +
                   $"Масова частка молока: {MassOfMilk}%";
        }
    }
}
