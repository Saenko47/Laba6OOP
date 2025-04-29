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
        public string? name;
        public DateTime dateOfRelease;
        public DateTime dateOfExpire;
        public decimal price;
        public string? ob;

        public Product()
        {
            this.name = null;
            this.dateOfRelease = DateTime.Now;
            this.dateOfExpire = DateTime.Now;
            this.price = 0;
            this.ob = null;
        }

        public Product(string name, DateTime dateOfRelease, DateTime dateOfExpire, decimal price, string ob = null)
        {
            this.name = (Regex.IsMatch(name, pattern)) ? name : null;
            this.dateOfRelease = (Regex.IsMatch(dateOfRelease.ToString("yyyy,MM,dd"), datepattern) ? dateOfRelease : throw new Exception("Invalid dateOfRelease format."));
            this.dateOfExpire = (Regex.IsMatch(dateOfExpire.ToString("yyyy,MM,dd"), datepattern) ? dateOfExpire : throw new Exception("Invalid dateOfExpire format."));
            this.price = (price > 0) ? price : 0;
            this.ob = ob;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = (Regex.IsMatch(value, pattern)) ? value : null; }
        }

        public DateTime DateOfRelease
        {
            get { return this.dateOfRelease; }
            set { this.dateOfRelease = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfRelease format.")); }
        }

        public DateTime DateOfExpire
        {
            get { return this.dateOfExpire; }
            set { this.dateOfExpire = (Regex.IsMatch(value.ToString("yyyy,MM,dd"), datepattern) ? value : throw new Exception("Invalid dateOfExpire format.")); }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = (value > 0) ? value : 0; }
        }

       
    public virtual bool IsProductIsExpired()
        {
            if (DateTime.Now > dateOfExpire)
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
                   $"Дата випуску: {dateOfRelease.ToShortDateString()}\n" +
                   $"Термін придатності до: {DateOfExpire.ToShortDateString()}\n" +
                   $"Ціна: {price:C}\n" +
                   $"Придатний: {ForExpire()}";
        }

    }

}
