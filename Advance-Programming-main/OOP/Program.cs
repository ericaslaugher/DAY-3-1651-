using System;

namespace OOP
{
    class Program
    {
        private static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.Name = "Paul";
            t1.Subject = "";
            t1.Age = 20;

            System.Console.WriteLine("Name: " + t1.Name);
            System.Console.WriteLine("Subject: " + t1.Subject);
            System.Console.WriteLine("Age: " + t1.Age);
        }
    }
}