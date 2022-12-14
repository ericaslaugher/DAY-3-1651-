using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Person
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
        public Person()
        {
            name = "John Doe";
            Age = 1;
            System.Console.WriteLine("Default constructor of Person");
        }
        public Person(string name, int age)
        {
            //this.name = name;
            Name = name;
            Age = age;
            System.Console.WriteLine("Parameter constructor of Person");
        }
        public void Show()
        {
            System.Console.WriteLine("Name: " + name + " " + Age + " years old");
        }
    }
}