using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        private string name;  //Attribute

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }
        public int Price { get; set; } // Short-cut, No attribute
        public static int count = 0; // count number of created products object
        private int id;
        public int ID                // read-only property 
        {
            get { return id; }
        }
        //default constructor
        public Product()
        {
            Name = "No name";
            Price = 0;
            id = ++count;
        }
        //parameter constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            id = ++count;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("ID: " + ID + ", name: " + Name + ", price: " + Price);
        }

    }
}