using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Student : Person // thua ke lop cha 
    {
        public Student()
        {
            Grade = 0;
            System.Console.WriteLine("Default constructor of Student");
        }
        public Student(string name, int age, double grade) : base(name, age)
        {
            Grade = grade;
            System.Console.WriteLine("Parameter constructor of Student");
        }

        public void Show(double grade)  // override method Show
        {
            base.Show();
            System.Console.WriteLine("Grade: " + grade);
        }
    }
}