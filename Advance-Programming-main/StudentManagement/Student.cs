using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        // attributes: name, age, grade
        private string name;
        private int age;
        private double grade;
        private int id;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18) age = 18;
                else age = value;
            }
        }
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0) grade = 0;
                else if (value > 10) grade = 10;
                else grade = value;
            }
        }

        // ID base count
        private static int count = 0;
        public int ID
        {
            get { return id; }
        }
        // default constructor
        public Student()
        {
            Name = "Duy Anh Dz";
            Age = 69;
            Grade = 7;
            id = ++count;
        }

        // parameter constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
            id = ++count;
        }

        // show info
        public void ShowInfo()
        {
            System.Console.WriteLine("ID: " + id);
            System.Console.WriteLine("name: " + name);
            System.Console.WriteLine("name: " + age);
            System.Console.WriteLine("name: " + grade);

        }
    }
}