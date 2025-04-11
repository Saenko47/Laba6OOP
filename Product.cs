using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabaOOP6
{
    internal class Product
    {
        public string name;
        public DateTime dateOfRealease;
        public DateTime dateOfExpire;
        public decimal price;
        public string ob;
        public Product()
        {
            this.name = "No name";
            this.dateOfRealease = DateTime.Now;
            this.dateOfExpire = DateTime.Now;
            this.price = 0;
        }
        public Product(string name, DateTime dateOfRealease, DateTime dateOfExpire, decimal price)
        {
            this.name = name;
            this.dateOfRealease = dateOfRealease;
            this.dateOfExpire = dateOfExpire;
            this.price = price;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public DateTime DateOfRealease
        {
            get { return this.dateOfRealease; }
            set { this.dateOfRealease = value; }
        }
        public DateTime DateOfExpire
        {
            get { return this.dateOfExpire; }
            set { this.dateOfExpire = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public virtual bool IsProductIsExpired()
        {
            if (DateTime.Now < dateOfExpire)
            {
                return false;
            }
            else { return true; }
        }
        public string ForExpire()
        {
            return IsProductIsExpired() ? "Ні" : "Так";

        }
        public override string ToString()
        {
            return $"Назва: {name}\n" +
                   $"Дата випуску: {dateOfRealease.ToShortDateString()}\n" +
                   $"Термін придатності до: {DateOfExpire.ToShortDateString()}\n" +
                   $"Ціна: {price:C}\n" +
                   $"Придатний: {ForExpire()}";
        }

    }

}
