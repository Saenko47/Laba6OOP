using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LabaOOP6
{
    internal class Product
    {
        const string pattern = @"^[А-Яа-яЁё]+(\s[А-Яа-яЁё]+)*$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
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
            this.name = (Regex.IsMatch(name,pattern))?name:throw new Exception("Wrong name format");
            this.dateOfRealease = (Regex.IsMatch(dateOfRealease.ToString("yyyy,MM,dd"), datepattern) ? dateOfRealease : throw new Exception("Invalid dateOfRealease format."));
            this.dateOfExpire = (Regex.IsMatch(dateOfExpire.ToString("yyyy,MM,dd"), datepattern) ? dateOfExpire : throw new Exception("Invalid dateOfExpire format."));
            this.price = (price>0)? price : throw new Exception("Wrong price format");
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = (Regex.IsMatch(value, pattern)) ? value : throw new Exception("Wrong name format"); }
        }
        public DateTime DateOfRealease
        {
            get { return this.dateOfRealease; }
            set { this.dateOfRealease = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfRealease format.")) ; }
        }
        public DateTime DateOfExpire
        {
            get { return this.dateOfExpire; }
            set { this.dateOfExpire = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfExpire format.")); }
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = (value > 0) ? value : throw new Exception("Wrong price format"); }
        }
        public virtual bool IsProductIsExpired()
        {
            if (DateTime.Now < dateOfExpire)
            {
                return true;
            }
            else { return false; }
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
