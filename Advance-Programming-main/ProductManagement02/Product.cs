using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement02
{
    public class Product
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {
            Name = "Computer";
            Price = price;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine(name + ": $" + price);
        }
    }
}